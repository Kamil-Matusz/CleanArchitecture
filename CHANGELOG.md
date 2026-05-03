# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.0.3] - 2026-05-03
### Added
- .NET 10 LTS support (default target framework)

### Changed
- Updated NuGet package versions for all supported frameworks
- .NET 10 is now the default framework when scaffolding a new project

## [1.0.2] - 2026-02-28
### Added
- .NET 8 support alongside .NET 9

## [1.0.1] - 2026-02-25

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

[Unreleased]: https://github.com/Awahir/CleanArchitecture/compare/v1.0.3...HEAD
[1.0.3]: https://github.com/Awahir/CleanArchitecture/compare/v1.0.2...v1.0.3
[1.0.2]: https://github.com/Awahir/CleanArchitecture/compare/v1.0.1...v1.0.2
[1.0.1]: https://github.com/Awahir/CleanArchitecture/compare/v1.0.0...v1.0.1
[1.0.0]: https://github.com/Awahir/CleanArchitecture/releases/tag/v1.0.0