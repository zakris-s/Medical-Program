namespace ITS245_FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Confirm_Button = new System.Windows.Forms.Button();
            this.Home_Patient_Database = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptPreviousLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeStateProvinceRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptHomePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptHomeFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnicAssociationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martialStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalMRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofExpireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPrimaryHCPldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalStaffHCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStaffHCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessFaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberRelationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptMiddleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nPPDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTS245FinalDataSet = new ITS245_FinalProject.ITS245FinalDataSet();
            this.patientTableTableAdapter = new ITS245_FinalProject.ITS245FinalDataSetTableAdapters.patientTableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.Main_Display = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Home_Patient_Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a patient NAME from the list below";
            // 
            // Home_Confirm_Button
            // 
            this.Home_Confirm_Button.Location = new System.Drawing.Point(399, 365);
            this.Home_Confirm_Button.Name = "Home_Confirm_Button";
            this.Home_Confirm_Button.Size = new System.Drawing.Size(139, 23);
            this.Home_Confirm_Button.TabIndex = 1;
            this.Home_Confirm_Button.Text = "Confirm Selected Patient";
            this.Home_Confirm_Button.UseVisualStyleBackColor = true;
            this.Home_Confirm_Button.Click += new System.EventHandler(this.Home_Confirm_Button_Click);
            // 
            // Home_Patient_Database
            // 
            this.Home_Patient_Database.AllowUserToOrderColumns = true;
            this.Home_Patient_Database.AutoGenerateColumns = false;
            this.Home_Patient_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Home_Patient_Database.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.oldIDDataGridViewTextBoxColumn,
            this.ptLastNameDataGridViewTextBoxColumn,
            this.ptPreviousLastNameDataGridViewTextBoxColumn,
            this.ptFirstNameDataGridViewTextBoxColumn,
            this.homeAddress1DataGridViewTextBoxColumn,
            this.homeAddress2DataGridViewTextBoxColumn,
            this.homeCityDataGridViewTextBoxColumn,
            this.homeStateProvinceRegionDataGridViewTextBoxColumn,
            this.homeZipDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.ptHomePhoneDataGridViewTextBoxColumn,
            this.emergencyPhoneNumberDataGridViewTextBoxColumn,
            this.ptHomeFaxDataGridViewTextBoxColumn,
            this.pagerDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.ptSSNDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ethnicAssociationDataGridViewTextBoxColumn,
            this.religionDataGridViewTextBoxColumn,
            this.martialStatusDataGridViewTextBoxColumn,
            this.employmentStatusDataGridViewTextBoxColumn,
            this.hospitalMRDataGridViewTextBoxColumn,
            this.dateofExpireDataGridViewTextBoxColumn,
            this.referralDataGridViewTextBoxColumn,
            this.currentPrimaryHCPldDataGridViewTextBoxColumn,
            this.specialist1DataGridViewTextBoxColumn,
            this.specialist2DataGridViewTextBoxColumn,
            this.specialist3DataGridViewTextBoxColumn,
            this.specialist4DataGridViewTextBoxColumn,
            this.originalStaffHCPDataGridViewTextBoxColumn,
            this.currentStaffHCPDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.dateEnteredDataGridViewTextBoxColumn,
            this.businessPhoneDataGridViewTextBoxColumn,
            this.businessFaxDataGridViewTextBoxColumn,
            this.subscriberRelationshipDataGridViewTextBoxColumn,
            this.employerIDDataGridViewTextBoxColumn,
            this.nextOfKinIDDataGridViewTextBoxColumn,
            this.ptMiddleInitialDataGridViewTextBoxColumn,
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn,
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn,
            this.nPPDateDataGridViewTextBoxColumn,
            this.suffixDataGridViewTextBoxColumn});
            this.Home_Patient_Database.DataSource = this.patientTableBindingSource;
            this.Home_Patient_Database.Location = new System.Drawing.Point(15, 142);
            this.Home_Patient_Database.MultiSelect = false;
            this.Home_Patient_Database.Name = "Home_Patient_Database";
            this.Home_Patient_Database.ReadOnly = true;
            this.Home_Patient_Database.RowHeadersWidth = 51;
            this.Home_Patient_Database.Size = new System.Drawing.Size(891, 150);
            this.Home_Patient_Database.TabIndex = 0;
            this.Home_Patient_Database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Home_Patient_Database_CellContentClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oldIDDataGridViewTextBoxColumn
            // 
            this.oldIDDataGridViewTextBoxColumn.DataPropertyName = "OldID";
            this.oldIDDataGridViewTextBoxColumn.HeaderText = "OldID";
            this.oldIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oldIDDataGridViewTextBoxColumn.Name = "oldIDDataGridViewTextBoxColumn";
            this.oldIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oldIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptLastNameDataGridViewTextBoxColumn
            // 
            this.ptLastNameDataGridViewTextBoxColumn.DataPropertyName = "PtLastName";
            this.ptLastNameDataGridViewTextBoxColumn.HeaderText = "PtLastName";
            this.ptLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptLastNameDataGridViewTextBoxColumn.Name = "ptLastNameDataGridViewTextBoxColumn";
            this.ptLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptPreviousLastNameDataGridViewTextBoxColumn
            // 
            this.ptPreviousLastNameDataGridViewTextBoxColumn.DataPropertyName = "PtPreviousLastName";
            this.ptPreviousLastNameDataGridViewTextBoxColumn.HeaderText = "PtPreviousLastName";
            this.ptPreviousLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptPreviousLastNameDataGridViewTextBoxColumn.Name = "ptPreviousLastNameDataGridViewTextBoxColumn";
            this.ptPreviousLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptPreviousLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptFirstNameDataGridViewTextBoxColumn
            // 
            this.ptFirstNameDataGridViewTextBoxColumn.DataPropertyName = "PtFirstName";
            this.ptFirstNameDataGridViewTextBoxColumn.HeaderText = "PtFirstName";
            this.ptFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptFirstNameDataGridViewTextBoxColumn.Name = "ptFirstNameDataGridViewTextBoxColumn";
            this.ptFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // homeAddress1DataGridViewTextBoxColumn
            // 
            this.homeAddress1DataGridViewTextBoxColumn.DataPropertyName = "HomeAddress1";
            this.homeAddress1DataGridViewTextBoxColumn.HeaderText = "HomeAddress1";
            this.homeAddress1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeAddress1DataGridViewTextBoxColumn.Name = "homeAddress1DataGridViewTextBoxColumn";
            this.homeAddress1DataGridViewTextBoxColumn.ReadOnly = true;
            this.homeAddress1DataGridViewTextBoxColumn.Width = 125;
            // 
            // homeAddress2DataGridViewTextBoxColumn
            // 
            this.homeAddress2DataGridViewTextBoxColumn.DataPropertyName = "HomeAddress2";
            this.homeAddress2DataGridViewTextBoxColumn.HeaderText = "HomeAddress2";
            this.homeAddress2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeAddress2DataGridViewTextBoxColumn.Name = "homeAddress2DataGridViewTextBoxColumn";
            this.homeAddress2DataGridViewTextBoxColumn.ReadOnly = true;
            this.homeAddress2DataGridViewTextBoxColumn.Width = 125;
            // 
            // homeCityDataGridViewTextBoxColumn
            // 
            this.homeCityDataGridViewTextBoxColumn.DataPropertyName = "HomeCity";
            this.homeCityDataGridViewTextBoxColumn.HeaderText = "HomeCity";
            this.homeCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeCityDataGridViewTextBoxColumn.Name = "homeCityDataGridViewTextBoxColumn";
            this.homeCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // homeStateProvinceRegionDataGridViewTextBoxColumn
            // 
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.DataPropertyName = "HomeState/Province/Region";
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.HeaderText = "HomeState/Province/Region";
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.Name = "homeStateProvinceRegionDataGridViewTextBoxColumn";
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeStateProvinceRegionDataGridViewTextBoxColumn.Width = 125;
            // 
            // homeZipDataGridViewTextBoxColumn
            // 
            this.homeZipDataGridViewTextBoxColumn.DataPropertyName = "HomeZip";
            this.homeZipDataGridViewTextBoxColumn.HeaderText = "HomeZip";
            this.homeZipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeZipDataGridViewTextBoxColumn.Name = "homeZipDataGridViewTextBoxColumn";
            this.homeZipDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeZipDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.citizenshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptHomePhoneDataGridViewTextBoxColumn
            // 
            this.ptHomePhoneDataGridViewTextBoxColumn.DataPropertyName = "PtHomePhone";
            this.ptHomePhoneDataGridViewTextBoxColumn.HeaderText = "PtHomePhone";
            this.ptHomePhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptHomePhoneDataGridViewTextBoxColumn.Name = "ptHomePhoneDataGridViewTextBoxColumn";
            this.ptHomePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptHomePhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emergencyPhoneNumberDataGridViewTextBoxColumn
            // 
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "EmergencyPhoneNumber";
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.HeaderText = "EmergencyPhoneNumber";
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.Name = "emergencyPhoneNumberDataGridViewTextBoxColumn";
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.emergencyPhoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptHomeFaxDataGridViewTextBoxColumn
            // 
            this.ptHomeFaxDataGridViewTextBoxColumn.DataPropertyName = "PtHomeFax";
            this.ptHomeFaxDataGridViewTextBoxColumn.HeaderText = "PtHomeFax";
            this.ptHomeFaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptHomeFaxDataGridViewTextBoxColumn.Name = "ptHomeFaxDataGridViewTextBoxColumn";
            this.ptHomeFaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptHomeFaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagerDataGridViewTextBoxColumn
            // 
            this.pagerDataGridViewTextBoxColumn.DataPropertyName = "Pager";
            this.pagerDataGridViewTextBoxColumn.HeaderText = "Pager";
            this.pagerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagerDataGridViewTextBoxColumn.Name = "pagerDataGridViewTextBoxColumn";
            this.pagerDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagerDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptSSNDataGridViewTextBoxColumn
            // 
            this.ptSSNDataGridViewTextBoxColumn.DataPropertyName = "PtSSN#";
            this.ptSSNDataGridViewTextBoxColumn.HeaderText = "PtSSN#";
            this.ptSSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptSSNDataGridViewTextBoxColumn.Name = "ptSSNDataGridViewTextBoxColumn";
            this.ptSSNDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptSSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // ethnicAssociationDataGridViewTextBoxColumn
            // 
            this.ethnicAssociationDataGridViewTextBoxColumn.DataPropertyName = "EthnicAssociation";
            this.ethnicAssociationDataGridViewTextBoxColumn.HeaderText = "EthnicAssociation";
            this.ethnicAssociationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ethnicAssociationDataGridViewTextBoxColumn.Name = "ethnicAssociationDataGridViewTextBoxColumn";
            this.ethnicAssociationDataGridViewTextBoxColumn.ReadOnly = true;
            this.ethnicAssociationDataGridViewTextBoxColumn.Width = 125;
            // 
            // religionDataGridViewTextBoxColumn
            // 
            this.religionDataGridViewTextBoxColumn.DataPropertyName = "Religion";
            this.religionDataGridViewTextBoxColumn.HeaderText = "Religion";
            this.religionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.religionDataGridViewTextBoxColumn.Name = "religionDataGridViewTextBoxColumn";
            this.religionDataGridViewTextBoxColumn.ReadOnly = true;
            this.religionDataGridViewTextBoxColumn.Width = 125;
            // 
            // martialStatusDataGridViewTextBoxColumn
            // 
            this.martialStatusDataGridViewTextBoxColumn.DataPropertyName = "MartialStatus";
            this.martialStatusDataGridViewTextBoxColumn.HeaderText = "MartialStatus";
            this.martialStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.martialStatusDataGridViewTextBoxColumn.Name = "martialStatusDataGridViewTextBoxColumn";
            this.martialStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.martialStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // employmentStatusDataGridViewTextBoxColumn
            // 
            this.employmentStatusDataGridViewTextBoxColumn.DataPropertyName = "EmploymentStatus";
            this.employmentStatusDataGridViewTextBoxColumn.HeaderText = "EmploymentStatus";
            this.employmentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employmentStatusDataGridViewTextBoxColumn.Name = "employmentStatusDataGridViewTextBoxColumn";
            this.employmentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.employmentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // hospitalMRDataGridViewTextBoxColumn
            // 
            this.hospitalMRDataGridViewTextBoxColumn.DataPropertyName = "HospitalMR#";
            this.hospitalMRDataGridViewTextBoxColumn.HeaderText = "HospitalMR#";
            this.hospitalMRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hospitalMRDataGridViewTextBoxColumn.Name = "hospitalMRDataGridViewTextBoxColumn";
            this.hospitalMRDataGridViewTextBoxColumn.ReadOnly = true;
            this.hospitalMRDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofExpireDataGridViewTextBoxColumn
            // 
            this.dateofExpireDataGridViewTextBoxColumn.DataPropertyName = "DateofExpire";
            this.dateofExpireDataGridViewTextBoxColumn.HeaderText = "DateofExpire";
            this.dateofExpireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofExpireDataGridViewTextBoxColumn.Name = "dateofExpireDataGridViewTextBoxColumn";
            this.dateofExpireDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofExpireDataGridViewTextBoxColumn.Width = 125;
            // 
            // referralDataGridViewTextBoxColumn
            // 
            this.referralDataGridViewTextBoxColumn.DataPropertyName = "Referral";
            this.referralDataGridViewTextBoxColumn.HeaderText = "Referral";
            this.referralDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.referralDataGridViewTextBoxColumn.Name = "referralDataGridViewTextBoxColumn";
            this.referralDataGridViewTextBoxColumn.ReadOnly = true;
            this.referralDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentPrimaryHCPldDataGridViewTextBoxColumn
            // 
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.DataPropertyName = "CurrentPrimaryHCPld";
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.HeaderText = "CurrentPrimaryHCPld";
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.Name = "currentPrimaryHCPldDataGridViewTextBoxColumn";
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentPrimaryHCPldDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialist1DataGridViewTextBoxColumn
            // 
            this.specialist1DataGridViewTextBoxColumn.DataPropertyName = "Specialist1";
            this.specialist1DataGridViewTextBoxColumn.HeaderText = "Specialist1";
            this.specialist1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialist1DataGridViewTextBoxColumn.Name = "specialist1DataGridViewTextBoxColumn";
            this.specialist1DataGridViewTextBoxColumn.ReadOnly = true;
            this.specialist1DataGridViewTextBoxColumn.Width = 125;
            // 
            // specialist2DataGridViewTextBoxColumn
            // 
            this.specialist2DataGridViewTextBoxColumn.DataPropertyName = "Specialist2";
            this.specialist2DataGridViewTextBoxColumn.HeaderText = "Specialist2";
            this.specialist2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialist2DataGridViewTextBoxColumn.Name = "specialist2DataGridViewTextBoxColumn";
            this.specialist2DataGridViewTextBoxColumn.ReadOnly = true;
            this.specialist2DataGridViewTextBoxColumn.Width = 125;
            // 
            // specialist3DataGridViewTextBoxColumn
            // 
            this.specialist3DataGridViewTextBoxColumn.DataPropertyName = "Specialist3";
            this.specialist3DataGridViewTextBoxColumn.HeaderText = "Specialist3";
            this.specialist3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialist3DataGridViewTextBoxColumn.Name = "specialist3DataGridViewTextBoxColumn";
            this.specialist3DataGridViewTextBoxColumn.ReadOnly = true;
            this.specialist3DataGridViewTextBoxColumn.Width = 125;
            // 
            // specialist4DataGridViewTextBoxColumn
            // 
            this.specialist4DataGridViewTextBoxColumn.DataPropertyName = "Specialist4";
            this.specialist4DataGridViewTextBoxColumn.HeaderText = "Specialist4";
            this.specialist4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialist4DataGridViewTextBoxColumn.Name = "specialist4DataGridViewTextBoxColumn";
            this.specialist4DataGridViewTextBoxColumn.ReadOnly = true;
            this.specialist4DataGridViewTextBoxColumn.Width = 125;
            // 
            // originalStaffHCPDataGridViewTextBoxColumn
            // 
            this.originalStaffHCPDataGridViewTextBoxColumn.DataPropertyName = "OriginalStaffHCP";
            this.originalStaffHCPDataGridViewTextBoxColumn.HeaderText = "OriginalStaffHCP";
            this.originalStaffHCPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.originalStaffHCPDataGridViewTextBoxColumn.Name = "originalStaffHCPDataGridViewTextBoxColumn";
            this.originalStaffHCPDataGridViewTextBoxColumn.ReadOnly = true;
            this.originalStaffHCPDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentStaffHCPDataGridViewTextBoxColumn
            // 
            this.currentStaffHCPDataGridViewTextBoxColumn.DataPropertyName = "CurrentStaffHCP";
            this.currentStaffHCPDataGridViewTextBoxColumn.HeaderText = "CurrentStaffHCP";
            this.currentStaffHCPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentStaffHCPDataGridViewTextBoxColumn.Name = "currentStaffHCPDataGridViewTextBoxColumn";
            this.currentStaffHCPDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentStaffHCPDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateEnteredDataGridViewTextBoxColumn
            // 
            this.dateEnteredDataGridViewTextBoxColumn.DataPropertyName = "DateEntered";
            this.dateEnteredDataGridViewTextBoxColumn.HeaderText = "DateEntered";
            this.dateEnteredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateEnteredDataGridViewTextBoxColumn.Name = "dateEnteredDataGridViewTextBoxColumn";
            this.dateEnteredDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEnteredDataGridViewTextBoxColumn.Width = 125;
            // 
            // businessPhoneDataGridViewTextBoxColumn
            // 
            this.businessPhoneDataGridViewTextBoxColumn.DataPropertyName = "BusinessPhone";
            this.businessPhoneDataGridViewTextBoxColumn.HeaderText = "BusinessPhone";
            this.businessPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.businessPhoneDataGridViewTextBoxColumn.Name = "businessPhoneDataGridViewTextBoxColumn";
            this.businessPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // businessFaxDataGridViewTextBoxColumn
            // 
            this.businessFaxDataGridViewTextBoxColumn.DataPropertyName = "BusinessFax";
            this.businessFaxDataGridViewTextBoxColumn.HeaderText = "BusinessFax";
            this.businessFaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.businessFaxDataGridViewTextBoxColumn.Name = "businessFaxDataGridViewTextBoxColumn";
            this.businessFaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessFaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // subscriberRelationshipDataGridViewTextBoxColumn
            // 
            this.subscriberRelationshipDataGridViewTextBoxColumn.DataPropertyName = "SubscriberRelationship";
            this.subscriberRelationshipDataGridViewTextBoxColumn.HeaderText = "SubscriberRelationship";
            this.subscriberRelationshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subscriberRelationshipDataGridViewTextBoxColumn.Name = "subscriberRelationshipDataGridViewTextBoxColumn";
            this.subscriberRelationshipDataGridViewTextBoxColumn.ReadOnly = true;
            this.subscriberRelationshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // employerIDDataGridViewTextBoxColumn
            // 
            this.employerIDDataGridViewTextBoxColumn.DataPropertyName = "EmployerID";
            this.employerIDDataGridViewTextBoxColumn.HeaderText = "EmployerID";
            this.employerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employerIDDataGridViewTextBoxColumn.Name = "employerIDDataGridViewTextBoxColumn";
            this.employerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nextOfKinIDDataGridViewTextBoxColumn
            // 
            this.nextOfKinIDDataGridViewTextBoxColumn.DataPropertyName = "NextOfKinID";
            this.nextOfKinIDDataGridViewTextBoxColumn.HeaderText = "NextOfKinID";
            this.nextOfKinIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nextOfKinIDDataGridViewTextBoxColumn.Name = "nextOfKinIDDataGridViewTextBoxColumn";
            this.nextOfKinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextOfKinIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ptMiddleInitialDataGridViewTextBoxColumn
            // 
            this.ptMiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "PtMiddleInitial";
            this.ptMiddleInitialDataGridViewTextBoxColumn.HeaderText = "PtMiddleInitial";
            this.ptMiddleInitialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptMiddleInitialDataGridViewTextBoxColumn.Name = "ptMiddleInitialDataGridViewTextBoxColumn";
            this.ptMiddleInitialDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptMiddleInitialDataGridViewTextBoxColumn.Width = 125;
            // 
            // nextOfKinRelationshipToPatientDataGridViewTextBoxColumn
            // 
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.DataPropertyName = "NextOfKinRelationshipToPatient";
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.HeaderText = "NextOfKinRelationshipToPatient";
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.Name = "nextOfKinRelationshipToPatientDataGridViewTextBoxColumn";
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextOfKinRelationshipToPatientDataGridViewTextBoxColumn.Width = 125;
            // 
            // noticeOfPracticePrivacyDataGridViewCheckBoxColumn
            // 
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.DataPropertyName = "NoticeOfPracticePrivacy";
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.HeaderText = "NoticeOfPracticePrivacy";
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.Name = "noticeOfPracticePrivacyDataGridViewCheckBoxColumn";
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.noticeOfPracticePrivacyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // nPPDateDataGridViewTextBoxColumn
            // 
            this.nPPDateDataGridViewTextBoxColumn.DataPropertyName = "NPPDate";
            this.nPPDateDataGridViewTextBoxColumn.HeaderText = "NPPDate";
            this.nPPDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nPPDateDataGridViewTextBoxColumn.Name = "nPPDateDataGridViewTextBoxColumn";
            this.nPPDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.nPPDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            this.suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            this.suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            this.suffixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            this.suffixDataGridViewTextBoxColumn.ReadOnly = true;
            this.suffixDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientTableBindingSource
            // 
            this.patientTableBindingSource.DataMember = "patientTable";
            this.patientTableBindingSource.DataSource = this.iTS245FinalDataSet;
            // 
            // iTS245FinalDataSet
            // 
            this.iTS245FinalDataSet.DataSetName = "ITS245FinalDataSet";
            this.iTS245FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableTableAdapter
            // 
            this.patientTableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Patient: ";
            // 
            // Main_Display
            // 
            this.Main_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Display.ForeColor = System.Drawing.Color.Red;
            this.Main_Display.Location = new System.Drawing.Point(107, 45);
            this.Main_Display.MaximumSize = new System.Drawing.Size(500, 100);
            this.Main_Display.Name = "Main_Display";
            this.Main_Display.Size = new System.Drawing.Size(190, 38);
            this.Main_Display.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search By LASTNAME, PHONE, or ID:";
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(533, 45);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(166, 20);
            this.Search_Box.TabIndex = 6;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(719, 45);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 7;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Main_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home_Patient_Database);
            this.Controls.Add(this.Home_Confirm_Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Home_Patient_Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home_Confirm_Button;
        private ITS245FinalDataSet iTS245FinalDataSet;
        private System.Windows.Forms.BindingSource patientTableBindingSource;
        private ITS245FinalDataSetTableAdapters.patientTableTableAdapter patientTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptPreviousLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeStateProvinceRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptHomePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptHomeFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ethnicAssociationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn martialStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalMRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofExpireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPrimaryHCPldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalStaffHCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStaffHCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessFaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberRelationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptMiddleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOfKinRelationshipToPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noticeOfPracticePrivacyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPPDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView Home_Patient_Database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Main_Display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Button SearchBTN;
    }
}

