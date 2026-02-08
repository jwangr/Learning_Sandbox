# Initialising project (controller-based web API)

```
dotnet new webapi --use-controllers -o TodoApi
cd TodoApi
dotnet add package Microsoft.EntityFrameworkCore.InMemory
code -r .
```

## Add asserts to build and debug

Via command palette: .NET: Generate Assets for Build and Debug

## Run the project via HTTPS

dotnet dev-certs https --trust

dotnet run --launch-profile https

# Testing UI using Swagger

dotnet add package NSwag.AspNetCore
Configure it in Program.cs

# Installing PostgreSQL EF Core provider

`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL`
Ensure dotnet ef is installed
Then create first migration

```bash
dotnet ef migrations add InitialCreate # rename to whatever migration to add
dotnet ef database update # applies migration to Neon
```
