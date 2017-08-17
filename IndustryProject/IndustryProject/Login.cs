using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IndustryProject
{
    /// <summary>
    /// Form class.
    /// </summary>
    public partial class Login : Form
    {
        string username = "admin";
        string password = "GeoManitoba2017";
        public Login()
        {
            // Press enter to click button
            InitializeComponent();            
            this.AcceptButton = this.btnLogin;
        }       

        /// <summary>                  
        /// Validation and opening main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                Form1 mainForm = new Form1();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login.");
            }
        }
    }
}