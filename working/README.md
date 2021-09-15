# Current Target
.NET 6 rc1

# CleanBlazor
The out of the box Microsoft Blazor project templates are great for getting familiar with Blazor or creating PoC apps.

However, for brand new custom Blazor projects we will usually want to remove some of the boilerplate assets (e.g. Bootstrap, the Counter component, etc.).

The **CleanBlazor** project templates save you some time by providing minimal Blazor server and wasm templates (dotnet CLI and Visual Studio). Use to start out of the box Microsoft Blazor projects minus any boilerplate and unnecessary html/css/js/razor.

**CleanBlazor** by default generates projects that target the latest .NET version.

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

### CLI Additional Options
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

*General Tip: always make sure you're IDE is up to date. Easiest is to update via the Visual Studio installer.

## Additional Resources
* [Github] [DotNet templating wiki](https://github.com/dotnet/templating/wiki)
* [Github] [Available templates for dotnet new](https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new)
* [Microsoft] [Custom templates for dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
* [Microsoft] [Tutorial: Create an item template](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)