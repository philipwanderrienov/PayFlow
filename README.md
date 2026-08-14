# PayFlow

A portfolio-grade payment and transaction management platform built with ASP.NET Core, Clean Architecture, PostgreSQL, and an Angular frontend planned for Phase 3.

## Purpose
PayFlow demonstrates production-minded payment engineering: transaction lifecycle management, idempotency, webhook reliability, retries, auditability, testing, observability, containerization, and CI/CD.

## Current status
Phase 1 — Foundation. The backend solution structure and domain model are established. See [`docs/README.md`](docs/README.md) for the complete engineering roadmap.

## Quick start
Prerequisites: .NET 10 SDK and Docker.

```bash
docker compose up -d postgres
dotnet restore PayFlow.sln
dotnet build PayFlow.sln
dotnet run --project src/backend/PayFlow.Api
```

API health endpoint: `GET /health`.

## Architecture
The project starts as a modular monolith with Clean Architecture boundaries. This keeps deployment simple while preserving a path to asynchronous workers and selective service extraction when justified by scale.

## Repository layout
- `src/backend` — .NET backend projects
- `src/frontend` — Angular application (Phase 3)
- `tests` — automated tests
- `docs` — all project documentation and phase plans

## Roadmap
Foundation → Core Payments → Angular UI → Reliability → Testing & Security → Observability → Delivery → Production Readiness → Scale.
