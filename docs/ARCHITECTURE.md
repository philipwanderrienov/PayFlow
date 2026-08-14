# Architecture

## Starting architecture
PayFlow starts as a modular monolith using Clean Architecture boundaries.

```text
Angular UI
    |
ASP.NET Core API
    |
Application use cases
    |
Domain model
    |
Infrastructure adapters
    |
PostgreSQL / external adapters
```

## Dependency rule
Domain depends on nothing. Application depends on Domain. Infrastructure implements persistence/integration concerns and depends on Application/Domain. API is the composition root.

## Why modular monolith first?
It minimizes operational overhead while preserving explicit boundaries. A payment portfolio gains more credibility from correct transaction semantics, testing, and observability than from unnecessary distributed-system complexity.

## Planned evolution
Phase 4 introduces RabbitMQ and background workers for payment/webhook processing. Redis is introduced only where a measured use case exists. Later service extraction is driven by independent scaling, deployment, ownership, or reliability requirements.

## Core modules
Identity, Merchants, Payments, Transactions, Webhooks, Audit, Reporting/Reconciliation.

## Architecture decision records
When a meaningful trade-off is made, add a short ADR under `docs/decisions/` describing context, decision, alternatives, and consequences.
