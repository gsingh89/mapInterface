using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustryProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(f_FormClosed);

        }

        private void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            ConnectionClass.myClose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionClass.Initialize();
            // TODO: This line of code loads data into the 'dbIndigenousPlaceNamesDataSet1.AliasedManitoba' table. You can move, or remove it, as needed.
            //this.aliasedManitobaTableAdapter.Fill(this.dbIndigenousPlaceNamesDataSet1.AliasedManitoba);
            
            // TODO: This line of code loads data into the 'testDataSet.CASUALTIES' table. You can move, or remove it, as needed.
            this.cASUALTIESTableAdapter.Fill(this.testDataSet.CASUALTIES);
        }

        
        /// <summary>
        /// Enables grid view once search label is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ToString() != null)
            {
                grpNameList.Enabled = true;
            }
            
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.DataSource = ds.Tables[0];
            //dgvSearch.DataSource = ConnectionClass.getSQLData("SELECT * FROM NAMES").Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

           string enteredName = txtSearch.Text;

        }
    }
}
