using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System.Business_Logic_Layer;
using Student_Management_System.Data_Access_Layer;

namespace Student_Management_System.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void ClearTextBoxes()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FileHandler handler = new FileHandler();
            handler.Email = txtUsername.Text;
            handler.Password = txtPassword.Text;
            MessageBox.Show(handler.PerformLogin(), "Authentication", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
