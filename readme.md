# Halcyon

Simplified view of dotnet exception stack trace

## Usage

Paste stack trace into the left panel and check wanted options.
Uses clipboard contents by default.

### Options
- Hide source assembly
- Hide calls to System.
- Hide calls to Microsoft.
- Hide async stack frames
- Hide generic/async/lambda/generator noise
- Tag frames instead of hiding them
- Show exceptions only, no frames
- Hide any stack with `*Middleware.` in the name
- Unwrap (reorder) inner exceptions

## Example

Source: [example/example.txt](example/example.txt)

Original
![](example/1-halcyon-original.png)
Hide assembly info
![](example/2-halcyon-hide-asm.png)
Hide async stacks
![](example/3-halcyon-hide-async.png)
Denoise
![](example/4-halcyon-denoise.png)
Unrap inner exceptions
![](example/5-halcyon-unwrap.png)