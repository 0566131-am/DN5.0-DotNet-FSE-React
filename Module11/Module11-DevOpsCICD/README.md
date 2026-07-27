# Module 11 – DevOps and CI/CD — Hands-on Practice

Covers: DevOps concepts, Continuous Integration vs Continuous Delivery/Deployment, and
popular CI/CD tools (this practice uses GitHub Actions, since you already have a GitHub
repo for DN5.0 submissions).

## What's included
A ready-to-use GitHub Actions workflow (`.github/workflows/ci.yml`) that builds and tests
a .NET project automatically on every push — a real, working CI pipeline you can drop
into any of your Module 5/6/7 projects.

## Problem Statements

### 1. Understand the pipeline stages
Open `.github/workflows/ci.yml` and identify:
- The **trigger** (what causes this workflow to run)
- The **build** stage
- The **test** stage
- Where you'd add a **deploy** stage (commented placeholder included)

### 2. Wire it into a real project
1. Copy the `.github` folder into the root of one of your DN5.0 GitHub repo projects
   (e.g., the repo you've been pushing Module 6/7 work to).
2. Edit the `working-directory` and `dotnet-version` values in `ci.yml` to match your
   actual project folder and .NET version.
3. Commit and push.
4. Go to the **Actions** tab on GitHub and watch the workflow run.

### 3. Break it, then fix it
Intentionally introduce a compile error (e.g., remove a semicolon) in your project,
push, and watch the workflow fail red in the Actions tab. This is CI doing its job —
catching a broken build before it reaches anyone else. Fix the error and push again to
see it go green.

### 4. CI vs CD — explain in your own words
After running the pipeline, write a short paragraph (in `notes.md`, included as a
template) explaining:
- What part of what you just did counts as **Continuous Integration**
- What you would need to add to make it **Continuous Deployment** (automatic release to
  a live environment with no human approval) vs **Continuous Delivery** (automated up to
  a manual "deploy" click)

### 5. (Stretch) Add a second job
Extend `ci.yml` with a second job that runs `dotnet format --verify-no-changes` to check
code style, running in parallel with the build/test job.

## Check your understanding
Be able to name at least 3 popular CI/CD tools besides GitHub Actions (e.g., Jenkins,
GitLab CI/CD, CircleCI, Azure DevOps) and one situation where you might pick one over
another (e.g., GitHub Actions is a natural fit when your code is already on GitHub).
