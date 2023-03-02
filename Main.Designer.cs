namespace halcyon;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.chkHideAssembly = new System.Windows.Forms.CheckBox();
            this.chkHideSystem = new System.Windows.Forms.CheckBox();
            this.chkHideMicrosoft = new System.Windows.Forms.CheckBox();
            this.chkHideAsync = new System.Windows.Forms.CheckBox();
            this.chkDenoise = new System.Windows.Forms.CheckBox();
            this.chkTagNotHide = new System.Windows.Forms.CheckBox();
            this.chkHideMethodCalls = new System.Windows.Forms.CheckBox();
            this.chkHideMiddleware = new System.Windows.Forms.CheckBox();
            this.chkUnwarp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Font = new System.Drawing.Font("Consolas", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSource.ForeColor = System.Drawing.Color.Gray;
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(420, 1095);
            this.txtSource.TabIndex = 0;
            this.txtSource.WordWrap = false;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTarget);
            this.splitContainer1.Size = new System.Drawing.Size(2143, 1095);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTarget.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTarget.Location = new System.Drawing.Point(0, 0);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(1713, 1095);
            this.txtTarget.TabIndex = 0;
            this.txtTarget.WordWrap = false;
            // 
            // chkHideAssembly
            // 
            this.chkHideAssembly.AutoSize = true;
            this.chkHideAssembly.Checked = true;
            this.chkHideAssembly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideAssembly.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.chkHideAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideAssembly.Location = new System.Drawing.Point(12, 12);
            this.chkHideAssembly.Name = "chkHideAssembly";
            this.chkHideAssembly.Size = new System.Drawing.Size(273, 36);
            this.chkHideAssembly.TabIndex = 2;
            this.chkHideAssembly.Text = "Hide source assembly";
            this.chkHideAssembly.UseVisualStyleBackColor = true;
            this.chkHideAssembly.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkHideSystem
            // 
            this.chkHideSystem.AutoSize = true;
            this.chkHideSystem.Checked = false;
            this.chkHideSystem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkHideSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideSystem.Location = new System.Drawing.Point(296, 12);
            this.chkHideSystem.Name = "chkHideSystem";
            this.chkHideSystem.Size = new System.Drawing.Size(174, 36);
            this.chkHideSystem.TabIndex = 3;
            this.chkHideSystem.Text = "Hide System";
            this.chkHideSystem.UseVisualStyleBackColor = true;
            this.chkHideSystem.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkHideMicrosoft
            // 
            this.chkHideMicrosoft.AutoSize = true;
            this.chkHideMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideMicrosoft.Location = new System.Drawing.Point(481, 12);
            this.chkHideMicrosoft.Name = "chkHideMicrosoft";
            this.chkHideMicrosoft.Size = new System.Drawing.Size(199, 36);
            this.chkHideMicrosoft.TabIndex = 4;
            this.chkHideMicrosoft.Text = "Hide Microsoft";
            this.chkHideMicrosoft.UseVisualStyleBackColor = true;
            this.chkHideMicrosoft.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkHideAsync
            // 
            this.chkHideAsync.AutoSize = true;
            this.chkHideAsync.Checked = true;
            this.chkHideAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideAsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideAsync.Location = new System.Drawing.Point(691, 12);
            this.chkHideAsync.Name = "chkHideAsync";
            this.chkHideAsync.Size = new System.Drawing.Size(157, 36);
            this.chkHideAsync.TabIndex = 5;
            this.chkHideAsync.Text = "Hide async";
            this.chkHideAsync.UseVisualStyleBackColor = true;
            this.chkHideAsync.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkDenoise
            // 
            this.chkDenoise.AutoSize = true;
            this.chkDenoise.Checked = true;
            this.chkDenoise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDenoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDenoise.Location = new System.Drawing.Point(859, 12);
            this.chkDenoise.Name = "chkDenoise";
            this.chkDenoise.Size = new System.Drawing.Size(128, 36);
            this.chkDenoise.TabIndex = 6;
            this.chkDenoise.Text = "Denoise";
            this.chkDenoise.UseVisualStyleBackColor = true;
            this.chkDenoise.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkTagNotHide
            // 
            this.chkTagNotHide.AutoSize = true;
            this.chkTagNotHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTagNotHide.Location = new System.Drawing.Point(998, 12);
            this.chkTagNotHide.Name = "chkTagNotHide";
            this.chkTagNotHide.Size = new System.Drawing.Size(244, 36);
            this.chkTagNotHide.TabIndex = 7;
            this.chkTagNotHide.Text = "Tag instead of hide";
            this.chkTagNotHide.UseVisualStyleBackColor = true;
            this.chkTagNotHide.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkHideMethodCalls
            // 
            this.chkHideMethodCalls.AutoSize = true;
            this.chkHideMethodCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideMethodCalls.Location = new System.Drawing.Point(1248, 12);
            this.chkHideMethodCalls.Name = "chkHideMethodCalls";
            this.chkHideMethodCalls.Size = new System.Drawing.Size(273, 36);
            this.chkHideMethodCalls.TabIndex = 8;
            this.chkHideMethodCalls.Text = "Show exceptions only";
            this.chkHideMethodCalls.UseVisualStyleBackColor = true;
            this.chkHideMethodCalls.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkHideMiddleware
            // 
            this.chkHideMiddleware.AutoSize = true;
            this.chkHideMiddleware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHideMiddleware.Location = new System.Drawing.Point(1527, 12);
            this.chkHideMiddleware.Name = "chkHideMiddleware";
            this.chkHideMiddleware.Size = new System.Drawing.Size(222, 36);
            this.chkHideMiddleware.TabIndex = 9;
            this.chkHideMiddleware.Text = "Hide middleware";
            this.chkHideMiddleware.UseVisualStyleBackColor = true;
            this.chkHideMiddleware.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // chkUnwarp
            // 
            this.chkUnwarp.AutoSize = true;
            this.chkUnwarp.Checked = true;
            this.chkUnwarp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnwarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnwarp.Location = new System.Drawing.Point(1755, 12);
            this.chkUnwarp.Name = "chkUnwarp";
            this.chkUnwarp.Size = new System.Drawing.Size(305, 36);
            this.chkUnwarp.TabIndex = 10;
            this.chkUnwarp.Text = "Unwrap inner exceptions";
            this.chkUnwarp.UseVisualStyleBackColor = true;
            this.chkUnwarp.CheckedChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(2143, 1171);
            this.Controls.Add(this.chkUnwarp);
            this.Controls.Add(this.chkHideMiddleware);
            this.Controls.Add(this.chkHideMethodCalls);
            this.Controls.Add(this.chkTagNotHide);
            this.Controls.Add(this.chkDenoise);
            this.Controls.Add(this.chkHideAsync);
            this.Controls.Add(this.chkHideMicrosoft);
            this.Controls.Add(this.chkHideSystem);
            this.Controls.Add(this.chkHideAssembly);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halcyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox txtSource;
    private SplitContainer splitContainer1;
    private TextBox txtTarget;
    private CheckBox chkHideAssembly;
    private CheckBox chkHideSystem;
    private CheckBox chkHideMicrosoft;
    private CheckBox chkHideAsync;
    private CheckBox chkDenoise;
    private CheckBox chkTagNotHide;
    private CheckBox chkHideMethodCalls;
    private CheckBox chkHideMiddleware;
    private CheckBox chkUnwarp;
}