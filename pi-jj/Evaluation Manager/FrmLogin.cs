using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        string username = "nastavnik";
        string password = "test";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "nastavnik" && password == "test") 
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            } 
            else 
            {
                MessageBox.Show("Neispravni podaci");
            }
        }
    }
}
