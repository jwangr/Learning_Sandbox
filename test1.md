# Testing 1
- Added commit message
- Added another branch with correct naming convention
- Added client-side validation, using githook (pre-commit):
    - Pros: Works locally; developer gets immediate feedback.
    - Cons: Doesn't work if developer adds and commits msg first (on valid branch), then creates new branch and pushes it

## Sharing with Team
- Create a separate directory, e.g. githooks, so hidden .git/hooks can be shared
- Configure git to use that directory for hooks ```git config core.hooksPath githooks```
- Each user should run: ```chmod +x githooks/pre-commit```

# Testing Branches
- YAS-9a-testing: first run config;
    - Run ```git config --get core.hooksPath``` to check folder holding hook
    - Question: does each user need to run chmod +x for these hooks to be executed?
- YAS-abc-testing
    - If you don't run any commands, and try: