# Module 7 – Microservices Architecture using ASP.NET Core Web API — Hands-on Practice

Covers: microservices vs monolith, inter-service communication, database-per-service,
health checks, and the service discovery pattern (config-based, lightweight version for practice).

## Projects included
Two independent, separately-runnable Web APIs simulating a microservices setup:

- **ProductService** (own "database", runs on port 5001) – owns product data.
- **OrderService** (own "database", runs on port 5002) – owns order data and calls
  `ProductService` over HTTP to validate a product before creating an order
  (inter-service communication pattern).

This mirrors "database per service" — each service only touches its own data and
talks to the other only through its public API, never its internal store.

## Problem Statements

### 1. Stand up two independent services
Run both projects at the same time (two terminals):
```
cd ProductService
dotnet run --urls http://localhost:5001

cd OrderService
dotnet run --urls http://localhost:5002
```
Confirm each has its own Swagger UI and its own in-memory data.

### 2. Inter-service communication
In `OrderService`, implement `ProductServiceClient` (already scaffolded using
`HttpClient`) so that `POST /api/orders` first calls
`GET http://localhost:5001/api/products/{id}` on ProductService to:
- confirm the product exists (404 → reject the order)
- confirm enough stock is available (400 → reject the order)

### 3. Service discovery (config-based)
Notice `ProductService:BaseUrl` in `OrderService/appsettings.json` instead of a
hardcoded URL. This is the simplest form of service discovery — the location of a
dependency is externalized to configuration rather than hardcoded, so it can change
per environment (dev/test/prod) or point at a real discovery/registry service later
(e.g. Consul, Kubernetes DNS).

### 4. Health checks
Both services expose `GET /health`. Confirm they return `200 OK` with a simple status
payload — the starting point for monitoring/orchestration to know a service is alive.

### 5. Compare with monolith
Write down (no code needed) 3 advantages and 3 challenges you observed running two
separate services vs. having Products and Orders as controllers inside one project.

### 6. (Stretch) Docker Compose
A sample `docker-compose.yml` is included. If you have Docker installed, try
`docker compose up --build` to run both services together and note how each gets its
own container and port mapping.

## Testing the flow
1. `GET http://localhost:5001/api/products` — note a product `id` and its stock.
2. `POST http://localhost:5002/api/orders` with:
   ```json
   { "productId": 1, "quantity": 2 }
   ```
3. Confirm OrderService calls ProductService internally and returns `201 Created`
   with an order summary — or a `400/404` if the product/stock check fails.
