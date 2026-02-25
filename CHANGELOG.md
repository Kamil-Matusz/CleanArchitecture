# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
- `README.nuget.md` – dedicated README displayed on nuget.org package page
- `PackageReadmeFile` property in `CleanArchitecture.Template.csproj` pointing to `README.nuget.md`

### Changed
- Excluded `README.nuget.md` from template content so it is not scaffolded into generated projects

## [1.0.0] - 2026-02-23

### Added
- Initial release of the Clean Architecture (`clean-onion`) dotnet new template
- Four-layer solution structure: Core, Application, Infrastructure, Api
- Dependency Injection extensions (`AddCoreServices`, `AddApplicationServices`, `AddInfrastructureServices`) in each layer
- ASP.NET Core 9 Web API entry point with OpenAPI (Swagger) support in Development
- Nullable reference types enabled by default

[Unreleased]: https://github.com/Awahir/CleanArchitecture/compare/v1.0.0...HEAD
[1.0.0]: https://github.com/Awahir/CleanArchitecture/releases/tag/v1.0.0