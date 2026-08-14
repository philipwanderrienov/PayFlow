# Vision and Scope

## Product vision
PayFlow is a merchant-facing payment operations platform that simulates the lifecycle of real payment systems without depending on a commercial payment provider.

## Portfolio goals
Demonstrate backend engineering beyond CRUD: domain boundaries, payment state transitions, idempotency, asynchronous processing, webhook delivery, reconciliation, observability, security, automated tests, CI/CD, and production trade-offs.

## MVP
- Merchant and user identity
- Create and query payments
- Transaction lifecycle
- Idempotent payment creation
- Mock provider
- Provider callback/webhook processing
- Retry failed processing
- Search/filter/pagination
- Audit trail
- Dashboard APIs and Angular UI

## Non-goals for early phases
Real money movement, PCI card-data handling, premature Kubernetes, and splitting every module into a microservice. These can obscure the engineering lessons the project is meant to demonstrate.

## Success criteria
A reviewer can clone the repository, start dependencies with Docker, run tests, launch the API/UI, understand architecture from documentation, and follow the evolution from MVP to production readiness.
