# Phase 02 — Core Payments

## Goal
Implement the synchronous core of the payment domain before distributed processing.

## Build
- Payment, Transaction, Merchant and Idempotency records
- Create/get/list payment use cases
- Transaction history and state-transition rules
- FluentValidation and consistent Problem Details
- EF mappings and migrations
- Pagination/filtering/sorting
- Idempotency-Key behavior for payment creation
- Audit events for important state changes

## Explore
Database uniqueness vs application checks; optimistic concurrency; decimal/money modeling; UTC timestamps; safe state machines; API contracts and versioning.

## Definition of done
Duplicate client retries cannot create duplicate payments, invalid state transitions are rejected, migrations recreate the schema, and core paths have automated tests.
