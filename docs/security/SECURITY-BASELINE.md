# Security baseline

This document records minimum requirements for development. It is not a security certification or a substitute for a formal threat model and privacy review.

## Current limitations

The initial scaffold has no authentication or authorization and does not enforce organization-level tenant isolation. It is not suitable for public deployment or real personal data.

## Required before production

- Implement and test authentication, role-based authorization, and least-privilege access.
- Define and enforce tenant isolation at every API and data-access boundary.
- Complete a threat model and data-protection review, including GDPR obligations and child/student data risks.
- Validate all input and apply safe output handling.
- Store secrets in a dedicated secret manager; never commit them to Git.
- Configure TLS, secure headers, CORS allowlists, rate limiting, and appropriate request size limits.
- Add security-relevant audit events without logging passwords, tokens, or unnecessary personal data.
- Define retention, deletion, export, consent, and access-request workflows where applicable.
- Establish encrypted backups, restore tests, monitoring, incident response, dependency scanning, and patch management.
- Use separate development, test, and production environments with restricted access.
- Require code review and automated CI checks for changes.

## Reporting

Until a private security contact and disclosure process are published, do not include vulnerability details or personal data in public GitHub issues. Contact the repository maintainers privately.
