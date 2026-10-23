# Blazor AutoComplete in Multi Column Data Grid

A Blazor WebAssembly sample that demonstrates the [Syncfusion Blazor AutoComplete](https://www.syncfusion.com/blazor-components/blazor-autocomplete) component displaying search suggestions in a multi-column layout. Instead of a traditional single-text suggestion list, matching records are shown with multiple fields arranged in a structured table, making it easier to identify and select the desired record.

**Documentation**: https://blazor.syncfusion.com/documentation/autocomplete/getting-started

## Prerequisites

* Visual Studio 2022 (or later) with the **.NET 10** SDK
* .NET 10.0.x runtime

## How to run the project

* Checkout this project to a location in your disk.
* Restore the NuGet packages and run the project using the .NET CLI:

```
dotnet restore
dotnet run
```

Alternatively, open the project (`AutoCompleteInMultiColumn.csproj`) using Visual Studio 2022 (or later) and run it.

## Project structure

* `Pages/Home.razor` — the AutoComplete sample page with multi-column suggestion templates.
* `DataModel/Product.cs` — the product data used to populate the AutoComplete suggestions.

## Further help

For more help, check the [ASP.NET Core Blazor documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor).