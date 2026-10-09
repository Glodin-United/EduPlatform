# Glodin United Education Platform

A modular foundation for an education platform maintained by Glodin United. The initial repository establishes the backend solution, local development environment, basic domain model, and CI checks.

## Current status

This repository is a **development scaffold**, not a production-ready education service. It does not yet provide authentication, authorization, complete tenant isolation, student-facing workflows, or a finished Angular application. Do not deploy it publicly or enter real student, child, or other personal data.

## Technology baseline

- Backend: ASP.NET Core Web API, C# and .NET 10
- Persistence: Entity Framework Core with MySQL
- Frontend direction: Angular
- Local infrastructure: Docker Compose
- Validation: automated .NET build and test workflow on GitHub Actions

## Quick start

1. Install the .NET 10 SDK and Docker Desktop or Docker Engine with the Compose plugin.
2. Copy `.env.example` to `.env` and replace the placeholder passwords.
3. Start MySQL with `docker compose up -d mysql`.
4. Set the connection string environment variable:
   - PowerShell: `$env:ConnectionStrings__EducationPlatform="Server=localhost;Port=3306;Database=education_platform;User=education_app;Password=YOUR_PASSWORD"`
   - Bash: `export ConnectionStrings__EducationPlatform='Server=localhost;Port=3306;Database=education_platform;User=education_app;Password=YOUR_PASSWORD'`
5. Run `dotnet restore EducationPlatform.slnx`.
6. Run `dotnet test EducationPlatform.slnx`.
7. Run the API with `dotnet run --project src/EducationPlatform.Api`.

The API requires a valid MySQL connection string to start. Database migrations and operational readiness checks must be added before the application is used beyond local development.

## Repository layout

- `src/EducationPlatform.Api`: HTTP API, domain entities, and database context
- `tests/EducationPlatform.Api.Tests`: backend tests
- `frontend/education-platform-web`: planned Angular application placeholder
- `docs/architecture/decisions`: architecture decision records
- `docs/security`: initial security baseline
- `.github/workflows`: continuous integration

## Contribution workflow

Use a feature branch and pull request. Keep credentials out of source control, add tests for behavior changes, and review privacy and tenant isolation implications for any feature that handles learner or organization data.

## Security reports

Do not report vulnerabilities in public issues. Follow the guidance in [SECURITY-BASELINE.md](docs/security/SECURITY-BASELINE.md) and coordinate a private disclosure process with the maintainers.
