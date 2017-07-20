    namespace IndustryProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radMS50 = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewPlace = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radStatus = new System.Windows.Forms.RadioButton();
            this.radFID = new System.Windows.Forms.RadioButton();
            this.radLocation = new System.Windows.Forms.RadioButton();
            this.radMS250 = new System.Windows.Forms.RadioButton();
            this.radFeature = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.grpNameList = new System.Windows.Forms.GroupBox();
            this.grpGroupName = new System.Windows.Forms.GroupBox();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl250 = new System.Windows.Forms.Label();
            this.lblLongitudeSecond = new System.Windows.Forms.Label();
            this.lblLongitudeMinute = new System.Windows.Forms.Label();
            this.lblLongitudeDegree = new System.Windows.Forms.Label();
            this.lblLatitudeSecond = new System.Windows.Forms.Label();
            this.lblLatitudeMinute = new System.Windows.Forms.Label();
            this.lblLatitudeDegree = new System.Windows.Forms.Label();
            this.btnNameHistory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFeature = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSearchBottom = new System.Windows.Forms.GroupBox();
            this.lblFID = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCasualty = new System.Windows.Forms.CheckBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.aliasedManitobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbIndigenousPlaceNamesDataSet1 = new IndustryProject.dbIndigenousPlaceNamesDataSet1();
            this.manitoba_MapperTableAdapter = new IndustryProject.dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter();
            this.aliasedManitobaTableAdapter = new IndustryProject.dbIndigenousPlaceNamesDataSet1TableAdapters.AliasedManitobaTableAdapter();
            this.grpSearch.SuspendLayout();
            this.grpNameList.SuspendLayout();
            this.grpGroupName.SuspendLayout();
            this.grpSearchBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasedManitobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbIndigenousPlaceNamesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radMS50);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnNewPlace);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.radStatus);
            this.grpSearch.Controls.Add(this.radFID);
            this.grpSearch.Controls.Add(this.radLocation);
            this.grpSearch.Controls.Add(this.radMS250);
            this.grpSearch.Controls.Add(this.radFeature);
            this.grpSearch.Controls.Add(this.radName);
            this.grpSearch.Location = new System.Drawing.Point(77, 52);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSearch.Size = new System.Drawing.Size(1437, 346);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Box";
            // 
            // radMS50
            // 
            this.radMS50.AutoSize = true;
            this.radMS50.Location = new System.Drawing.Point(620, 67);
            this.radMS50.Name = "radMS50";
            this.radMS50.Size = new System.Drawing.Size(149, 36);
            this.radMS50.TabIndex = 11;
            this.radMS50.TabStop = true;
            this.radMS50.Text = "M.S. 50";
            this.radMS50.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 243);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 55);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewPlace
            // 
            this.btnNewPlace.Location = new System.Drawing.Point(1013, 246);
            this.btnNewPlace.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNewPlace.Name = "btnNewPlace";
            this.btnNewPlace.Size = new System.Drawing.Size(200, 55);
            this.btnNewPlace.TabIndex = 9;
            this.btnNewPlace.Text = "New Place";
            this.btnNewPlace.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(211, 155);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1079, 38);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search: ";
            // 
            // radStatus
            // 
            this.radStatus.AutoSize = true;
            this.radStatus.Location = new System.Drawing.Point(1129, 67);
            this.radStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radStatus.Name = "radStatus";
            this.radStatus.Size = new System.Drawing.Size(133, 36);
            this.radStatus.TabIndex = 5;
            this.radStatus.TabStop = true;
            this.radStatus.Text = "Status";
            this.radStatus.UseVisualStyleBackColor = true;
            // 
            // radFID
            // 
            this.radFID.AutoSize = true;
            this.radFID.Location = new System.Drawing.Point(997, 67);
            this.radFID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radFID.Name = "radFID";
            this.radFID.Size = new System.Drawing.Size(96, 36);
            this.radFID.TabIndex = 4;
            this.radFID.TabStop = true;
            this.radFID.Text = "FID";
            this.radFID.UseVisualStyleBackColor = true;
            // 
            // radLocation
            // 
            this.radLocation.AutoSize = true;
            this.radLocation.Location = new System.Drawing.Point(800, 67);
            this.radLocation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radLocation.Name = "radLocation";
            this.radLocation.Size = new System.Drawing.Size(161, 36);
            this.radLocation.TabIndex = 3;
            this.radLocation.TabStop = true;
            this.radLocation.Text = "Location";
            this.radLocation.UseVisualStyleBackColor = true;
            // 
            // radMS250
            // 
            this.radMS250.AutoSize = true;
            this.radMS250.Location = new System.Drawing.Point(424, 67);
            this.radMS250.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radMS250.Name = "radMS250";
            this.radMS250.Size = new System.Drawing.Size(165, 36);
            this.radMS250.TabIndex = 2;
            this.radMS250.TabStop = true;
            this.radMS250.Text = "M.S. 250";
            this.radMS250.UseVisualStyleBackColor = true;
            // 
            // radFeature
            // 
            this.radFeature.AutoSize = true;
            this.radFeature.Location = new System.Drawing.Point(238, 67);
            this.radFeature.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radFeature.Name = "radFeature";
            this.radFeature.Size = new System.Drawing.Size(150, 36);
            this.radFeature.TabIndex = 1;
            this.radFeature.TabStop = true;
            this.radFeature.Text = "Feature";
            this.radFeature.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(75, 67);
            this.radName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(127, 36);
            this.radName.TabIndex = 0;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // grpNameList
            // 
            this.grpNameList.Controls.Add(this.grpGroupName);
            this.grpNameList.Controls.Add(this.grpSearchBottom);
            this.grpNameList.Enabled = false;
            this.grpNameList.Location = new System.Drawing.Point(77, 470);
            this.grpNameList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpNameList.Name = "grpNameList";
            this.grpNameList.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpNameList.Size = new System.Drawing.Size(1560, 699);
            this.grpNameList.TabIndex = 2;
            this.grpNameList.TabStop = false;
            this.grpNameList.Text = "Name List";
            // 
            // grpGroupName
            // 
            this.grpGroupName.Controls.Add(this.lbl50);
            this.grpGroupName.Controls.Add(this.lbl250);
            this.grpGroupName.Controls.Add(this.lblLongitudeSecond);
            this.grpGroupName.Controls.Add(this.lblLongitudeMinute);
            this.grpGroupName.Controls.Add(this.lblLongitudeDegree);
            this.grpGroupName.Controls.Add(this.lblLatitudeSecond);
            this.grpGroupName.Controls.Add(this.lblLatitudeMinute);
            this.grpGroupName.Controls.Add(this.lblLatitudeDegree);
            this.grpGroupName.Controls.Add(this.btnNameHistory);
            this.grpGroupName.Controls.Add(this.label8);
            this.grpGroupName.Controls.Add(this.label7);
            this.grpGroupName.Controls.Add(this.label6);
            this.grpGroupName.Controls.Add(this.label5);
            this.grpGroupName.Controls.Add(this.label4);
            this.grpGroupName.Controls.Add(this.cboFeature);
            this.grpGroupName.Controls.Add(this.label3);
            this.grpGroupName.Location = new System.Drawing.Point(840, 45);
            this.grpGroupName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpGroupName.Name = "grpGroupName";
            this.grpGroupName.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpGroupName.Size = new System.Drawing.Size(704, 639);
            this.grpGroupName.TabIndex = 1;
            this.grpGroupName.TabStop = false;
            this.grpGroupName.Text = "Group Name";
            // 
            // lbl50
            // 
            this.lbl50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl50.Location = new System.Drawing.Point(546, 382);
            this.lbl50.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(77, 50);
            this.lbl50.TabIndex = 26;
            this.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl250
            // 
            this.lbl250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl250.Location = new System.Drawing.Point(358, 382);
            this.lbl250.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl250.Name = "lbl250";
            this.lbl250.Size = new System.Drawing.Size(77, 50);
            this.lbl250.TabIndex = 25;
            this.lbl250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeSecond
            // 
            this.lblLongitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeSecond.Location = new System.Drawing.Point(418, 258);
            this.lblLongitudeSecond.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLongitudeSecond.Name = "lblLongitudeSecond";
            this.lblLongitudeSecond.Size = new System.Drawing.Size(117, 50);
            this.lblLongitudeSecond.TabIndex = 23;
            this.lblLongitudeSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeMinute
            // 
            this.lblLongitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeMinute.Location = new System.Drawing.Point(325, 258);
            this.lblLongitudeMinute.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLongitudeMinute.Name = "lblLongitudeMinute";
            this.lblLongitudeMinute.Size = new System.Drawing.Size(77, 50);
            this.lblLongitudeMinute.TabIndex = 22;
            this.lblLongitudeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeDegree
            // 
            this.lblLongitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeDegree.Location = new System.Drawing.Point(219, 258);
            this.lblLongitudeDegree.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLongitudeDegree.Name = "lblLongitudeDegree";
            this.lblLongitudeDegree.Size = new System.Drawing.Size(77, 50);
            this.lblLongitudeDegree.TabIndex = 21;
            this.lblLongitudeDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeSecond
            // 
            this.lblLatitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeSecond.Location = new System.Drawing.Point(418, 160);
            this.lblLatitudeSecond.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLatitudeSecond.Name = "lblLatitudeSecond";
            this.lblLatitudeSecond.Size = new System.Drawing.Size(117, 50);
            this.lblLatitudeSecond.TabIndex = 20;
            this.lblLatitudeSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeMinute
            // 
            this.lblLatitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeMinute.Location = new System.Drawing.Point(325, 160);
            this.lblLatitudeMinute.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLatitudeMinute.Name = "lblLatitudeMinute";
            this.lblLatitudeMinute.Size = new System.Drawing.Size(77, 50);
            this.lblLatitudeMinute.TabIndex = 19;
            this.lblLatitudeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeDegree
            // 
            this.lblLatitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeDegree.Location = new System.Drawing.Point(219, 160);
            this.lblLatitudeDegree.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblLatitudeDegree.Name = "lblLatitudeDegree";
            this.lblLatitudeDegree.Size = new System.Drawing.Size(77, 50);
            this.lblLatitudeDegree.TabIndex = 18;
            this.lblLatitudeDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNameHistory
            // 
            this.btnNameHistory.Location = new System.Drawing.Point(88, 556);
            this.btnNameHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNameHistory.Name = "btnNameHistory";
            this.btnNameHistory.Size = new System.Drawing.Size(309, 55);
            this.btnNameHistory.TabIndex = 16;
            this.btnNameHistory.Text = "Name History";
            this.btnNameHistory.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(485, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "50: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(285, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "250: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Map Sheets: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Longitude: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latitude: ";
            // 
            // cboFeature
            // 
            this.cboFeature.FormattingEnabled = true;
            this.cboFeature.Location = new System.Drawing.Point(219, 48);
            this.cboFeature.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboFeature.Name = "cboFeature";
            this.cboFeature.Size = new System.Drawing.Size(316, 39);
            this.cboFeature.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Feature: ";
            // 
            // grpSearchBottom
            // 
            this.grpSearchBottom.Controls.Add(this.lblFID);
            this.grpSearchBottom.Controls.Add(this.cboStatus);
            this.grpSearchBottom.Controls.Add(this.label2);
            this.grpSearchBottom.Controls.Add(this.chkCasualty);
            this.grpSearchBottom.Controls.Add(this.lbltext);
            this.grpSearchBottom.Controls.Add(this.dgvSearch);
            this.grpSearchBottom.Location = new System.Drawing.Point(40, 45);
            this.grpSearchBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSearchBottom.Name = "grpSearchBottom";
            this.grpSearchBottom.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSearchBottom.Size = new System.Drawing.Size(752, 639);
            this.grpSearchBottom.TabIndex = 0;
            this.grpSearchBottom.TabStop = false;
            this.grpSearchBottom.Text = "Search";
            // 
            // lblFID
            // 
            this.lblFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFID.Location = new System.Drawing.Point(99, 541);
            this.lblFID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(170, 52);
            this.lblFID.TabIndex = 17;
            this.lblFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(160, 48);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(145, 39);
            this.cboStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: ";
            // 
            // chkCasualty
            // 
            this.chkCasualty.AutoSize = true;
            this.chkCasualty.Location = new System.Drawing.Point(384, 57);
            this.chkCasualty.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkCasualty.Name = "chkCasualty";
            this.chkCasualty.Size = new System.Drawing.Size(164, 36);
            this.chkCasualty.TabIndex = 3;
            this.chkCasualty.Text = "Casualty";
            this.chkCasualty.UseVisualStyleBackColor = true;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(29, 548);
            this.lbltext.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(74, 32);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "FID: ";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(16, 129);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.Size = new System.Drawing.Size(701, 358);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // aliasedManitobaBindingSource
            // 
            this.aliasedManitobaBindingSource.DataMember = "AliasedManitoba";
            this.aliasedManitobaBindingSource.DataSource = this.dbIndigenousPlaceNamesDataSet1;
            // 
            // dbIndigenousPlaceNamesDataSet1
            // 
            this.dbIndigenousPlaceNamesDataSet1.DataSetName = "dbIndigenousPlaceNamesDataSet1";
            this.dbIndigenousPlaceNamesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manitoba_MapperTableAdapter
            // 
            this.manitoba_MapperTableAdapter.ClearBeforeFill = true;
            // 
            // aliasedManitobaTableAdapter
            // 
            this.aliasedManitobaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1681, 1167);
            this.Controls.Add(this.grpNameList);
            this.Controls.Add(this.grpSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Indigenous Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpNameList.ResumeLayout(false);
            this.grpGroupName.ResumeLayout(false);
            this.grpGroupName.PerformLayout();
            this.grpSearchBottom.ResumeLayout(false);
            this.grpSearchBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasedManitobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbIndigenousPlaceNamesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewPlace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radStatus;
        private System.Windows.Forms.RadioButton radFID;
        private System.Windows.Forms.RadioButton radLocation;
        private System.Windows.Forms.RadioButton radMS250;
        private System.Windows.Forms.RadioButton radFeature;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.GroupBox grpNameList;
        private System.Windows.Forms.GroupBox grpGroupName;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl250;
        private System.Windows.Forms.Label lblLongitudeSecond;
        private System.Windows.Forms.Label lblLongitudeMinute;
        private System.Windows.Forms.Label lblLongitudeDegree;
        private System.Windows.Forms.Label lblLatitudeSecond;
        private System.Windows.Forms.Label lblLatitudeMinute;
        private System.Windows.Forms.Label lblLatitudeDegree;
        private System.Windows.Forms.Button btnNameHistory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFeature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSearchBottom;
        private System.Windows.Forms.Label lblFID;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCasualty;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.DataGridView dgvSearch;
        private dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter manitoba_MapperTableAdapter;
        private dbIndigenousPlaceNamesDataSet1 dbIndigenousPlaceNamesDataSet1;
        private System.Windows.Forms.BindingSource aliasedManitobaBindingSource;
        private dbIndigenousPlaceNamesDataSet1TableAdapters.AliasedManitobaTableAdapter aliasedManitobaTableAdapter;
        private System.Windows.Forms.RadioButton radMS50;
    }
}

