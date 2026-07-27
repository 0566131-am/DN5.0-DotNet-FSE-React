#!/bin/bash
# Sets up a scratch folder with the starting point for Module 10 exercises.
# Run this from wherever you want the practice folder created (NOT inside your
# DN5.0 submission repo).

set -e

mkdir -p git-practice
cd git-practice
git init
echo "# Git Practice - Module 10" > README.md
git add README.md
git commit -m "Initial commit"

echo ""
echo "Scratch repo ready at: $(pwd)"
echo "Now follow README.md Exercise 2 onward from the Module10-GitVersionControl package."
