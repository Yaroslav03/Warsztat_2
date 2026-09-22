# Warsztat 2

A Windows desktop application for managing the day-to-day work of an automotive repair workshop. The application brings customer and vehicle records, repair orders, workshop scheduling, inventory, and service documents together in one place.

> **Project status: Paused.** This was a commissioned project. Development is currently frozen, and the repository is provided as a snapshot of the work completed to date. It may be incomplete and should not be assumed to be production-ready or actively maintained.

## Features

- **Customers and vehicles** — store customer contact details and vehicle information, including make, model, engine, year, and VIN.
- **Repair records** — record vehicle intake details, reported issues, diagnostics, repair work, parts, and costs.
- **Order and payment management** — track order progress, estimated and final costs, work performed, and payment details.
- **Workshop schedule** — view and manage scheduled vehicle visits.
- **Warehouse inventory** — manage parts and inventory data used by the workshop.
- **Archive and history** — access archived workshop and repair records.
- **PDF documents** — generate service-related documents, including invoices and order documents.
- **Workshop overview** — display business and operational figures on the main screen.

The user interface and some document labels are in Polish.

## Technology

| Component | Technology |
|---|---|
| Language | C# |
| Platform | .NET 6 Windows Forms |
| Target framework | `net6.0-windows10.0.17763.0` |
| Database | SQLite |
| SQLite provider | System.Data.SQLite.Core 1.0.119 |
| PDF generation | PDFsharp-MigraDoc-GDI 6.2.1 |
| IDE | Visual Studio with the .NET desktop development workload |

## Repository structure

```
Warsztat_2/
├── Warsztat_2.sln                 # Visual Studio solution
└── Warsztat_2/
    ├── Program.cs                 # Application entry point
    ├── Form2.cs                   # Main window and navigation
    ├── Data.cs                    # Application data models
    ├── SqlCmd.cs                  # SQLite queries and data operations
    ├── Settings.cs                # UI and application helpers
    ├── GeneretePDF.cs             # PDF document generation
    ├── Models/                    # Additional data models
    ├── UserControls/
    │   └── BarMenu/               # Workshop screens and workflows
    └── *.db                       # SQLite database files
```

## Getting started

### Requirements

- Windows
- .NET 6 SDK
- Visual Studio 2022 with the **.NET desktop development** workload, or another compatible .NET 6 Windows Forms development setup

.NET 6 is out of support. As this project is paused, its framework and dependencies have not been updated as part of this README.

### Run from Visual Studio

1. Clone the repository:

   ```bash
   git clone https://github.com/Yaroslav03/Warsztat_2.git
   ```

2. Open `Warsztat_2.sln` in Visual Studio.
3. Restore NuGet packages when prompted.
4. Set `Warsztat_2` as the startup project.
5. Build and run the application.

### Run from the command line

From the repository root:

```bash
dotnet restore Warsztat_2.sln
dotnet run --project Warsztat_2/Warsztat_2.csproj
```

The project file is configured to copy its SQLite database files to the output directory. Keep the database files available beside the application when running a built copy.

## Data and configuration

The application uses SQLite database files stored in the `Warsztat_2` project directory. The source includes database files for workshop data, vehicles, and archives. Database contents may contain project or customer data; review and replace them with appropriate data before sharing or using the application.

## Project status and use

This repository documents a commissioned software project whose development is currently frozen. No ongoing maintenance, support, or future releases are implied. Review the implementation, database contents, and configuration for your intended environment before relying on it.



