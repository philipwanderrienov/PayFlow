# Phase 07 — Delivery & Deployment

## Goal
Make every release reproducible and low-risk.

## Build
- Multi-stage Dockerfiles for API/UI/workers
- GitHub Actions: restore, build, test, frontend build, security checks, image build
- Staging environment and environment-specific configuration
- Version/tag strategy
- Controlled migration step
- Deployment smoke tests and rollback procedure

## Explore
Immutable artifacts, migration compatibility, blue/green vs rolling deployments, environment parity, supply-chain security.

## Definition of done
A tagged commit can be promoted through CI/CD to staging without manual build steps, and a documented rollback path exists.
