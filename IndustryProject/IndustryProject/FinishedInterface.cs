using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Data.Linq;

namespace IndustryProject
{
    /// <summary>
    /// Finished Interface forms, where everything happens.
    /// </summary>
    public partial class Form1 : Form
    {
        //Instance of a compound data table from IndigenousPlaceNames.
        private DataTable bds = new DataTable();

        /// <summary>
        /// Form to initialize and a method, as when it closes.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_FormClosing);
        }

        /// <summary>
        /// Method to use 2 different adapters, general and features adapter, as features are in combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboData.NAME_PLACES' table. You can move, or remove it, as needed.
            this.nAME_PLACESTableAdapter.Fill(this.comboData.NAME_PLACES);
            // TODO: This line of code loads data into the 'comboData.FEATURE_TYPES' table. You can move, or remove it, as needed.
            this.fEATURE_TYPESTableAdapter.Fill(this.comboData.FEATURE_TYPES);

            this.AcceptButton = this.btnSearch;
            txtSearch.Focus();
            ConnectionClass.Initialize();
        }
        /// <summary>
        /// To close connection to database and exit from application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectionClass.myClose();
            Application.Exit();
        }

        /// <summary>
        /// Method to activate lower group box.
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

        /// <summary>
        /// Method to handle the "Search" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enteredName = txtSearch.Text;

            txtSearch.SelectAll();
            txtSearch.Focus();

            //A block to build a virtual combotable to be used by labels and gridview.
            string basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name', 
                                NAME_PLACES.FEATURE_ID AS 'Unique National Identifier', NAME_PLACES.DATE_CH AS 'Date Changed',
                                NAME_PLACES.STATUS_CODE AS 'Status', NAMES.CASUALTY AS 'Casualty',
                                NAME_PLACES.ACT_FROM AS 'Act From', NAME_PLACES.ACT_TO AS 'Act To', NAME_PLACES.ACT_TO AS 'Act To',
                                PLACES.FEAT_CODE AS 'Feature Code', PLACES.MS250 AS 'NTS 250000 Map Sheet',
                                PLACES.MS50 AS 'NTS 50000 Submap Sheet', PLACES.LAT_DEG AS 'LATITUDE Degrees',
                                PLACES.LAT_MIN AS 'LATITUDE Minutes', PLACES.LAT_SEC AS 'LATITUDE Seconds',
                                PLACES.LONG_DEG AS 'LONGITUDE Degrees', PLACES.LONG_MIN AS 'LONGITUDE Minutes',
                                PLACES.LONG_SEC AS 'LONGITUDE Seconds', CASUALTIES.COMMUNITY AS 'Casualty Hometown',
                                CASUALTIES.REG_NO AS 'Casualty Regimental Number', CASUALTIES.RANK_CASUALTY AS 'Casualty Rank',
                                CASUALTIES.SURNAME AS 'Casualty Surname', CASUALTIES.GIVNAME AS 'Casualty Given Name',
                                CASUALTIES.DATE_DECEASED AS 'Casualty Date of Death', CASUALTIES.SERVED AS 'Casualty Regiment',
                                CASUALTIES.BURIED AS 'Casualty Place of Burial', FEATURE_TYPES.FEAT_TYPE AS 'Feature Type',
                                FEATURE_TYPES.DESCR AS 'Feature Type Description', PLACES.LONGITUDE, PLACES.LATITUDE
                                FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES
                                ON PLACES.PLACE_ID = NAME_PLACES.PLACE_ID LEFT JOIN CASUALTIES ON NAMES.CASUALTY_ID = CASUALTIES.CASUALTY_ID
                                LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE";

            //Message box brought about and alternative SELECT run.
            if (chkInactive.Checked)
            {
                string message = "Are you sure you want to see INACTIVE NAMES";
                string caption = "WARNING!";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, icon);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    basicQuery += " WHERE NAME_PLACES.ACT_TO != '12/31/2200' ";
                }
                else
                {
                    basicQuery += " WHERE NAME_PLACES.ACT_TO = '12/31/2200' ";
                }
            }
            else
            {
                basicQuery += " WHERE NAME_PLACES.ACT_TO = '12/31/2200' ";
            }

            //Radiobutton Maps is checked.
            if (radMaps.Checked == true && !String.IsNullOrWhiteSpace(enteredName))
            {
                
                string m250 = enteredName.Substring(0, 3);
       
                basicQuery += " AND PLACES.MS250 = @ms250";
                ConnectionClass.AddParam("ms250", m250);
                dgvSearch_SelectionChanged(sender, e);
            }

            //Radiobutton Maps is checked and more than 3 characters entered.
            if (radMaps.Checked == true && !String.IsNullOrWhiteSpace(enteredName.Substring(3)))
            {
                string m50 = enteredName.Substring(3);

                
                    basicQuery += " AND PLACES.MS50 = @ms50";
                    ConnectionClass.AddParam("ms50", m50);
                
            }

            //Radiobutton Location is checked.
            if (radLocation.Checked && !String.IsNullOrWhiteSpace(txtLatDeg.Text) && !String.IsNullOrWhiteSpace(txtLatMin.Text) &&
                !String.IsNullOrWhiteSpace(txtLatSec.Text) && !String.IsNullOrWhiteSpace(txtLongDeg.Text) &&
                !String.IsNullOrWhiteSpace(txtLongMin.Text) && !String.IsNullOrWhiteSpace(txtLongSec.Text))
            {
                basicQuery += " AND PLACES.LAT_DEG = @LatDeg";
                basicQuery += " AND PLACES.LAT_MIN = @LatMin";
                basicQuery += " AND PLACES.LAT_SEC = @LatSec";
                basicQuery += " AND PLACES.LONG_DEG = @LongDeg";
                basicQuery += " AND PLACES.LONG_MIN = @LongMin";
                basicQuery += " AND PLACES.LONG_SEC = @LongSec";

                ConnectionClass.AddParam("LatDeg", txtLatDeg.Text);
                ConnectionClass.AddParam("LatMin", txtLatMin.Text);
                ConnectionClass.AddParam("LatSec", txtLatSec.Text);
                ConnectionClass.AddParam("LongDeg", txtLongDeg.Text);
                ConnectionClass.AddParam("LongMin", txtLongMin.Text);
                ConnectionClass.AddParam("LongSec", txtLongSec.Text);
                dgvSearch_SelectionChanged(sender, e);
            }

            //Radiobutton Name is checked.
            if (radName.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " AND NAMES.NAME_ACTUAL LIKE @name + '%'";
                ConnectionClass.AddParam("name", enteredName);
                dgvSearch_SelectionChanged(sender, e);
            }

            //Radiobutton FID is checked.
            if (radFID.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " AND NAME_PLACES.FEATURE_ID = @ident";
                ConnectionClass.AddParam("ident", enteredName);
                dgvSearch_SelectionChanged(sender, e);
            }

            //Radiobutton Status is checked.
            if (radStatus.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " AND NAME_PLACES.STATUS_CODE = @statuscode";
                ConnectionClass.AddParam("statuscode", enteredName);
                dgvSearch_SelectionChanged(sender, e);
            }

            //poulate the "Virtual" table according to the choice of radiobutton and entered "parameter"
            bds = ConnectionClass.getSQLData(basicQuery).Tables[0];

            //Set the gridview's datasource.
            dgvSearch.DataSource = bds;

            //Make only name column visible
            for (int i = 1; i < dgvSearch.ColumnCount; i++)
            {
                dgvSearch.Columns[i].Visible = false;
            }

            //Set the Column's size matching to a gridview.
            dgvSearch.Columns[0].Width = dgvSearch.Width;
        }

        /// <summary>
        /// Method to update the populated labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                UpdateCasualtyCheckBox();

                lblFID.Text = dgvSearch.CurrentRow.Cells["Unique National Identifier"].Value.ToString();

                //Act From is null
                if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Act From"].Value.ToString()))
                {
                    lblFrom.Text = "No Data";
                }

                else
                {
                    String From = DateTime.Parse(dgvSearch.CurrentRow.Cells["Act From"].Value.ToString()).ToShortDateString();
                    lblFrom.Text = From;
                }

                //Act To is Null
                if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Act To"].Value.ToString()))
                {
                    lblTo.Text = "No Data";
                }

                else
                {
                    String To = DateTime.Parse(dgvSearch.CurrentRow.Cells["Act To"].Value.ToString()).ToShortDateString();
                    lblTo.Text = To;
                    if (To != "12/31/2200")
                    {
                        chkInactive.Checked = true;
                    }
                    else if (To == "12/31/2200")
                    {
                        chkInactive.Checked = false;
                    }
                }

                //Populating different labels.
                lblLatitudeDegree.Text = dgvSearch.CurrentRow.Cells["LATITUDE Degrees"].Value.ToString();
                lblLatitudeMinute.Text = dgvSearch.CurrentRow.Cells["LATITUDE Minutes"].Value.ToString();
                lblLatitudeSecond.Text = dgvSearch.CurrentRow.Cells["LATITUDE Seconds"].Value.ToString();
                lblLongitudeDegree.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Degrees"].Value.ToString();
                lblLongitudeMinute.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Minutes"].Value.ToString();
                lblLongitudeSecond.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Seconds"].Value.ToString();
                lbl250.Text = dgvSearch.CurrentRow.Cells["NTS 250000 Map Sheet"].Value.ToString();
                lbl50.Text = dgvSearch.CurrentRow.Cells["NTS 50000 Submap Sheet"].Value.ToString();

                // If there is not data available
                if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Date Changed"].Value.ToString()))
                {
                    lblDateChanged.Text = "No Data";
                }

                else
                {
                    string mess = DateTime.Parse(dgvSearch.CurrentRow.Cells["Date Changed"].Value.ToString()).ToShortDateString();
                    lblDateChanged.Text = mess;
                }

                //Combobox members populated.
                cboFear.SelectedIndex = cboFear.FindStringExact(dgvSearch.CurrentRow.Cells["Feature Type"].Value.ToString());
                cboStatus.SelectedIndex = cboStatus.FindStringExact(dgvSearch.CurrentRow.Cells["Status"].Value.ToString()); 
            }
        }

        /// <summary>
        /// Method to display red Casualties, as some names are named after casualty.
        /// </summary>
        private void UpdateCasualtyCheckBox()
        {
            if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Casualty Given Name"].Value.ToString()))
            {
                chkCasualty.Checked = false;
                chkCasualty.BackColor = Color.LightGray;
                btnCasualtyHistory.Enabled = false;
            }
            else
            {
                chkCasualty.Checked = true;
                chkCasualty.BackColor = Color.Red;
                btnCasualtyHistory.Enabled = true;
            }
        }

        /// <summary>
        /// Method to make sure checkbox gets updated as names are scrolled through.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkCasualty_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCasualtyCheckBox();
        }

        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Method for Features Combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFeature_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //A block to build a virtual combotable to be used by labels and gridview.
                string basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name', 
                                NAME_PLACES.FEATURE_ID AS 'Unique National Identifier', NAME_PLACES.DATE_CH AS 'Date Changed',
                                NAME_PLACES.STATUS_CODE AS 'Status', NAMES.CASUALTY AS 'Casualty',
                                NAME_PLACES.ACT_FROM AS 'Act From', NAME_PLACES.ACT_TO AS 'Act To', NAME_PLACES.ACT_TO AS 'Act To',
                                PLACES.FEAT_CODE AS 'Feature Code', PLACES.MS250 AS 'NTS 250000 Map Sheet',
                                PLACES.MS50 AS 'NTS 50000 Submap Sheet', PLACES.LAT_DEG AS 'LATITUDE Degrees',
                                PLACES.LAT_MIN AS 'LATITUDE Minutes', PLACES.LAT_SEC AS 'LATITUDE Seconds',
                                PLACES.LONG_DEG AS 'LONGITUDE Degrees', PLACES.LONG_MIN AS 'LONGITUDE Minutes',
                                PLACES.LONG_SEC AS 'LONGITUDE Seconds', CASUALTIES.COMMUNITY AS 'Casualty Hometown',
                                CASUALTIES.REG_NO AS 'Casualty Regimental Number', CASUALTIES.RANK_CASUALTY AS 'Casualty Rank',
                                CASUALTIES.SURNAME AS 'Casualty Surname', CASUALTIES.GIVNAME AS 'Casualty Given Name',
                                CASUALTIES.DATE_DECEASED AS 'Casualty Date of Death', CASUALTIES.SERVED AS 'Casualty Regiment',
                                CASUALTIES.BURIED AS 'Casualty Place of Burial', FEATURE_TYPES.FEAT_TYPE AS 'Feature Type',
                                FEATURE_TYPES.DESCR AS 'Feature Type Description', PLACES.LONGITUDE, PLACES.LATITUDE
                                FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES
                                ON PLACES.PLACE_ID = NAME_PLACES.PLACE_ID LEFT JOIN CASUALTIES ON NAMES.CASUALTY_ID = CASUALTIES.CASUALTY_ID
                                LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE";

                //Message box brought about and alternative SELECT run.
                if (chkInactive.Checked)
                {
                    string message = "Are you sure you want to see INACTIVE NAMES";
                    string caption = "WARNING!";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, icon);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        basicQuery += " WHERE NAME_PLACES.ACT_TO != '12/31/2200' ";
                    }
                    else
                    {
                        basicQuery += " WHERE NAME_PLACES.ACT_TO = '12/31/2200' ";
                    }
                }
                else
                {
                    basicQuery += " WHERE NAME_PLACES.ACT_TO = '12/31/2200' ";
                }

                //Radiobutton Feature selected.
                if (radFeature.Checked)
                {
                    basicQuery += " AND FEATURE_TYPES.FEAT_TYPE = @feattype";
                    ConnectionClass.AddParam("feattype", cboFeature.SelectedValue.ToString());
                }

                //Set the gridview's datasource.
                bds = ConnectionClass.getSQLData(basicQuery).Tables[0];
                dgvSearch.DataSource = bds;

                for (int i = 1; i < dgvSearch.ColumnCount; i++)
                {
                    dgvSearch.Columns[i].Visible = false;
                }

                dgvSearch.Columns[0].Width = dgvSearch.Width;
            }
            catch (Exception)
            {
                //Always one exception, 'no pointer reference on form closing'.
            }
        }

        /// <summary>
        /// Method to display or not to display stuff as Radiobutton selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radFeature_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cboFeature.Visible = true;
            btnSearch.Visible = false;
            lblSearch.Visible = false;
            cboFeature.DataSource = fEATURETYPESBindingSource;
            cboFeature.DisplayMember = "Feature Type";
            cboFeature.ValueMember = "FEAT_TYPE";
        }

        /// <summary>
        /// Method to enable lower information bar only after combobox itme selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFeature_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpNameList.Enabled = true;
        }

        /// <summary>
        /// Method for Radiobuttons to cause different visibilities, except for Feature.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeSpecificRadioAvailabel(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;

            if (btn.Name == radName.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }

            else if (btn.Name == radFeature.Name)
            {
                txtSearch.Visible = false;
                cboFeature.Visible = true;
                btnSearch.Visible = false;
                lblSearch.Visible = false;
                cboFeature.DataSource = fEATURETYPESBindingSource;
                cboFeature.DisplayMember = "Feature Type";
                cboFeature.ValueMember = "FEAT_TYPE";
            }

            else if (btn.Name == radMaps.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }

            else if (btn.Name == radLocation.Name)
            {
                txtSearch.Visible = false;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = false;

                if (radLocation.Checked)
                {
                    gpCoordinates.Visible = true;
                    lblSearch.Visible = false;
                    txtSearch.Visible = false;
                }
                else
                {
                    gpCoordinates.Visible = false;
                    lblSearch.Visible = true;
                    txtSearch.Visible = true;
                }
            }

            else if (btn.Name == radFID.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }

            else if (btn.Name == radStatus.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }
        }

        /// <summary>
        /// Method to bind lower comboboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSearch_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Queries specifically for Features and Statuses comboboxes
            string feature = @"SELECT DISTINCT FEATURE_TYPES.FEAT_TYPE AS 'Feature Type' FROM FEATURE_TYPES ORDER BY 'Feature Type' ASC";
            string status = @"SELECT DISTINCT NAME_PLACES.STATUS_CODE AS 'Status' FROM NAME_PLACES ORDER BY 'Status' ASC";

            cboFear.DataSource = ConnectionClass.getSQLData(feature).Tables[0];
            
            // In this combo box, for each value from the source
            // We display the value of feature type
            cboFear.DisplayMember =
            cboFear.ValueMember = "Feature Type";            

            if (dgvSearch.SelectedRows.Count > 0)
            {
                cboFear.SelectedIndex = cboFear.FindStringExact(dgvSearch.CurrentRow.Cells["Feature Type"].Value.ToString()); 
            }

            cboStatus.DataSource = ConnectionClass.getSQLData(status).Tables[0];
            cboStatus.DisplayMember =
            
            cboStatus.ValueMember = "Status";

            if (dgvSearch.SelectedRows.Count > 0)
            {
                cboStatus.SelectedIndex = cboStatus.FindStringExact(dgvSearch.CurrentRow.Cells["Status"].Value.ToString()); 
            }
           
        }

        /// <summary>
        /// Opens a new form
        /// Displays casualties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCasualtyHistory_Click(object sender, EventArgs e)
        {
            frmCasualty frmCasualty = new frmCasualty(dgvSearch);
            frmCasualty.ShowDialog();
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPlace_Click(object sender, EventArgs e)
        {
            newplace frm2 = new newplace();
            frm2.Show();
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPlace_Click_1(object sender, EventArgs e)
        {
            newplace place = new newplace();
            place.Show();
        }    
    }
}