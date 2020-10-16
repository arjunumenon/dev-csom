using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1
{
    public partial class fm_hello_world : System.Windows.Forms.Form
    {
        public fm_hello_world()
        {
            InitializeComponent();
        }

        private void btnUnPwd_Click(object sender, EventArgs e)
        {
            AuthenticationHelper helper = new AuthenticationHelper();

            ClientContext ctx = 
                helper.fngetAuthenticationUNPWD(txtURL.Text, txtUsername.Text, txtPassword.Text);

            lblAuthentication.Text = "Connected to " + ctx.Web.Title +
                " using Username and Password";

        }

    }
}
