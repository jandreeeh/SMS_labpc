using SMS.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string UserName => textBoxUserName.Text.Trim();
        public string Password => textBoxPassword.Text.Trim();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        
        public void HideForm()
        {
            Hide();
        }
        public event EventHandler LoginEvent;
    }
}
