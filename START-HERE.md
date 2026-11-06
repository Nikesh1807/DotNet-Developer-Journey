# Start Here – Create Your Own GitHub Repository

This starter folder is your own new repository structure. You will create the GitHub repository yourself and push this folder to it.

## 1. Put the folder in your desired location

Extract the ZIP to:

`D:\Nikesh\Dotnet Projects\DotNet-Developer-Journey`

## 2. Open in VS Code

1. Open VS Code.
2. Select **File → Open Folder**.
3. Select `DotNet-Developer-Journey`.
4. Open **Terminal → New Terminal**.

## 3. Check Git and .NET

```bash
git --version
dotnet --version
```

If both commands show a version, continue.

## 4. Create a brand-new GitHub repository

1. Sign in to your GitHub account.
2. Click **New repository**.
3. Repository name: `DotNet-Developer-Journey`
4. Description: `My C# and .NET developer learning journey, topic-wise practice and hands-on projects.`
5. Choose **Public** if you want recruiters to see it.
6. Leave **Add a README**, **.gitignore** and **License** unchecked. This folder already contains its own README and .gitignore.
7. Click **Create repository**.

## 5. Push this folder to your new repository

In VS Code terminal, confirm the terminal is in the `DotNet-Developer-Journey` folder. Run these commands one by one:

```bash
git init
git add .
git commit -m "Create .NET Developer Journey structure"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/DotNet-Developer-Journey.git
git push -u origin main
```

Replace `YOUR-USERNAME` with your GitHub username.

If Git says `remote origin already exists`, run:

```bash
git remote set-url origin https://github.com/YOUR-USERNAME/DotNet-Developer-Journey.git
```

## 6. Commit future work

After adding or changing code:

```bash
git add .
git commit -m "Add Part 3 Dictionary practice"
git push
```

## 7. Add future parts and projects

- New learning topics go inside `CodePractice/Part-04-...`, then `Part-05-...`.
- New applications go inside `Projects/Project-02-...`, then `Project-03-...`.
- Do not create a new GitHub repository for every part or project. Keep them inside this one repository.

## 8. Keep your old folder safe

Do not delete your existing `dotnetlearning` folder. This is a separate new repository. Later, copy useful old examples into the correct files under `CodePractice/Part-01` and `CodePractice/Part-02`.
