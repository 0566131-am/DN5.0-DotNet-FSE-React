# Module 10 – Version Control (GIT) — Hands-on Practice

Covers: version control concepts, git init/clone, staging & committing, branching &
merging (including conflict resolution), remotes, forking, and pull request workflows.

## What's included
This module is process-practice rather than a code project, so instead of an app you get
a guided script of exercises. Work through them in order inside a scratch folder — do NOT
do this inside your DN5.0 submission repo.

## Exercise 1 — Init, stage, commit
```bash
mkdir git-practice && cd git-practice
git init
echo "# Git Practice" > README.md
git add README.md
git commit -m "Initial commit"
git log
```
Confirm `git status` shows a clean working tree after the commit.

## Exercise 2 — Branching
```bash
git branch feature/login
git checkout feature/login
echo "Login page notes" > login.md
git add login.md
git commit -m "Add login notes"
git checkout main
git branch -a
```
Confirm `login.md` disappears when you're back on `main` and reappears on
`feature/login`.

## Exercise 3 — Merging (fast-forward)
```bash
git checkout main
git merge feature/login
git log --oneline --graph
```
Confirm `login.md` is now present on `main`.

## Exercise 4 — Merge conflict (the important one)
```bash
git checkout -b feature/a
echo "Line from A" >> README.md
git commit -am "Change from feature/a"

git checkout main
git checkout -b feature/b
echo "Line from B" >> README.md
git commit -am "Change from feature/b"

git checkout main
git merge feature/a
git merge feature/b   # <-- this should conflict
```
- Open `README.md`, find the `<<<<<<<` / `=======` / `>>>>>>>` markers.
- Manually edit the file to keep both lines, remove the markers, then:
```bash
git add README.md
git commit -m "Resolve merge conflict between feature/a and feature/b"
```

## Exercise 5 — Remote repo, push, pull
```bash
# Create an empty repo on GitHub first, then:
git remote add origin <your-repo-url>
git branch -M main
git push -u origin main
```
On a second local clone (simulate a teammate):
```bash
git clone <your-repo-url> git-practice-teammate
cd git-practice-teammate
echo "Teammate's note" >> README.md
git commit -am "Teammate change"
git push
```
Back in your original folder:
```bash
git pull origin main
```

## Exercise 6 — Forking & Pull Request workflow
1. Fork any small public repo on GitHub into your own account.
2. Clone your fork locally.
3. Create a branch, make a small change (e.g., fix a typo in README), commit, push to
   your fork.
4. Open a Pull Request from your fork's branch back to the original repo (you don't have
   to actually merge it — the point is practicing the PR creation flow).

## Check your understanding
Walk through `git log --oneline --graph --all` at the end and be able to explain, for
each commit, which branch it came from and why the graph looks the way it does.
