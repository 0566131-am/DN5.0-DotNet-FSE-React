# Module 6 – ASP.NET Core 8.0 Web API — Hands-on Practice

Covers: RESTful concepts, Web API/Microservice distinction, Action Verbs, CRUD Web API,
Swagger, JWT-based authentication and authorization.

## Project included
`ProductCatalogAPI` — a working ASP.NET Core 8.0 Web API you can open directly in
Visual Studio / VS Code (`dotnet restore && dotnet run`).

## Problem Statements (attempt these yourself; solution is already wired up as reference)

### 1. RESTful CRUD design
Design and implement a `ProductsController` exposing:
- `GET /api/products` – list all
- `GET /api/products/{id}` – get one
- `POST /api/products` – create
- `PUT /api/products/{id}` – full update
- `DELETE /api/products/{id}` – delete

Use correct HTTP status codes (200, 201, 204, 404, 400) and `[ApiController]` routing attributes.

### 2. Model validation
Add data annotations to the `Product` model (`[Required]`, `[Range]`, `[StringLength]`) and confirm
`ModelState.IsValid` returns 400 with details when violated.

### 3. Swagger
Confirm Swagger UI is enabled at `/swagger` and document each endpoint with `[ProducesResponseType]`.

### 4. Global exception handling
Implement `Middleware/ExceptionMiddleware.cs` to catch unhandled exceptions and return a clean
JSON error response instead of a stack trace.

### 5. JWT Authentication
- `POST /api/auth/login` with a hardcoded demo user (`admin` / `password123`) returns a signed JWT.
- Protect `POST`, `PUT`, `DELETE` on `ProductsController` with `[Authorize]`.
- Leave `GET` endpoints anonymous.
- Verify: calling a protected endpoint without a Bearer token returns 401.

### 6. (Stretch) Role-based authorization
Add a `Role` claim to the JWT (`Admin` vs `User`) and restrict `DELETE /api/products/{id}` to `Admin`
using `[Authorize(Roles = "Admin")]`.

## How to run
```
cd ProductCatalogAPI
dotnet restore
dotnet run
```
Then open the Swagger UI URL printed in the console (e.g. `https://localhost:xxxx/swagger`).

## How to test JWT flow
1. `POST /api/auth/login` with `{ "username": "admin", "password": "password123" }`
2. Copy the `token` from the response.
3. In Swagger, click **Authorize**, enter `Bearer <token>`.
4. Now `POST/PUT/DELETE /api/products` will succeed.
