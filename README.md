# Clean Architecture Template for .NET 9

A lightweight, opinionated **`dotnet new` project template** for ASP.NET Core Web API applications following the principles of Clean Architecture (Onion Architecture).

## Overview

This template scaffolds a ready-to-use solution structured into four distinct layers:

```
Solution
├── CleanArchitecture.Core            # Domain layer – entities, domain logic, abstractions
├── CleanArchitecture.Application     # Application layer – use cases, service interfaces
├── CleanArchitecture.Infrastructure  # Infrastructure layer – persistence, external services
└── CleanArchitecture.Api             # Presentation layer – ASP.NET Core Web API (entry point)
```

### Layer Responsibilities

| Layer | Responsibility |
|---|---|
| **Core** | Domain entities, value objects, domain events, and core abstractions. No external dependencies. |
| **Application** | Application use cases, business rules, DTOs, and service interfaces. Depends only on Core. |
| **Infrastructure** | Concrete implementations: databases, external APIs, messaging, etc. Depends on Application and Core. |
| **Api** | ASP.NET Core Web API – controllers, middleware, and request/response pipeline. Depends on Application and Infrastructure. |

### Dependency Flow

```
Api → Infrastructure → Application → Core
```

> The innermost layers (Core, Application) have **no knowledge** of outer layers, ensuring true separation of concerns.

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9)

## Installation

Install the template from the NuGet package:

```bash
dotnet new install My.CleanArchitecture.Pack
```

Or pack and install it locally from the repository root:

```bash
# 1. Pack the template
dotnet pack CleanArchitecture.Template.csproj -o dist

# 2. Install the packed template
dotnet new install ./dist/My.CleanArchitecture.Pack.1.0.0.nupkg
```

## Usage

Once installed, create a new project using the `clean-onion` short name:

```bash
dotnet new clean-onion -n MyProject
```

This will generate a fully structured solution named `MyProject` with all four layers in place.

### Example

```bash
dotnet new clean-onion -n Bookstore
cd Bookstore
dotnet run --project Bookstore.Api
```

The API will start with OpenAPI (Swagger) enabled in the Development environment at:
```
https://localhost:{port}/openapi
```

## Project Structure (after scaffolding)

```
MyProject/
├── MyProject.Core/
│   └── Extensions.cs
├── MyProject.Application/
│   └── Extensions.cs
├── MyProject.Infrastructure/
│   └── Extensions.cs
├── MyProject.Api/
│   ├── Program.cs
│   └── appsettings.json
└── MyProject.sln
```

## Uninstalling the Template

```bash
dotnet new uninstall My.CleanArchitecture.Pack
```

## Technology Stack

- **Runtime**: .NET 9
- **Framework**: ASP.NET Core 9 Web API
- **API Documentation**: Microsoft.AspNetCore.OpenApi (built-in OpenAPI support)
- **DI**: `Microsoft.Extensions.DependencyInjection`
- **Language**: C# with nullable reference types enabled

## Contributing

Contributions are welcome! Feel free to open issues or pull requests.

## Author

**Awahir**

## License

This project is licensed under the [MIT License](LICENSE).
