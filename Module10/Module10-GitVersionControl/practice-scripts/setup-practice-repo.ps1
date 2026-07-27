# Sets up a scratch folder with the starting point for Module 10 exercises.
# Run this from wherever you want the practice folder created (NOT inside your
# DN5.0 submission repo). Usage: .\setup-practice-repo.ps1

New-Item -ItemType Directory -Force -Path git-practice | Out-Null
Set-Location git-practice
git init
"# Git Practice - Module 10" | Out-File -Encoding utf8 README.md
git add README.md
git commit -m "Initial commit"

Write-Host ""
Write-Host "Scratch repo ready at: $(Get-Location)"
Write-Host "Now follow README.md Exercise 2 onward from the Module10-GitVersionControl package."
