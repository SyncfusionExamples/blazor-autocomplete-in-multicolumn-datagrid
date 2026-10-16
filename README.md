# Blazor AutoComplete in Multicolumn Data Grid

## Overview

This sample demonstrates how to display [AutoComplete](https://www.syncfusion.com/blazor-components/blazor-autocomplete) search results in a multi-column layout using Syncfusion Blazor components. Instead of showing suggestions in a traditional single-text list, the sample presents matching records with multiple fields arranged in a structured format, making it easier for users to identify and select the desired record. This approach is useful for scenarios where a single display field does not provide enough context and additional information must be shown alongside search results.

## Key Features

- Demonstrates integration of a Syncfusion AutoComplete component with a multi-column result presentation.
- Displays matching search results using a structured multi-column layout instead of a simple list.
- Shows how additional record fields can be presented during item selection.
- Provides an improved search experience when multiple attributes are required for record identification.
- Uses Blazor components to render searchable data in an interactive suggestion list.
- Demonstrates template-based rendering for AutoComplete result items.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the solution file `AutoCompleteInMultiColumn.sln`.
3. Restore all NuGet packages.
4. Set the `Server` project as the startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the Server project directory.

```bash
cd Server
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `Client/Pages/Index.razor` — contains the AutoComplete sample implementation, search configuration, and multi-column result rendering logic.
- 
## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor AutoComplete documentation: https://blazor.syncfusion.com/documentation/autocomplete/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
