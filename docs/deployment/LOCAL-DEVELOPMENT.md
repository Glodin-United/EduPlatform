# Local development

## Prerequisites

- .NET 10 SDK
- Docker Engine or Docker Desktop with Docker Compose
- Git

## Configure secrets

Copy `.env.example` to `.env`. Set strong local-only values for both MySQL passwords. The `.env` file is ignored by Git. Never commit production credentials.

## Start the database

Run `docker compose up -d mysql` from the repository root. Confirm the service is healthy with `docker compose ps`.

Set `ConnectionStrings__EducationPlatform` to a MySQL connection string. The application expects a reachable database and does not automatically create or migrate its schema yet.

## Build and test

Run:

```sh
dotnet restore EducationPlatform.slnx
dotnet build EducationPlatform.slnx --configuration Release
dotnet test EducationPlatform.slnx --configuration Release
```

## Start the API

Run:

```sh
dotnet run --project src/EducationPlatform.Api
```

Use the URL printed by ASP.NET Core. The current API is only a foundation and should not be exposed to the public internet.

## Reset local data

Stop the service with `docker compose down`. To permanently delete the local database volume, use `docker compose down -v`. This destroys local database data.
