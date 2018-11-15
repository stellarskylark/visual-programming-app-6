# visual-programming-app-6
A simple trivia app.

# How to use GitHub
[![Github Tutorial](https://img.youtube.com/vi/CsDbUNS_mRI/maxresdefault.jpg)](https://youtu.be/CsDbUNS_mRI)

## Updating your fork
You will want to update your fork both before you begin working on a new feature and before submitting
your PR.

In Github Desktop, click the Repository tab, then "Open in Command Prompt". If you do not have Git installed,
it will prompt you to do that. Install it, then in Command Prompt run:

```bash
git fetch upstream
git merge upstream/master
```

If it tells you that you have new changes, either commit or discard those changes, then try again.

If it tells you that `upstream` does not exist, run

```
git remote add upstream https://github.com/astroengisci/visual-programming-app-6.git
```

Also, if you cloned from this repo instead of from your fork, you will need to point `origin` to 
your fork. To do this, go to Repository > Repository Settings, and in the Remote tab paste in the
URL for *your* fork (or just change astroengisci to your username). If you haven't actually made
a fork yet, click the Fork button in the top right of this repo.

If you have merge conflicts, you will need to resolve those by committing the merge and then 
manually adjusting the files. Visual Studio will help you here by not compiling until you have
successfully resolved the conflicts.

The conflict will look something like this:

```
If you have questions, please
<<<<<<< HEAD
open an issue
=======
ask your question in IRC.
>>>>>>> master
```

Here, the space above the `=======` is the state of the file from the primary repo, HEAD, and 
everything below is the state of the file in `master` (your local copy). Decide which parts 
need to stay and which need to be removed, and delete the conflict markers.

Note that if the merge conflict is in your `.vbproj` or `.sln` file, you will have to resolve 
them with a text editor before you can open the project in Visual Studio.
