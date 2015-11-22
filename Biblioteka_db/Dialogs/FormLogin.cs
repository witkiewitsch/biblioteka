using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_db
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar = ((char)7);
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            epLogin.SetIconAlignment(tbLogin, ErrorIconAlignment.MiddleLeft);
            epLogin.SetIconPadding(tbLogin, 5);
            if (tbLogin.Text.Length < 5)
            {
                epLogin.SetError(tbLogin, "Zbyt krótki login");
            }
            else if (tbLogin.Text.Length > 20)
            {
                epLogin.SetError(tbLogin, "Zbyt długi login");
            }
            else
            {
                epLogin.SetError(tbLogin, null);            
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
