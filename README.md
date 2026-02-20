# Hospital Appointment System

A desktop application built with .NET 9.0 Windows Forms for managing hospital appointments, patients, doctors, and clinic branches.

## Overview
This system provides a structured way to handle hospital administrative tasks, including:
- **Patient Management:** Registration and management of patient records.
- **Doctor Management:** Handling doctor details and assignments to branches.
- **Branch Management:** Managing different clinic branches/departments.
- **Appointment Scheduling:** Booking and tracking patient appointments with specific doctors and working hours.
- **Admin & User Access:** Role-based access for system administrators and standard users.

The project follows a layered architecture with a clear separation between the UI (Windows Forms), the domain models, and the infrastructure (EF Core Repository pattern).

## Project Structure
- **HospitalAppointmentSystem.Main:** Contains the entry point `Program.cs`.
- **HospitalAppointmentSystem.Forms:** All Windows Forms UI components, User Controls, and Data Transfer Objects (DTOs).
- **HospitalAppointmentSystem.Model Classes:** Domain entity models (Admins, Appointments, Branches, Doctors, Patients, Users, WorkingHours).
- **HospitalAppointmentSystem.Infrastructure Components Layer:** Data access layer implementing the Repository and Unit of Work patterns, including `HospitalDbContext`.
- **HospitalAppointmentSystem.Migrations:** Entity Framework Core database migration files.
- **HospitalAppointmentSystem.Resources:** Project resources such as images and strings.

## Stack & Requirements
- **Language:** C# 13.0
- **Framework:** .NET 9.0 Windows Forms
- **ORM:** Entity Framework Core 9.0.8
- **Database:** SQL Server (LocalDB)
- **Package Manager:** NuGet

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [JetBrains Rider](https://www.jetbrains.com/rider/)
- SQL Server LocalDB (comes with Visual Studio)

## Getting Started

### 1. Clone the repository
```bash
git clone <repository-url>
cd HospitalAppointmentSystem
```

### 2. Restore Dependencies
```powershell
dotnet restore
```

### 3. Database Setup
The application uses SQL Server LocalDB. To apply migrations and create the database, run:
```powershell
dotnet ef database update --project HospitalAppointmentSystem
```
*Note: You may need the `dotnet-ef` tool installed. If not, run: `dotnet tool install --global dotnet-ef`*

### 4. Build & Run
```powershell
dotnet build
dotnet run --project HospitalAppointmentSystem
```
The application starts with the `LoginPage`.

## Scripts & Commands
- `dotnet build`: Builds the solution.
- `dotnet run --project HospitalAppointmentSystem`: Launches the Windows Forms application.
- `dotnet ef migrations add <MigrationName>`: Adds a new EF Core migration.
- `dotnet ef database update`: Updates the database to the latest migration.

## Configuration & Environment Variables
- **Database Connection String:** Located in `HospitalAppointmentSystem\Infrastructure Components Layer\HospitalDbContext.cs`. By default, it uses `(LocalDb)\MSSQLLocalDB;Initial Catalog=HospitalDB;`.
