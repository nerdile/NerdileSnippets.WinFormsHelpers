using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdileSnippets.WinFormsHelpers
{
    public class OnError
    {
        public static async Task ShowMessageBox(Func<Task> fn)
        {
            try
            {
                await fn();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Something happened");
            }
        }

        public static async Task LogToConsole(Func<Task> fn)
        {
            try
            {
                await fn();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
