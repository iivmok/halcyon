using System.Text;
using System.Text.RegularExpressions;

namespace halcyon;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        txtSource.Text = Clipboard.GetText();
        txtSource.SelectionLength = 0;
        txtSource.SelectionStart = 0;
    }

    private void txtSource_TextChanged(object sender, EventArgs e)
    {
        var source = txtSource.Text;

        txtTarget.Text = Process(source);
    }

    private static readonly string[] AsyncBullshit = {
        "System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess",
        "System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw",
        "System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification",
        "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter.GetResult",
        "System.Runtime.CompilerServices.TaskAwaiter`1.GetResult",
    };

    private static readonly string[] KnownMiddleware = {
        "Microsoft.AspNetCore.Server.IIS.Core.IISHttpContextOfT.ProcessRequestAsync",
    };
    
    private string Process(string source)
    {

        var exceptions = new List<string>();
        var target = new StringBuilder();
        target.AppendLine();
        var depth = -1;

        var previousLineWasReplace = false;

        foreach (var sourceLine in source.Split("\r\n"))
        {
            var line = sourceLine;
            
            if(line.Trim() == "")
                continue;
            
            void Remove(string rx, string replacement = "")
            {
                line = Regex.Replace(line, rx, replacement);
            }
            var isAt = false;
            
            if (line.TrimStart().StartsWith("at "))
            {
                line = line[(line.IndexOf("at ", StringComparison.Ordinal) + 3)..];
                isAt = true;
            }
            else
            {
                if (chkUnwarp.Checked)
                {
                    exceptions.Add(target.ToString());
                    target = new StringBuilder();
                }

                depth++;
                if(depth > 0)
                    target.AppendLine();
            }

            // (System.Private.CoreLib, Version=, Culture=, PublicKeyToken=)
            if (chkHideAssembly.Checked)
                Remove(@"\((\w+((\.| )\w+)*), Version=[^,]+, Culture=[^,]+, [^)]+\)");

            var isAsyncBullshit = AsyncBullshit.Any(asyncBs => line.Trim().StartsWith(asyncBs, StringComparison.OrdinalIgnoreCase));

            if (chkDenoise.Checked)
            {
                // d__7.MoveNext
                Remove(@"d(_+\d*)?\.MoveNext");
                Remove(@"`1");
                // .c__DisplayClass0_0+<<MethodName>b__1>
                Remove(@"\.?([a-z]*_*)?DisplayClass([a-z\d_]*)");
                // +<MethodName>
                Remove(@"\.*\+<(\w*)>", @".$1");
                // +<<MethodName>g__Awaited|6_0>
                // +<<MethodName>b__1>
                Remove(@"\.*\+<<(\w+)>([a-z]*_*Awaited(\|[\d_]*)|[a-z]__\d)>", @".$1");

                // .<MethodName>b__0
                Remove(@"\.*<(\w+)>[a-z][_\d]*", @".$1");
            }

            if (chkHideAsync.Checked && isAsyncBullshit)
            {
                if (previousLineWasReplace)
                {
                    continue;
                }
                previousLineWasReplace = true;
                line = "(async)";
            }

            if (line.Trim().StartsWith("Inner exception "))
            {
                line = line[(line.IndexOf("Inner exception ", StringComparison.Ordinal) + 16)..];
            }

            if (chkHideSystem.Checked && isAt && line.Trim().StartsWith("System."))
            {
                line = "(system)";
            }
            if (chkHideMicrosoft.Checked && isAt && line.Trim().StartsWith("Microsoft."))
            {
                line = "(microsoft)";
            }
            
            
            if(line != "(async)")
                previousLineWasReplace = false;

            if (new[] { "(async)", "(microsoft)", "(system)" }.Any(x => x == line))
            {
                if(!chkTagNotHide.Checked)
                    continue;
            }

            if (isAt && (KnownMiddleware.Any(x => line.Trim().StartsWith(x)) || line.Contains("Middleware.")))
            {
                if(chkHideMiddleware.Checked)
                    continue;
            }

            if(isAt && chkHideMethodCalls.Checked)
                continue;
            
            if (!chkUnwarp.Checked)
            {
                for (var i = 0; i < depth; i++)
                    if (!chkHideMethodCalls.Checked)
                        target.Append("  ");
            }

            if(isAt)
                target.Append("  at ");

            target.AppendLine(line.Trim());


            if (!isAt && !chkHideMethodCalls.Checked)
                target.AppendLine();
        }
        exceptions.Add(target.ToString());

        exceptions.Reverse();

        return string.Join("\r\n\r\n", exceptions.Select(x => x.Trim())).Trim();
    }
}