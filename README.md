# UniversityWebAPI

## Overview

This project is a .NET solution designed to manage student information within a university context. It includes a Web API for performing CRUD (Create, Read, Update, Delete) operations on student data, a Windows Forms application for a user-friendly interface, and supporting class libraries for data models, services, and data transfer objects.

## Project Structure

The solution is organized into several projects:

-   **UniversityWebAPI.sln:** The solution file that organizes all the projects.
-   **API.Clients:** A class library containing the [`AlumnoApiClient`](API.Clients/AlumnoApiClient.cs) which handles communication with the Web API.
-   **ConsoleApp:** A console application for testing the Web API.
-   **Controllers:** Contains the [`AlumnoController`](Controllers/AlumnoController.cs) which manages API endpoints for student data.
-   **Domain.Model:** Defines the [`Alumno`](Domain.Model/Alumno.cs) domain model.
-   **Domain.Services:** Contains the [`AlumnoService`](Domain.Services/AlumnoService.cs) which provides business logic for student data.
-   **DTOs:** Defines the [`AlumnoDTO`](DTOs/AlumnoDTO.cs) data transfer object for student data.
-   **WebAPI:** The ASP.NET Core Web API project.
-   **WinFormsApp:** A Windows Forms application providing a graphical user interface for managing student data.

## Key Components

### Web API ([WebAPI](WebAPI/WebAPI.csproj))

-   Built with ASP.NET Core.
-   Provides RESTful API endpoints for managing student data.
-   Uses the Controllers, Domain.Model, Domain.Services, and DTOs projects.
-   Includes Swagger for API documentation and testing.

### Windows Forms Application ([WinFormsApp](WinFormsApp/WinFormsApp.csproj))

-   Provides a user interface for interacting with the Web API.
-   Allows users to view, add, edit, and delete student records.
-   Uses the API.Clients project to communicate with the Web API.
-   Key forms:
    -   [`AlumnoListado`](WinFormsApp/AlumnoListado.cs): Displays a list of students and provides options to add, modify, or delete them.
    -   [`AlumnoDetalle`](WinFormsApp/AlumnoDetalle.cs): Allows users to view and edit student details.

### API Clients ([API.Clients](API.Clients/API.Clients.csproj))

-   Provides a reusable client to interact with the Web API.
-   Includes methods for retrieving, creating, updating, and deleting student data.
-   Uses the DTOs project for data transfer objects.

### Domain Model ([Domain.Model](Domain.Model/Domain.Model.csproj))

-   Defines the core data model for the application.
-   Includes the [`Alumno`](Domain.Model/Alumno.cs) class, representing a student.

### Domain Services ([Domain.Services](Domain.Services/Domain.Services.csproj))

-   Contains business logic for managing student data.
-   The [`AlumnoService`](Domain.Services/AlumnoService.cs) class provides methods for CRUD operations on student records.

### DTOs ([DTOs](DTOs/DTOs.csproj))

-   Defines data transfer objects used for communication between different layers of the application.
-   Includes the [`AlumnoDTO`](DTOs/AlumnoDTO.cs) class, which represents a student data transfer object.

## Dependencies

The project uses the following NuGet packages:

-   Microsoft.AspNet.WebApi.Client
-   Swashbuckle.AspNetCore

## Getting Started

1.  Clone the repository.
2.  Open the `UniversityWebAPI.sln` solution in Visual Studio.
3.  Build the solution.
4.  Run the WebAPI project to start the API server.
5.  Run the WinFormsApp project to start the client application.