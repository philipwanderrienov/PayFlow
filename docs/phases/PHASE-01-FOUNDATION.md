# Phase 01 — Foundation

## Goal
Create a boring, dependable baseline before business features.

## Build
- [x] Solution and Clean Architecture projects
- [x] Initial Payment domain entity
- [x] PostgreSQL Docker service
- [x] EF Core DbContext foundation
- [x] API health endpoint
- [x] Unit-test project
- [ ] Run restore/build/test on a machine with .NET 10
- [ ] Create initial EF migration
- [ ] Add central package/version conventions if needed

## Explore
Why domain code should not know EF Core; when repositories add value; configuration/secrets boundaries; migration ownership.

## Definition of done
`docker compose up -d postgres`, `dotnet build PayFlow.sln`, and `dotnet test PayFlow.sln` succeed locally. No business feature work begins until the baseline is repeatable.
