# Production Readiness

This is a target checklist, not a claim that the current project is production-ready.

## Application
- [ ] Explicit transaction boundaries and concurrency strategy
- [ ] Idempotency for externally retried commands
- [ ] Outbox/inbox strategy for durable messaging
- [ ] Versioned database migrations with rollback/forward plan
- [ ] Graceful shutdown and cancellation

## Security
- [ ] OIDC/JWT authentication and RBAC
- [ ] Secrets outside source control
- [ ] Input validation and safe error responses
- [ ] Rate limiting and abuse controls
- [ ] Dependency/container vulnerability scanning
- [ ] Webhook signature verification and replay protection

## Reliability
- [ ] Bounded retries with exponential backoff and jitter
- [ ] Dead-letter handling and replay procedure
- [ ] Timeouts/circuit breakers for external calls
- [ ] Database backup and tested restore procedure
- [ ] Health/readiness probes

## Observability
- [ ] Structured logs with correlation/trace IDs
- [ ] OpenTelemetry traces and metrics
- [ ] Payment success/failure/latency dashboards
- [ ] Actionable alerts tied to SLOs

## Delivery
- [ ] Reproducible container images
- [ ] CI build/test/security gates
- [ ] Staging environment
- [ ] Controlled database migrations
- [ ] Deployment rollback strategy

## Operations
- [ ] SLO/SLI definitions
- [ ] Incident and webhook-replay runbooks
- [ ] Load and soak tests
- [ ] Failure-injection exercises
- [ ] Capacity and cost review

Production readiness is reached only when these controls are implemented, tested, and documented—not merely added as dependencies.
