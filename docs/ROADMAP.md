# Development Roadmap

The roadmap intentionally grows from a simple deployable system into a production-minded platform.

| Phase | Focus | Exit condition |
|---|---|---|
| 01 | Foundation | Solution builds, PostgreSQL runs, health endpoint works, domain tests pass |
| 02 | Core Payments | Payment/transaction APIs, persistence, validation, migrations, idempotency |
| 03 | Angular Experience | Login shell, dashboard, payment and transaction screens, API integration |
| 04 | Reliability | Mock provider, RabbitMQ workers, webhook delivery, retries, dead-letter handling |
| 05 | Quality & Security | Integration tests, auth/RBAC, secrets, rate limits, security headers |
| 06 | Observability | Structured logs, metrics, traces, correlation IDs, operational dashboards |
| 07 | Delivery | Docker images, GitHub Actions, environments, automated migrations, deployment |
| 08 | Production Readiness | Backups, restore drill, SLOs, alerts, runbooks, load tests, failure exercises |
| 09 | Scale & Evolution | Caching where justified, reconciliation, outbox pattern, selective service extraction |

## Working method
Each phase should be delivered through small issues/PRs. Avoid implementing later-phase infrastructure merely because it appears on the roadmap. Record decisions and update documentation as the system evolves.

## Portfolio checkpoints
After Phases 2, 4, 6, and 8, capture screenshots/diagrams and update the root README with measurable capabilities and trade-offs learned.
