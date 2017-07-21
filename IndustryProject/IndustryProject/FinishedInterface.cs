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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ToString() != null)
            {
                grpNameList.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enteredName = txtSearch.Text;
            string sideQuery;

            string basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name', 
                        NAME_PLACES.FEATURE_ID AS 'Unique National Identifier',
                        NAME_PLACES.STATUS_CODE AS 'Status', NAMES.CASUALTY AS 'Casualty',
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
                        LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE ";

            if (radMaps.Checked)
            {
                radMS250.Visible = true;
                radMS50.Visible = true;

                //if (radMS250.Checked && !String.IsNullOrWhiteSpace(enteredName))
                //{
                //    basicQuery += " WHERE PLACES.MS250 = @ms250 ";
                //    sideQuery = basicQuery;
                //    ConnectionClass.AddParam("ms250", enteredName);
                //}

                //if (radMS50.Checked && !String.IsNullOrWhiteSpace(enteredName))
                //{
                //    basicQuery += " WHERE PLACES.MS50 = @ms50 ";
                //    ConnectionClass.AddParam("ms50", enteredName);
                //}
            }

            else if (radName.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAMES.NAME_ACTUAL LIKE @name + '%'";
                ConnectionClass.AddParam("name", enteredName);
            }

            else if (radFID.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAME_PLACES.FEATURE_ID = @ident";
                ConnectionClass.AddParam("ident", enteredName);
            }

            else if (radFeature.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE FEATURE_TYPES.FEAT_TYPE = @feattype";
                ConnectionClass.AddParam("feattype", enteredName);
            }


            //else if (radLocation.Checked && !String.IsNullOrWhiteSpace(enteredName))
            //{
            //    basicQuery += @" WHERE PLACES.LAT_DEG PLACES.LAT_MIN PLACES.LAT_SEC
            //                  PLACES.LONG_DEG PLACES.LONG_MIN PLACES.LONG_SEC = @coordinates";
            //    ConnectionClass.AddParam("coordinates", enteredName);
            //}

            else if (radStatus.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAME_PLACES.STATUS_CODE = @statuscode";
                ConnectionClass.AddParam("statuscode", enteredName);
            }

            dgvSearch.DataSource = ConnectionClass.getSQLData(basicQuery).Tables[0];

            for (int i = 1; i < dgvSearch.ColumnCount; i++)
            {
                dgvSearch.Columns[i].Visible = false;
            }

            dgvSearch.Columns[0].Width = dgvSearch.Width;
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCasualtyCheckBox();

            lblFID.Text = dgvSearch.CurrentRow.Cells["Unique National Identifier"].Value.ToString();
            lblLatitudeDegree.Text = dgvSearch.CurrentRow.Cells["LATITUDE Degrees"].Value.ToString();
            lblLatitudeMinute.Text = dgvSearch.CurrentRow.Cells["LATITUDE Minutes"].Value.ToString();
            lblLatitudeSecond.Text = dgvSearch.CurrentRow.Cells["LATITUDE Seconds"].Value.ToString();
            lblLongitudeDegree.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Degrees"].Value.ToString();
            lblLongitudeMinute.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Minutes"].Value.ToString();
            lblLongitudeSecond.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Seconds"].Value.ToString();
            lbl250.Text = dgvSearch.CurrentRow.Cells["NTS 250000 Map Sheet"].Value.ToString();
            lbl50.Text = dgvSearch.CurrentRow.Cells["NTS 50000 Submap Sheet"].Value.ToString();

        }

        private void UpdateCasualtyCheckBox()
        {
            if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Casualty Given Name"].Value.ToString()))
            {
                chkCasualty.Checked = false;
            }
            else
            {
                chkCasualty.Checked = true;
            }
        }

        private void ChkCasualty_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCasualtyCheckBox();
        }
    }
}

