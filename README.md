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

## Working on a major change

todo