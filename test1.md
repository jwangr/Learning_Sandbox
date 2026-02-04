# Testing 1
- Added commit message
- Added another branch with correct naming convention
- Added client-side validation, using githook (pre-commit):
    - Pros: Works locally; developer gets immediate feedback.
    - Cons: Doesn't work if developer adds and commits msg first (on valid branch), then creates new branch and pushes it

## Sharing with Team
- Create a separate directory, e.g. githooks, so hidden .git/hooks can be shared
- Configure git to use that directory for hooks ```git config core.hooksPath hooks```
- Each user should run: ```chmod +x githooks/pre-commit```

# Testing Branches
- YAS-9a-testing