# AGENTS.md

This file provides guidance to WARP (warp.dev) when working with code in this repository.

## Project Overview

ASP.NET Core 8.0 MVC web application for a university dashboard ("Proyecto Integrador UTT"). Displays student statistics with KPI cards and charts (bar chart for enrollment by major, doughnut chart for academic risk levels).

**Current state**: Uses mock/simulated data in the service layer. Database integration is planned but not yet implemented.

## Build and Run Commands

```powershell
# Build the project
dotnet build "Dashboards (Estadisticas).sln"

# Run the application (launches at http://localhost:5025)
dotnet run --project "Dashboards (Estadisticas)"

# Run with HTTPS (https://localhost:7154)
dotnet run --project "Dashboards (Estadisticas)" --launch-profile https

# Clean build artifacts
dotnet clean "Dashboards (Estadisticas).sln"
```

## Architecture

### MVC Structure
- **Controllers/**: `DashboardController` handles requests, uses constructor injection to receive `DashboardService`
- **Services/**: `DashboardService` provides data (currently mock data, prepared for future `ApplicationDbContext` injection)
- **Models/ViewModels/**: `DashboardVM` contains KPI properties and chart data lists
- **Views/Dashboard/**: Razor views with Chart.js integration for visualizations

### Data Flow
`DashboardController.Index()` → `DashboardService.ObtenerResumenGeneral()` → `DashboardVM` → `Views/Dashboard/Index.cshtml`

### Dependency Injection
Services are registered in `Program.cs` as scoped:
```csharp
builder.Services.AddScoped<DashboardService>();
```

### Frontend Stack
- Bootstrap 5.3 (CDN)
- Bootstrap Icons (CDN)
- Chart.js (CDN) for data visualization

### Namespaces
- Root namespace: `Dashboards__Estadisticas_` (auto-generated from project name)
- Controllers: `Dashboards.Controllers`
- Services: `Dashboards.Services`
- ViewModels: `Dashboards.Models.ViewModels`

## Language

Codebase uses **Spanish** for:
- Method names (e.g., `ObtenerResumenGeneral`, `ObtenerDatosPoblacion`)
- Property names (e.g., `TotalAlumnos`, `AlumnosEnRiesgo`, `EtiquetasCarreras`)
- UI text and comments

Maintain Spanish naming conventions when adding new code.
