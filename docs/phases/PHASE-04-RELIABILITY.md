# Phase 04 — Reliability & Messaging

## Goal
Model failures that real payment systems must survive.

## Build
- Mock payment provider with deterministic success/failure/timeout modes
- RabbitMQ and background payment worker
- Webhook delivery worker
- Exponential backoff with jitter and bounded retries
- Dead-letter queue and manual replay path
- Duplicate-message handling
- Durable outbox pattern before relying on database+broker dual writes

## Explore
At-least-once delivery, exactly-once myths, idempotent consumers, poison messages, ordering, retry storms, timeout budgets.

## Definition of done
Restarting workers or redelivering messages does not corrupt payment state. Failed webhook deliveries are observable and recoverable.
