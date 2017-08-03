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
    public partial class frmCasualty : Form
    {
        DataGridView dgvSearch;

        /// <summary>
        /// Get datagridview from main form
        /// </summary>
        /// <param name="dgv"></param>
        public frmCasualty(DataGridView dgv)
        {
            dgvSearch = dgv;
            InitializeComponent();
        }

        /// <summary>
        /// Once the form is open
        /// fields should be populated already
        /// Data passing from main form
        /// Using datagriview from another form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Casualty_Load(object sender, EventArgs e)
        {
            lblsurnamebox.Text = dgvSearch.CurrentRow.Cells["Casualty Surname"].Value.ToString();
            lblGsurnamebox.Text = dgvSearch.CurrentRow.Cells["Casualty Given Name"].Value.ToString();
            //lblDivisionBox.Text = dgvSearch.CurrentRow.Cells[].Value.ToString();
            lBLCommunityBox.Text = dgvSearch.CurrentRow.Cells["Casualty Hometown"].Value.ToString();
            lblRegNoBox.Text = dgvSearch.CurrentRow.Cells["Casualty Regimental Number"].Value.ToString();
            lblRankBox.Text = dgvSearch.CurrentRow.Cells["Casualty Rank"].Value.ToString();
            lblDateOfDeathBox.Text = dgvSearch.CurrentRow.Cells["Casualty Date of Death"].Value.ToString();

            lblBuriedBox.Text = dgvSearch.CurrentRow.Cells["Casualty Place of Burial"].Value.ToString();
            lblServedBox.Text = dgvSearch.CurrentRow.Cells["Casualty Regiment"].Value.ToString();
            //lblNextOfKinNameBox.Text = dgvSearch.CurrentRow.Cells[""].Value.ToString();

            grpCasualty.Text = dgvSearch.CurrentRow.Cells["Casualty Given Name"].Value.ToString() +

                              ", " + dgvSearch.CurrentRow.Cells["Casualty Surname"].Value.ToString();
        }
    }
}
