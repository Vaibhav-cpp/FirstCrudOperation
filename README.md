# FirstCrudOperation API

A clean RESTful Web API built with **ASP.NET Core**, **Entity Framework Core**, and **Microsoft SQL Server**, providing foundational CRUD (Create, Read, Update, Delete) operations for user management. The API is documented and testable via Swagger UI (OpenAPI 3.1).

---

## Features

- **Full User CRUD Lifecycle**: Endpoints for fetching all users, finding users by ID, creating new records, modifying existing records, and soft/hard deletion.
- **Interactive API Documentation**: Embedded Swagger UI (OpenAPI specification) for testing endpoints directly in the browser.
- **Relational Persistence**: Backed by Microsoft SQL Server via EF Core migrations and tracking.

---

## Tech Stack

- **Framework**: ASP.NET Core Web API
- **ORM**: Entity Framework Core
- **Database**: Microsoft SQL Server
- **Documentation**: Swagger / OpenAPI (Swashbuckle / Microsoft.AspNetCore.OpenApi)

---

## API Endpoints

All endpoints are exposed under the `User` controller:

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/User/GetAllUsers` | Retrieve a list of all registered users |
| `GET` | `/api/User/GetUserById/{id}` | Retrieve details for a specific user by ID |
| `POST` | `/api/User/CreateUser` | Create a new user record |
| `PUT` | `/api/User/UpdateUser/{id}` | Update existing user details by ID |
| `DELETE` | `/api/User/DeleteUser/{id}` | Remove a user record by ID |

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (v8.0 or later)
- [Microsoft SQL Server](https://www.microsoft.com/sql-server/) (LocalDB, Express, or standard instance)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms) or Azure Data Studio
