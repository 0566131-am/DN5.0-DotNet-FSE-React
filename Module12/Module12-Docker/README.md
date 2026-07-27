# Module 12 – Containerization using Docker — Hands-on Practice

Covers: Docker concepts and commands, images, Docker Compose, Docker Engine, storage,
networking, and container orchestration basics.

## What's included
`SampleWebApp` — a minimal ASP.NET Core Web API (a trimmed-down version of your Module 6
ProductCatalogAPI) with a `Dockerfile` and `docker-compose.yml`, so you can practice every
Docker concept in the handbook end-to-end.

## Prerequisites
Docker Desktop installed and running.

## Problem Statements

### 1. Build an image
```bash
cd SampleWebApp
docker build -t samplewebapp:v1 .
```
Confirm it appears with `docker images`.

### 2. Run a container
```bash
docker run -d -p 8080:8080 --name samplewebapp-container samplewebapp:v1
```
- `-d` = detached (background) mode
- `-p 8080:8080` = publish container port to host
- `--name` = run under a specific name

Visit `http://localhost:8080/swagger` to confirm it's alive.

### 3. Basic Docker commands
Practice each of these against your running container:
```bash
docker ps                              # list running containers
docker logs samplewebapp-container     # view logs
docker exec -it samplewebapp-container sh   # get an interactive shell inside it
docker stop samplewebapp-container
docker rm samplewebapp-container
```

### 4. Docker Compose
```bash
docker compose up --build
```
This builds and runs the same app via `docker-compose.yml` instead of manual `docker
build`/`docker run` — compare how much less typing this needs.
```bash
docker compose down
```

### 5. Docker networking
```bash
docker network ls
docker network inspect bridge
```
Identify which network your container joined by default, then try creating your own:
```bash
docker network create my-practice-net
docker run -d --network my-practice-net -p 8081:8080 --name samplewebapp-2 samplewebapp:v1
docker network inspect my-practice-net
```

### 6. Docker storage (volumes)
```bash
docker volume create samplewebapp-data
docker run -d -p 8082:8080 -v samplewebapp-data:/app/data --name samplewebapp-3 samplewebapp:v1
docker volume ls
docker volume inspect samplewebapp-data
```

### 7. (Stretch) Container orchestration — read, don't build
Docker alone runs single containers/hosts. Read up on what Kubernetes adds on top
(scheduling containers across multiple machines, self-healing, auto-scaling) and write
2-3 sentences in your own words on when you'd reach for Kubernetes instead of plain
Docker/Docker Compose.

## Check your understanding
- Docker quiz (from the handbook's GeeksforGeeks reference)
