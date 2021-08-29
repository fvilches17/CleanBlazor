# CleanBlazor
The out of the box Microsoft Blazor project templates are great for getting familiar with Blazor or creating PoC apps.

However, for brand new custom Blazor projects we will usually want to remove some of the boilerplate assets (e.g. Bootstrap, the Counter component, etc.).

The **CleanBlazor** project templates save you some time by providing minimal Blazor server and wasm templates (dotnet CLI and Visual Studio). Use to start out of the box Microsoft Blazor projects minus any boilerplate and unnecessary html/css/js/razor.

## Getting Started
1. Make sure you have the latest version of the [.NET SDK](https://dotnet.microsoft.com/download/dotnet/) installed.
2. Open a terminal (e.g. powershell or bash) in any directory.
3. Install the dotnet templates.
```
dotnet new --install FriscoVInc.DotNet.Templates.CleanBlazor
```

## Create a project (CLI)
Open a terminal in any directory and run the ```dotnet new``` command. 
Example:
```
dotnet new cleanblazorserver --output c:/source/MyBlazorServerApp
```
```
cd MyBlazorServerApp
```
```
dotnet run
```

## Create a project (Visual Studio 2022)
At time of writing (September 2021) Visual Studio 2022 doesn't seem to support cli templates in the New Project dialog. [See issue](https://developercommunity.visualstudio.com/t/net-cli-templates-in-visual-studio-missing/1508502?from=email&moreInfo=true&viewtype=all)

For now the CleanBlazor templates can be used directly via the dotnet cli.

## Additional Resources
* [Github] [DotNet templating wiki](https://github.com/dotnet/templating/wiki)
* [Github] [Available templates for dotnet new](https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new)
* [Microsoft] [Custom templates for dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
* [Microsoft] [Tutorial: Create an item template](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)