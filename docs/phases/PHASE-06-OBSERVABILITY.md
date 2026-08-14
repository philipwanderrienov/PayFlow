# Phase 06 — Observability

## Goal
Answer operational questions without attaching a debugger.

## Build
- Serilog structured logging
- Correlation IDs propagated through API/messages/webhooks
- OpenTelemetry traces and metrics
- Payment throughput, success rate, failure rate and latency metrics
- Queue depth/retry/dead-letter metrics
- Dashboards and alert candidates

## Explore
Logs vs metrics vs traces, cardinality, trace sampling, business telemetry, P50/P95/P99 latency, alert fatigue.

## Definition of done
Given a failed payment reference, an engineer can trace its path and determine where/why it failed using telemetry alone.
