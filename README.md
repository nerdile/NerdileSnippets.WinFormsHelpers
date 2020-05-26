# NerdileSnippets.WinFormsHelpers

Random helpers for Windows Forms apps.  .NET Core only for right now.

## OnError

For use in event handlers which are "async void".

    await OnError.ShowMessageBox(async () => {
      // do stuff
    });

## ExitWhenFormsClose

In a Windows Forms app, Application.Run(...) handles plumbing window
messages on your UI thread.  The default app template calls \
Application.Run(form1) which causes this thread to exit when that specific
form is closed.  But what if you want to have multiple windows and you want
the process to exit when _all_ windows are closed, or when specific
ones are closed?  That is what this is for.

See the class comments for details on how to use it.

