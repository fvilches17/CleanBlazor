# CleanBlazor <img src="https://github.com/fvilches17/CleanBlazor/blob/main/images/blazor-logo.png" height="30">

**CleanBlazor** is listed in Microsoft's official dotnet Github repository under the [Available templates for dotnet new section](https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new).

**CleanBlazor** is also [Available on Nuget](https://www.nuget.org/packages/FriscoVInc.DotNet.Templates.CleanBlazor/) <img src="https://github.com/fvilches17/CleanBlazor/blob/main/images/nuget-logo.svg" height="30">

**CleanBlazor** by default generates projects that target the latest .NET version.

## Problem
The out of the box Microsoft Blazor project templates are great for getting familiar with Blazor or creating PoC apps.

However, for brand new custom Blazor projects we will usually want to remove some of the boilerplate assets (e.g. Bootstrap, the Counter component, etc.).

## Solution ⏱
The **CleanBlazor** project templates save you some time by providing minimal Blazor server and wasm templates (dotnet CLI and Visual Studio). Use to start out of the box Microsoft Blazor projects minus any boilerplate and unnecessary html/css/js/razor.

## Getting Started 🚀
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

### Additional CLI Options
```
dotnet new cleanblazorserver --help
```
```
dotnet new cleanblazorwasm --help
```

## Create a project (Visual Studio 2022)
1. Open Visual Studio 2022.
2. Open the New Project Dialog. CTRL+SHIFT+N.
3. Search for Clean Blazor. Alt+S, then type 'Clean Blazor'
4. Select the Clean Blazor Server or Clean Blazor Wasm project type.
5. Name project and solution.
6. Create project
7. Done!

![vs New Project dialog](https://github.com/fvilches17/CleanBlazor/blob/main/images/vs-new-project-dialog.png)

*General Tip: always make sure you're IDE is up to date. Easiest is to update via the Visual Studio installer.

## Gotcha's 😬
These project templates target .NET 6 onwards.

Every time a new .NET version comes out, the project templates will be updated accordingly to match the newest version of .NET.

Checkout the [nuget page](https://www.nuget.org/packages/FriscoVInc.DotNet.Templates.CleanBlazor/) for different versions of these templates if by any chance you want/need to target a specific .NET version.

### Tips 💪
* Use Visual Studio 2022 and keep it updated.
* If not using an IDE, make sure you have the latest version of [.NET](https://dotnet.microsoft.com/download/dotnet)
* Keep your project templates updated. Simply run: 
```
dotnet new --update-apply
```

## How to uninstall the Clean Blazor project templates
```
dotnet new --uninstall FriscoVInc.DotNet.Templates.CleanBlazor
```

Or if you want to uninstall a specific version:

```
dotnet new --uninstall
```

You now get a list of commands to uninstall any custom templates on your PC. Copy the command you want and run it.

## Additional Resources 📚
* [Github] [DotNet templating wiki](https://github.com/dotnet/templating/wiki)
* [Github] [Available templates for dotnet new](https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new)
* [Microsoft] [Custom templates for dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
* [Microsoft] [Tutorial: Create an item template](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)
* [Microsoft] [.NET CLI Templates in Visual Studio](https://devblogs.microsoft.com/dotnet/net-cli-templates-in-visual-studio/)
