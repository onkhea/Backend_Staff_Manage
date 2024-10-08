
 
 "# Backend_Staff_Manage" 
# Staff Management Application

## Overview
This is a simple Staff Management application built using ASP.NET Web API.

## Features
- Add, Edit, Delete, and Search Staff
- Advanced Search by Staff ID, Gender, and Birthday
- Export search results to Excel or PDF

## Technologies Used
- Backend: ASP.NET Web API
- CI/CD: GitHub Actions

## Setup Instructions
1. Clone the repository.
2. Navigate to the backend project and run:
   ```bash
   
dotnet add packag Microsoft.EntityFrameworkCore
dotnet add packag Microsoft.EntityFrameworkCore.SqlServer
dotnet add packag Microsoft.EntityFrameworkCore.Tools
dotnet add packag Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add packag Moq
dotnet add packag Microsoft.AspNetCore.TestHost

dotnet add packag Microsoft.EntityFrameworkCore.InMemory
dotnet add packag Moq
dotnet add packag Microsoft.AspNetCore.TestHost

dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0.0

dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet add package Microsoft.AspNet.WebApi.Client --version 6.0.0
dotnet add package Newtonsoft.Json --version 6.0.0
   dotnet restore
   dotnet build
   dotnet run
