using System.Windows.Forms;

namespace NerdileSnippets.WinFormsHelpers
{
    /// <summary>
    /// Lets a Windows Forms app run until all windows are closed.
    /// To use this pattern:
    /// (1) In your Main method, create a new ExitWhenFormsClose() and pass it to Application.Run()
    ///     instead of a specific Form.
    /// (2) Any time you open a form that you want to track for closure, call AddForm.
    ///     Consider exposing this as a public static object from your Program.cs to
    ///     allow registering forms from other parts of your app.
    /// </summary>
    public class ExitWhenFormsClose : ApplicationContext
    {
        private int _count;

        public void AddForm(Form f)
        {
            _count++;
            f.Closed += (sender, args) =>
            {
                if (--_count == 0) ExitThread();
            };
        }

        public bool HasAnyWindows => _count > 0;
    }
}
