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
    public partial class Login : Form
    {
        // Instantiate SQL Connection
        SqlConnection con = new SqlConnection();
        public Login()
        {            
            SqlConnection con = new SqlConnection();
            // Connection with Login Database
            con.ConnectionString = "Data Source=Localhost\\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
            InitializeComponent();
        }

        /// <summary>
        /// Administrator logs in if both textboxes are correct
        /// Error message is displayed otherwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=Localhost\\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True";
            con.Open();

            string user = txtUsername.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("SELECT User, Password FROM Login where User='" + txtUsername.Text
                                            + "'AND Password='" + txtPassword.Text, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                Form1 mainForm = new Form1();

                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login.");
            }

            con.Close();
        }

        /// <summary>
        /// Loading Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Localhost\\SQLEXPRESS;Initial Catalog=dbLogin;Integrated Security=True");
            con.Open();
        }
    }
}
