﻿    namespace IndustryProject
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewPlace = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radStatus = new System.Windows.Forms.RadioButton();
            this.radFID = new System.Windows.Forms.RadioButton();
            this.radLocation = new System.Windows.Forms.RadioButton();
            this.radMS = new System.Windows.Forms.RadioButton();
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
            this.dbIndigenousPlaceNamesDataSet = new IndustryProject.dbIndigenousPlaceNamesDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new IndustryProject.TestDataSet();
            this.cASUALTIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cASUALTIESTableAdapter = new IndustryProject.TestDataSetTableAdapters.CASUALTIESTableAdapter();
            this.manitoba_MapperTableAdapter = new IndustryProject.dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter();
            this.aliasedManitobaTableAdapter = new IndustryProject.dbIndigenousPlaceNamesDataSet1TableAdapters.AliasedManitobaTableAdapter();
            this.grpSearch.SuspendLayout();
            this.grpNameList.SuspendLayout();
            this.grpGroupName.SuspendLayout();
            this.grpSearchBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasedManitobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbIndigenousPlaceNamesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbIndigenousPlaceNamesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cASUALTIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnNewPlace);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.radStatus);
            this.grpSearch.Controls.Add(this.radFID);
            this.grpSearch.Controls.Add(this.radLocation);
            this.grpSearch.Controls.Add(this.radMS);
            this.grpSearch.Controls.Add(this.radFeature);
            this.grpSearch.Controls.Add(this.radName);
            this.grpSearch.Location = new System.Drawing.Point(29, 22);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(539, 145);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Box";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(106, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewPlace
            // 
            this.btnNewPlace.Location = new System.Drawing.Point(380, 103);
            this.btnNewPlace.Name = "btnNewPlace";
            this.btnNewPlace.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlace.TabIndex = 9;
            this.btnNewPlace.Text = "New Place";
            this.btnNewPlace.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(79, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(407, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search: ";
            // 
            // radStatus
            // 
            this.radStatus.AutoSize = true;
            this.radStatus.Location = new System.Drawing.Point(431, 28);
            this.radStatus.Name = "radStatus";
            this.radStatus.Size = new System.Drawing.Size(55, 17);
            this.radStatus.TabIndex = 5;
            this.radStatus.TabStop = true;
            this.radStatus.Text = "Status";
            this.radStatus.UseVisualStyleBackColor = true;
            // 
            // radFID
            // 
            this.radFID.AutoSize = true;
            this.radFID.Location = new System.Drawing.Point(364, 28);
            this.radFID.Name = "radFID";
            this.radFID.Size = new System.Drawing.Size(42, 17);
            this.radFID.TabIndex = 4;
            this.radFID.TabStop = true;
            this.radFID.Text = "FID";
            this.radFID.UseVisualStyleBackColor = true;
            // 
            // radLocation
            // 
            this.radLocation.AutoSize = true;
            this.radLocation.Location = new System.Drawing.Point(271, 28);
            this.radLocation.Name = "radLocation";
            this.radLocation.Size = new System.Drawing.Size(66, 17);
            this.radLocation.TabIndex = 3;
            this.radLocation.TabStop = true;
            this.radLocation.Text = "Location";
            this.radLocation.UseVisualStyleBackColor = true;
            // 
            // radMS
            // 
            this.radMS.AutoSize = true;
            this.radMS.Location = new System.Drawing.Point(189, 28);
            this.radMS.Name = "radMS";
            this.radMS.Size = new System.Drawing.Size(54, 17);
            this.radMS.TabIndex = 2;
            this.radMS.TabStop = true;
            this.radMS.Text = "M.S #";
            this.radMS.UseVisualStyleBackColor = true;
            // 
            // radFeature
            // 
            this.radFeature.AutoSize = true;
            this.radFeature.Location = new System.Drawing.Point(106, 28);
            this.radFeature.Name = "radFeature";
            this.radFeature.Size = new System.Drawing.Size(61, 17);
            this.radFeature.TabIndex = 1;
            this.radFeature.TabStop = true;
            this.radFeature.Text = "Feature";
            this.radFeature.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(29, 28);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(53, 17);
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
            this.grpNameList.Location = new System.Drawing.Point(29, 197);
            this.grpNameList.Name = "grpNameList";
            this.grpNameList.Size = new System.Drawing.Size(539, 293);
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
            this.grpGroupName.Location = new System.Drawing.Point(249, 25);
            this.grpGroupName.Name = "grpGroupName";
            this.grpGroupName.Size = new System.Drawing.Size(284, 268);
            this.grpGroupName.TabIndex = 1;
            this.grpGroupName.TabStop = false;
            this.grpGroupName.Text = "Group Name";
            // 
            // lbl50
            // 
            this.lbl50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl50.Location = new System.Drawing.Point(219, 160);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(30, 22);
            this.lbl50.TabIndex = 26;
            // 
            // lbl250
            // 
            this.lbl250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl250.Location = new System.Drawing.Point(141, 160);
            this.lbl250.Name = "lbl250";
            this.lbl250.Size = new System.Drawing.Size(30, 22);
            this.lbl250.TabIndex = 25;
            // 
            // lblLongitudeSecond
            // 
            this.lblLongitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeSecond.Location = new System.Drawing.Point(159, 108);
            this.lblLongitudeSecond.Name = "lblLongitudeSecond";
            this.lblLongitudeSecond.Size = new System.Drawing.Size(30, 22);
            this.lblLongitudeSecond.TabIndex = 23;
            // 
            // lblLongitudeMinute
            // 
            this.lblLongitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeMinute.Location = new System.Drawing.Point(123, 108);
            this.lblLongitudeMinute.Name = "lblLongitudeMinute";
            this.lblLongitudeMinute.Size = new System.Drawing.Size(30, 22);
            this.lblLongitudeMinute.TabIndex = 22;
            // 
            // lblLongitudeDegree
            // 
            this.lblLongitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeDegree.Location = new System.Drawing.Point(87, 108);
            this.lblLongitudeDegree.Name = "lblLongitudeDegree";
            this.lblLongitudeDegree.Size = new System.Drawing.Size(30, 22);
            this.lblLongitudeDegree.TabIndex = 21;
            // 
            // lblLatitudeSecond
            // 
            this.lblLatitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeSecond.Location = new System.Drawing.Point(159, 68);
            this.lblLatitudeSecond.Name = "lblLatitudeSecond";
            this.lblLatitudeSecond.Size = new System.Drawing.Size(30, 22);
            this.lblLatitudeSecond.TabIndex = 20;
            // 
            // lblLatitudeMinute
            // 
            this.lblLatitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeMinute.Location = new System.Drawing.Point(123, 68);
            this.lblLatitudeMinute.Name = "lblLatitudeMinute";
            this.lblLatitudeMinute.Size = new System.Drawing.Size(30, 22);
            this.lblLatitudeMinute.TabIndex = 19;
            // 
            // lblLatitudeDegree
            // 
            this.lblLatitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeDegree.Location = new System.Drawing.Point(87, 67);
            this.lblLatitudeDegree.Name = "lblLatitudeDegree";
            this.lblLatitudeDegree.Size = new System.Drawing.Size(30, 22);
            this.lblLatitudeDegree.TabIndex = 18;
            // 
            // btnNameHistory
            // 
            this.btnNameHistory.Location = new System.Drawing.Point(33, 233);
            this.btnNameHistory.Name = "btnNameHistory";
            this.btnNameHistory.Size = new System.Drawing.Size(116, 23);
            this.btnNameHistory.TabIndex = 16;
            this.btnNameHistory.Text = "Name History";
            this.btnNameHistory.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(182, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "50: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(107, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "250: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Map Sheets: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Longitude: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latitude: ";
            // 
            // cboFeature
            // 
            this.cboFeature.FormattingEnabled = true;
            this.cboFeature.Location = new System.Drawing.Point(82, 20);
            this.cboFeature.Name = "cboFeature";
            this.cboFeature.Size = new System.Drawing.Size(121, 21);
            this.cboFeature.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
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
            this.grpSearchBottom.Location = new System.Drawing.Point(15, 19);
            this.grpSearchBottom.Name = "grpSearchBottom";
            this.grpSearchBottom.Size = new System.Drawing.Size(228, 268);
            this.grpSearchBottom.TabIndex = 0;
            this.grpSearchBottom.TabStop = false;
            this.grpSearchBottom.Text = "Search";
            // 
            // lblFID
            // 
            this.lblFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFID.Location = new System.Drawing.Point(37, 227);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(49, 23);
            this.lblFID.TabIndex = 17;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(60, 20);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(57, 21);
            this.cboStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: ";
            // 
            // chkCasualty
            // 
            this.chkCasualty.AutoSize = true;
            this.chkCasualty.Location = new System.Drawing.Point(144, 24);
            this.chkCasualty.Name = "chkCasualty";
            this.chkCasualty.Size = new System.Drawing.Size(66, 17);
            this.chkCasualty.TabIndex = 3;
            this.chkCasualty.Text = "Casualty";
            this.chkCasualty.UseVisualStyleBackColor = true;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(11, 230);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(30, 13);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "FID: ";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(6, 54);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(204, 150);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentClick);
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
            // dbIndigenousPlaceNamesDataSet
            // 
            this.dbIndigenousPlaceNamesDataSet.DataSetName = "dbIndigenousPlaceNamesDataSet";
            this.dbIndigenousPlaceNamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cASUALTIESBindingSource
            // 
            this.cASUALTIESBindingSource.DataMember = "CASUALTIES";
            this.cASUALTIESBindingSource.DataSource = this.testDataSet;
            // 
            // cASUALTIESTableAdapter
            // 
            this.cASUALTIESTableAdapter.ClearBeforeFill = true;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 492);
            this.Controls.Add(this.grpNameList);
            this.Controls.Add(this.grpSearch);
            this.Name = "Form1";
            this.Text = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.dbIndigenousPlaceNamesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cASUALTIESBindingSource)).EndInit();
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
        private System.Windows.Forms.RadioButton radMS;
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
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource cASUALTIESBindingSource;
        private TestDataSetTableAdapters.CASUALTIESTableAdapter cASUALTIESTableAdapter;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private dbIndigenousPlaceNamesDataSet dbIndigenousPlaceNamesDataSet;
        private dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter manitoba_MapperTableAdapter;
        private dbIndigenousPlaceNamesDataSet1 dbIndigenousPlaceNamesDataSet1;
        private System.Windows.Forms.BindingSource aliasedManitobaBindingSource;
        private dbIndigenousPlaceNamesDataSet1TableAdapters.AliasedManitobaTableAdapter aliasedManitobaTableAdapter;
    }
}

