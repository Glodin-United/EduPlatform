# ADR 0001: Start with a modular monolith

- Status: Accepted
- Date: 2026-10-09

## Context

The platform is at an early stage. Its domain boundaries, operating model, and usage patterns are not yet sufficiently proven to justify the operational cost of distributed services.

## Decision

Start with a modular monolith using ASP.NET Core and C#. Keep domain responsibilities separated into modules and avoid cross-module dependencies where practical. Use MySQL for relational persistence and Angular as the planned web client.

## Consequences

- One deployable backend is easier to develop, test, and operate at the beginning.
- Module boundaries should be explicit so that components can be extracted later if justified by real requirements.
- Authentication, authorization, organization-level data isolation, auditability, backup and recovery, and privacy requirements must be designed before real user data is processed.
- This decision does not prescribe a final deployment platform.
