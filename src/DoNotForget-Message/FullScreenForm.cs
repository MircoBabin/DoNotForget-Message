using System.Drawing;
using System.Windows.Forms;

namespace DoNotForgetMessage
{
    public partial class FullScreenForm : Form
    {
        private string _message;

        public FullScreenForm(string Message)
        {
            _message = Message;

            InitializeComponent();

            BuildForm();
        }

        private void BuildForm()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;

            this.BackColor = Color.Black;

            lblMessage.BackColor = this.BackColor;
            lblMessage.ForeColor = Color.White;

            lblMessage.Visible = true;
            lblMessage.MaximumSize = new Size(this.Width, 0);
            lblMessage.AutoSize = true;

            lblMessage.Text = _message;

            lblMessage.Top = (this.Height - lblMessage.Height) / 2;
            lblMessage.Left = (this.Width - lblMessage.Width) / 2;
        }

        private void FullScreenForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
