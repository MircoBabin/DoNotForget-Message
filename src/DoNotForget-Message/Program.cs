using System;
using System.IO;
using System.Windows.Forms;

namespace DoNotForgetMessage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string message;

            if (args.Length > 0)
            {
                message = args[0];
                if (File.Exists(message))
                {
                    message = File.ReadAllText(message, System.Text.Encoding.UTF8);
                }
                else
                {
                    message = message.Replace("\\n", Environment.NewLine);
                }
            }
            else
            {
                message = "DoNotForget-Message" + Environment.NewLine +
                    "https://github.com/MircoBabin/DoNotForget-Message" + Environment.NewLine +
                    "MIT license" + Environment.NewLine +
                    Environment.NewLine +
                    "DoNotForget-Message.exe \"<filename>\" (filename contains UTF-8 text)" + Environment.NewLine +
                    "DoNotForget-Message.exe \"<message>\" (\\n in message is newline, e.g. \"line 1\\nline 2\")" + Environment.NewLine +
                    Environment.NewLine +
                    "Press ESC to close";
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FullScreenForm(message));
        }
    }
}
