# Vertical Slice Architecture

This repository follows a basic vertical slice architecture. Each feature lives under the `src/Features` folder. Cross-cutting concerns like `Domain`, `Application`, and `Infrastructure` have their own directories.

```
src/
  Api/             # Host project
  Features/        # Vertical slices
  Domain/          # Domain models
  Application/     # Application services and interfaces
  Infrastructure/  # Infrastructure implementations
  Shared/          # Shared utilities and helpers

tests/             # Test projects
```
