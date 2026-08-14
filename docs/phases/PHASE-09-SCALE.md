# Phase 09 — Scale & Evolution

## Goal
Scale based on evidence and evolve boundaries without turning architecture into a showcase of buzzwords.

## Build when justified
- Reconciliation module for internal vs provider records
- Redis caching for measured hot reads, with explicit invalidation strategy
- Read models/reporting optimization
- Partition/archive strategy for transaction history
- Service extraction only for independently scaling/deploying domains
- Resilience and contract testing between extracted services

## Explore
Database bottlenecks, caching trade-offs, eventual consistency, data ownership, saga/process-manager patterns, cost vs complexity.

## Definition of done
Every scaling change links to a measured bottleneck or operational requirement and records its trade-offs in an ADR. Microservices are an outcome of constraints, not a phase checkbox.
