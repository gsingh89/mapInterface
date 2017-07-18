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
        ObjectQuery <dbIndigenousPlaceNamesDataSet1> basicQuery = new ObjectQuery <dbIndigenousPlaceNamesDataSet1>(basicQuery, Context);

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
            this.aliasedManitobaTableAdapter.Fill(this.dbIndigenousPlaceNamesDataSet1.AliasedManitoba);
        }

        

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
            
            basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name' = @name, 
                                NAME_PLACES.FEATURE_ID AS 'Unique National Identifier' = @ident, 
                                PLACES.FEAT_CODE AS 'Feature Code' = @featcode, PLACES.MS250 AS 'NTS 250000 Map Sheet' = @ms250,
                                PLACES.MS50 AS 'NTS 50000 Submap Sheet' = @ms50, PLACES.LAT_DEG AS 'LATITUDE Degrees' = @latdeg,
                                PLACES.LAT_MIN AS 'LATITUDE Minutes' = @latmin, PLACES.LAT_SEC AS 'LATITUDE Seconds' = @latsec,
                                PLACES.LONG_DEG AS 'LONGITUDE Degrees' = @longdeg, PLACES.LONG_MIN AS 'LONGITUDE Minutes' = @longmin,
                                PLACES.LONG_SEC AS 'LONGITUDE Seconds' = @longsec, CASUALTIES.COMMUNITY AS 'Casualty Hometown' = @casualhome,
                                CASUALTIES.REG_NO AS 'Casualty Regimental Number' = @casualreg, CASUALTIES.RANK_CASUALTY AS 'Casualty Rank' = @casualrank,
                                CASUALTIES.SURNAME AS 'Casualty Surname' = @casualsurname, CASUALTIES.GIVNAME AS 'Casualty Given Name' = @casualgivname,
                                CASUALTIES.DATE_DECEASED AS 'Casualty Date of Death' = @casualdate, CASUALTIES.SERVED AS 'Casualty Regiment' = @casualregiment,
                                CASUALTIES.BURIED AS 'Casualty Place of Burial' = @casualburied, FEATURE_TYPES.FEAT_TYPE AS 'Feature Type' = @feattype,
                                FEATURE_TYPES.DESCR AS 'Feature Type Description' = @featdesc, PLACES.LONGITUDE = @longit, PLACES.LATITUDE = @latit
                                FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES
                                ON PLACES.PLACE_ID = NAME_PLACES.PLACE_ID LEFT JOIN CASUALTIES ON NAMES.CASUALTY_ID = CASUALTIES.CASUALTY_ID
                                LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE";

        new ObjectParameter("name", NAMES.NAME_ACTUAL),
        new ObjectParameter("ident", NAME_PLACES.FEATURE_ID)),
        new ObjectParameter("featcode", PLACES.FEAT_CODE),
        new ObjectParameter("ms250", PLACES.MS250),
        new ObjectParameter("ms50", PLACES.MS50),
        new ObjectParameter("latdeg", PLACES.LAT_DEG),
        new ObjectParameter("latmin", PLACES.LAT_MIN),
        new ObjectParameter("latsec", PLACES.LAT_SEC),
        new ObjectParameter("longdeg", PLACES.LONG_DEG),
        new ObjectParameter("longmin", PLACES.LONG_MIN),
        new ObjectParameter("longsec", PLACES.LONG_SEC),
        new ObjectParameter("casualhome", CASUALTIES.COMMUNITY),
        new ObjectParameter("casualreg", CASUALTIES.REG_NO),
        new ObjectParameter("casualrank", CASUALTIES.RANK_CASUALTY),
        new ObjectParameter("casualsurname", CASUALTIES.SURNAME),
        new ObjectParameter("casualgivname", CASUALTIES.GIVNAME),
        new ObjectParameter("casualdate", CASUALTIES.DATE_DECEASED),
        new ObjectParameter("casualregiment", CASUALTIES.SERVED),
        new ObjectParameter("casualburied", CASUALTIES.BURIED),
        new ObjectParameter("feattype", FEATURE_TYPES.FEAT_TYPE),
        new ObjectParameter("featdesc", FEATURE_TYPES.DESCR),
        new ObjectParameter("longit", PLACES.LONGITUDE),
        new ObjectParameter("latit", PLACES.LATITUDE));
            

            //basicQuery.Parameters.Add(new ObjectParameter("ln", "Adams"));

            if (radName.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {       
                  dgvSearch.DataSource = ConnectionClass.getSQLData(basicQuery + " WHERE NAMES.NAME_ACTUAL = '" + enteredName.ToString()+"'").Tables[0];
            }
        }
    }
}

