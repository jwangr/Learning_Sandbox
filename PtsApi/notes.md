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