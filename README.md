# WebApplication + Swagger

ASP.NET Core Web API with **Swagger / OpenAPI** and dependency injection.

## Features

- Swagger UI served at the application root
- Controllers and DI (`IUserService`, `IStringService`)
- Two projects: `AuthService` (API) and a web client

## Stack

C#, ASP.NET Core, Swagger (Swashbuckle), .NET 6+.

## Run

```bash
dotnet run --project AuthService
```

Open `http://localhost:5000` — the Swagger UI is the start page.
