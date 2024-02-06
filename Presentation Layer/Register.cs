using Student_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Presentation_Layer
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FileHandler textFiles = new FileHandler();
            textFiles.Name = txtUsername.Text;
            textFiles.Surname = txtSurname.Text;
            textFiles.Email = txtEmail.Text;
            textFiles.Password = txtPassword.Text;

            MessageBox.Show(textFiles.WriteFiles(), "Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            ClearForm();
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        public void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();

        }
    }
}
