# Clean Architecture Template for .NET 8 / .NET 9

[![NuGet](https://img.shields.io/nuget/v/My.CleanArchitecture.Pack?label=NuGet&logo=nuget)](https://www.nuget.org/packages/My.CleanArchitecture.Pack)
[![NuGet Downloads](https://img.shields.io/nuget/dt/My.CleanArchitecture.Pack?label=Downloads)](https://www.nuget.org/packages/My.CleanArchitecture.Pack)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

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

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8) or [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9)

## NuGet Package

This template is published as a NuGet package and is available on **NuGet.org**:

📦 **[My.CleanArchitecture.Pack](https://www.nuget.org/packages/My.CleanArchitecture.Pack)**

You can install it directly using the .NET CLI without cloning this repository — see the [Installation](#installation) section below.

## Quick Start

```bash
# 1. Install the template
dotnet new install My.CleanArchitecture.Pack

# 2. Scaffold a new project
dotnet new clean-onion -n MyProject

# 3. Navigate to the project and run the API
cd MyProject
dotnet run --project MyProject.Api
```

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

```bash
dotnet new clean-onion -n MyProject
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

- **Runtime**: .NET 8 / .NET 9
- **Framework**: ASP.NET Core Web API
- **API Documentation**: Microsoft.AspNetCore.OpenApi (built-in OpenAPI support)
- **DI**: `Microsoft.Extensions.DependencyInjection`
- **Language**: C# with nullable reference types enabled

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for the full version history.

## Contributing

Contributions are welcome! Feel free to open issues or pull requests.

## Author

**Awahir**

## License

This project is licensed under the [MIT License](LICENSE).
