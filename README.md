# CleanBlazor <img src="https://github.com/fvilches17/CleanBlazor/blob/main/images/blazor-logo.png" height="30">
The out of the box Microsoft Blazor project templates are great for getting familiar with Blazor or creating PoC apps.

However, for brand new custom Blazor projects we will usually want to remove some of the boilerplate assets (e.g. Bootstrap, the Counter component, etc.).

The **CleanBlazor** project templates save you some time by providing minimal Blazor server and wasm templates (dotnet CLI and Visual Studio). Use to start out of the box Microsoft Blazor projects minus any boilerplate and unecessary html/css/js/razor.

[Available on Nuget](https://www.nuget.org/packages/FriscoVInc.DotNet.Templates.CleanBlazor/) <img src="https://github.com/fvilches17/CleanBlazor/blob/main/images/nuget-logo.svg" height="30">

## Getting Started
1. Make sure you have the latest version of the [.NET SDK](https://dotnet.microsoft.com/download/dotnet/) installed.
2. Open a terminal (e.g. powershell or bash) in any directory.
3. Install the dotnet templates.
```
dotnet new --install FriscoVInc.DotNet.Templates.CleanBlazor
```
![successfull install](https://github.com/fvilches17/CleanBlazor/blob/main/images/dotnet-new-install.png)
```
dotnet new --list
```
![listing dotnet templates](https://github.com/fvilches17/CleanBlazor/blob/main/images/dotnet-list.png)

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
![app running on browser](https://github.com/fvilches17/CleanBlazor/blob/main/images/app-on-browser.png)

## Create a project (Visual Studio 2022)
At time of writing (September 2021) Visual Studio 2022 doesn't seem to support cli templates in the New Project dialog. [See issue](https://developercommunity.visualstudio.com/t/net-cli-templates-in-visual-studio-missing/1508502?from=email&moreInfo=true&viewtype=all)

For now the CleanBlazor templates can be used directly via the dotnet cli.

## Additional Resources
* [Github] [DotNet templating wiki](https://github.com/dotnet/templating/wiki)
* [Github] [Available templates for dotnet new](https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new)
* [Microsoft] [Custom templates for dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
* [Microsoft] [Tutorial: Create an item template](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)
