# Phase 05 — Quality & Security

## Goal
Make correctness and security repeatable rather than manual.

## Build
- Unit tests for domain invariants
- PostgreSQL-backed integration tests (Testcontainers)
- API contract/authorization tests
- OIDC/JWT authentication and role-based authorization
- Merchant isolation rules
- Rate limiting
- Webhook HMAC signature + timestamp/replay protection
- Secret management and dependency scanning

## Explore
Test pyramid vs test value, authorization at boundaries, OWASP API risks, key rotation, least privilege, safe logging.

## Definition of done
Critical payment flows and security boundaries are automated in CI; secrets and sensitive payloads never appear in source/logs.
