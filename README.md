# Branching

Goal

- Create releases from $master
- Releases can be hotfixed
- New features to new version are created from branching from $master, merged back with a PR
- Evaluate $dev for major changes

## Starting a new PR

1. Create a new branch from destination branch (i.e. $master)
`git checkout -b feature/branch-name`
1. Commit changes
`git commit -a -m "Description of change"`
1. Push branch to origin `git push --set-upstream origin features/branch-name`
1. Start pull request on GH

To optionally squash changes before making a PR refer to https://stackoverflow.com/questions/5189560/squash-my-last-x-commits-together-using-git

`git reset --soft HEAD~3 && git commit`

## Creating a new release

To create a release using bash we need to install [hub](https://github.com/github/hub#installation).

```bash
hub release create -m "v1.5" v1.5
```

To delete a release: `hub release delete v1.5`\
To delete a tag locally: `git tag -d v1.5`\
To delete a remote tag: `git push --delete origin v1.5`

## Fix bug in a release

1. Create new branch (if not existent)

```bash
# create and set branch
git checkout -b release/v1.5 v1.5

# push remote
git push --set-upstream origin release/v1.5
```

2. Make changes and PR to it release/v1.5

```bash
# create and set branch
git checkout -b features/fix-for-v1.5.1

# commit changes
git commit -a -m "Fix error in v1.5.1"

# push to origin
git push --set-upstream origin features/fix-for-v1.5.1

# create PR in GitHub web site

```

3. Make a new release => v1.5.1

```bash
# create release v1.5.1 from branch release/v1.5
hub release create -m "v1.5.1" -t release/v1.5 v1.5.1
```

4. Fix $master too through PR or cherry-pick

4.1 Pull request

Do the pull request from bug fix branch to $master

4.2 Merging

```bash
# create branch to merge fix
git checkout -b feature/bug-fix-branch-to-master

# merge from bug fix branch
git merge feature/bug-fix-branch

# commit merge
git commit -a -m "Fix xxx"

# push change and make PR on GH
git push --set-upstream origin feature/bug-fix-branch-to-master


```

TODO

## Working on a major change

todo