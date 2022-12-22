namespace ITS245_FinalProject
{
    partial class Patient_Allergy_Form
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
            this.Allergy_Modify_Button = new System.Windows.Forms.Button();
            this.Allergy_Save_Button = new System.Windows.Forms.Button();
            this.Allergy_Undo_Button = new System.Windows.Forms.Button();
            this.Allergy_Delete_Button = new System.Windows.Forms.Button();
            this.Allergy_Modify_Label = new System.Windows.Forms.Label();
            this.Allergy_Data_Dataset = new System.Windows.Forms.DataGridView();
            this.allergyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergyHRFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.allergyHistoryTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iTS245FinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTS245FinalDataSet = new ITS245_FinalProject.ITS245FinalDataSet();
            this.allergyHistoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Allergy_Label = new System.Windows.Forms.Label();
            this.Allergy_Add_Button = new System.Windows.Forms.Button();
            this.allergyHistoryTableTableAdapter = new ITS245_FinalProject.ITS245FinalDataSetTableAdapters.allergyHistoryTableTableAdapter();
            this.Patient_goBack_Button = new System.Windows.Forms.Button();
            this.Patient_GOTOImmune_Buttone = new System.Windows.Forms.Button();
            this.Patient_GOTOGeneral_Button = new System.Windows.Forms.Button();
            this.Patient_GOTOFamily_Button = new System.Windows.Forms.Button();
            this.Patient_GOTODemo_Button = new System.Windows.Forms.Button();
            this.Name_Display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Allergy_Data_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergyHistoryTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergyHistoryTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Allergy_Modify_Button
            // 
            this.Allergy_Modify_Button.Location = new System.Drawing.Point(49, 236);
            this.Allergy_Modify_Button.Name = "Allergy_Modify_Button";
            this.Allergy_Modify_Button.Size = new System.Drawing.Size(103, 25);
            this.Allergy_Modify_Button.TabIndex = 0;
            this.Allergy_Modify_Button.Text = "Modify";
            this.Allergy_Modify_Button.UseVisualStyleBackColor = true;
            this.Allergy_Modify_Button.Click += new System.EventHandler(this.Allergy_Modify_Button_Click);
            // 
            // Allergy_Save_Button
            // 
            this.Allergy_Save_Button.Enabled = false;
            this.Allergy_Save_Button.Location = new System.Drawing.Point(49, 315);
            this.Allergy_Save_Button.Name = "Allergy_Save_Button";
            this.Allergy_Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Allergy_Save_Button.TabIndex = 1;
            this.Allergy_Save_Button.Text = "Save";
            this.Allergy_Save_Button.UseVisualStyleBackColor = true;
            this.Allergy_Save_Button.Click += new System.EventHandler(this.Allergy_Save_Button_Click);
            // 
            // Allergy_Undo_Button
            // 
            this.Allergy_Undo_Button.Enabled = false;
            this.Allergy_Undo_Button.Location = new System.Drawing.Point(49, 359);
            this.Allergy_Undo_Button.Name = "Allergy_Undo_Button";
            this.Allergy_Undo_Button.Size = new System.Drawing.Size(75, 23);
            this.Allergy_Undo_Button.TabIndex = 2;
            this.Allergy_Undo_Button.Text = "Undo";
            this.Allergy_Undo_Button.UseVisualStyleBackColor = true;
            this.Allergy_Undo_Button.Click += new System.EventHandler(this.Allergy_Undo_Button_Click);
            // 
            // Allergy_Delete_Button
            // 
            this.Allergy_Delete_Button.Enabled = false;
            this.Allergy_Delete_Button.Location = new System.Drawing.Point(49, 400);
            this.Allergy_Delete_Button.Name = "Allergy_Delete_Button";
            this.Allergy_Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Allergy_Delete_Button.TabIndex = 3;
            this.Allergy_Delete_Button.Text = "Delete";
            this.Allergy_Delete_Button.UseVisualStyleBackColor = true;
            this.Allergy_Delete_Button.Click += new System.EventHandler(this.Allergy_Delete_Button_Click);
            // 
            // Allergy_Modify_Label
            // 
            this.Allergy_Modify_Label.AutoSize = true;
            this.Allergy_Modify_Label.Location = new System.Drawing.Point(49, 217);
            this.Allergy_Modify_Label.Name = "Allergy_Modify_Label";
            this.Allergy_Modify_Label.Size = new System.Drawing.Size(148, 13);
            this.Allergy_Modify_Label.TabIndex = 4;
            this.Allergy_Modify_Label.Text = "Click modify to make changes";
            // 
            // Allergy_Data_Dataset
            // 
            this.Allergy_Data_Dataset.AllowUserToAddRows = false;
            this.Allergy_Data_Dataset.AutoGenerateColumns = false;
            this.Allergy_Data_Dataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allergy_Data_Dataset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allergyIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.allergenDataGridViewTextBoxColumn,
            this.allergyStartDateDataGridViewTextBoxColumn,
            this.allergyEndDateDataGridViewTextBoxColumn,
            this.allergyDescriptionDataGridViewTextBoxColumn,
            this.allergyHRFDataGridViewCheckBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.Allergy_Data_Dataset.DataSource = this.allergyHistoryTableBindingSource1;
            this.Allergy_Data_Dataset.Location = new System.Drawing.Point(49, 64);
            this.Allergy_Data_Dataset.MultiSelect = false;
            this.Allergy_Data_Dataset.Name = "Allergy_Data_Dataset";
            this.Allergy_Data_Dataset.Size = new System.Drawing.Size(842, 150);
            this.Allergy_Data_Dataset.TabIndex = 5;
            this.Allergy_Data_Dataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allergy_Data_Dataset_CellContentClick);
            // 
            // allergyIDDataGridViewTextBoxColumn
            // 
            this.allergyIDDataGridViewTextBoxColumn.DataPropertyName = "AllergyID";
            this.allergyIDDataGridViewTextBoxColumn.HeaderText = "AllergyID";
            this.allergyIDDataGridViewTextBoxColumn.Name = "allergyIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // allergenDataGridViewTextBoxColumn
            // 
            this.allergenDataGridViewTextBoxColumn.DataPropertyName = "Allergen";
            this.allergenDataGridViewTextBoxColumn.HeaderText = "Allergen";
            this.allergenDataGridViewTextBoxColumn.Name = "allergenDataGridViewTextBoxColumn";
            // 
            // allergyStartDateDataGridViewTextBoxColumn
            // 
            this.allergyStartDateDataGridViewTextBoxColumn.DataPropertyName = "AllergyStartDate";
            this.allergyStartDateDataGridViewTextBoxColumn.HeaderText = "AllergyStartDate";
            this.allergyStartDateDataGridViewTextBoxColumn.Name = "allergyStartDateDataGridViewTextBoxColumn";
            // 
            // allergyEndDateDataGridViewTextBoxColumn
            // 
            this.allergyEndDateDataGridViewTextBoxColumn.DataPropertyName = "AllergyEndDate";
            this.allergyEndDateDataGridViewTextBoxColumn.HeaderText = "AllergyEndDate";
            this.allergyEndDateDataGridViewTextBoxColumn.Name = "allergyEndDateDataGridViewTextBoxColumn";
            // 
            // allergyDescriptionDataGridViewTextBoxColumn
            // 
            this.allergyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "AllergyDescription";
            this.allergyDescriptionDataGridViewTextBoxColumn.HeaderText = "AllergyDescription";
            this.allergyDescriptionDataGridViewTextBoxColumn.Name = "allergyDescriptionDataGridViewTextBoxColumn";
            // 
            // allergyHRFDataGridViewCheckBoxColumn
            // 
            this.allergyHRFDataGridViewCheckBoxColumn.DataPropertyName = "AllergyHRF";
            this.allergyHRFDataGridViewCheckBoxColumn.HeaderText = "AllergyHRF";
            this.allergyHRFDataGridViewCheckBoxColumn.Name = "allergyHRFDataGridViewCheckBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // allergyHistoryTableBindingSource1
            // 
            this.allergyHistoryTableBindingSource1.DataMember = "allergyHistoryTable";
            this.allergyHistoryTableBindingSource1.DataSource = this.iTS245FinalDataSetBindingSource;
            // 
            // iTS245FinalDataSetBindingSource
            // 
            this.iTS245FinalDataSetBindingSource.DataSource = this.iTS245FinalDataSet;
            this.iTS245FinalDataSetBindingSource.Position = 0;
            // 
            // iTS245FinalDataSet
            // 
            this.iTS245FinalDataSet.DataSetName = "ITS245FinalDataSet";
            this.iTS245FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allergyHistoryTableBindingSource
            // 
            this.allergyHistoryTableBindingSource.DataMember = "allergyHistoryTable";
            this.allergyHistoryTableBindingSource.DataSource = this.iTS245FinalDataSetBindingSource;
            // 
            // Allergy_Label
            // 
            this.Allergy_Label.AutoSize = true;
            this.Allergy_Label.Location = new System.Drawing.Point(49, 48);
            this.Allergy_Label.Name = "Allergy_Label";
            this.Allergy_Label.Size = new System.Drawing.Size(129, 13);
            this.Allergy_Label.TabIndex = 6;
            this.Allergy_Label.Text = "Patient Allergy Information";
            // 
            // Allergy_Add_Button
            // 
            this.Allergy_Add_Button.Enabled = false;
            this.Allergy_Add_Button.Location = new System.Drawing.Point(49, 276);
            this.Allergy_Add_Button.Name = "Allergy_Add_Button";
            this.Allergy_Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Allergy_Add_Button.TabIndex = 33;
            this.Allergy_Add_Button.Text = "Add";
            this.Allergy_Add_Button.UseVisualStyleBackColor = true;
            this.Allergy_Add_Button.Click += new System.EventHandler(this.Allergy_Add_Button_Click);
            // 
            // allergyHistoryTableTableAdapter
            // 
            this.allergyHistoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // Patient_goBack_Button
            // 
            this.Patient_goBack_Button.Location = new System.Drawing.Point(643, 400);
            this.Patient_goBack_Button.Name = "Patient_goBack_Button";
            this.Patient_goBack_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_goBack_Button.TabIndex = 38;
            this.Patient_goBack_Button.Text = "Go Back to Patient Select";
            this.Patient_goBack_Button.UseVisualStyleBackColor = true;
            this.Patient_goBack_Button.Click += new System.EventHandler(this.Patient_goBack_Button_Click);
            // 
            // Patient_GOTOImmune_Buttone
            // 
            this.Patient_GOTOImmune_Buttone.Location = new System.Drawing.Point(643, 359);
            this.Patient_GOTOImmune_Buttone.Name = "Patient_GOTOImmune_Buttone";
            this.Patient_GOTOImmune_Buttone.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOImmune_Buttone.TabIndex = 37;
            this.Patient_GOTOImmune_Buttone.Text = "Go to Immunization History";
            this.Patient_GOTOImmune_Buttone.UseVisualStyleBackColor = true;
            this.Patient_GOTOImmune_Buttone.Click += new System.EventHandler(this.Patient_GOTOImmune_Buttone_Click);
            // 
            // Patient_GOTOGeneral_Button
            // 
            this.Patient_GOTOGeneral_Button.Location = new System.Drawing.Point(643, 320);
            this.Patient_GOTOGeneral_Button.Name = "Patient_GOTOGeneral_Button";
            this.Patient_GOTOGeneral_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOGeneral_Button.TabIndex = 36;
            this.Patient_GOTOGeneral_Button.Text = "Go to General History";
            this.Patient_GOTOGeneral_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOGeneral_Button.Click += new System.EventHandler(this.Patient_GOTOGeneral_Button_Click);
            // 
            // Patient_GOTOFamily_Button
            // 
            this.Patient_GOTOFamily_Button.Location = new System.Drawing.Point(643, 282);
            this.Patient_GOTOFamily_Button.Name = "Patient_GOTOFamily_Button";
            this.Patient_GOTOFamily_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOFamily_Button.TabIndex = 35;
            this.Patient_GOTOFamily_Button.Text = "Go to Family History";
            this.Patient_GOTOFamily_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOFamily_Button.Click += new System.EventHandler(this.Patient_GOTOFamily_Button_Click_1);
            // 
            // Patient_GOTODemo_Button
            // 
            this.Patient_GOTODemo_Button.Location = new System.Drawing.Point(643, 244);
            this.Patient_GOTODemo_Button.Name = "Patient_GOTODemo_Button";
            this.Patient_GOTODemo_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTODemo_Button.TabIndex = 34;
            this.Patient_GOTODemo_Button.Text = "Go to Demographics";
            this.Patient_GOTODemo_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTODemo_Button.Click += new System.EventHandler(this.Patient_GOTODemo_Button_Click);
            // 
            // Name_Display
            // 
            this.Name_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Display.ForeColor = System.Drawing.Color.Red;
            this.Name_Display.Location = new System.Drawing.Point(94, 7);
            this.Name_Display.MaximumSize = new System.Drawing.Size(500, 100);
            this.Name_Display.Name = "Name_Display";
            this.Name_Display.Size = new System.Drawing.Size(242, 38);
            this.Name_Display.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Selected Patient: ";
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(746, 7);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 43;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(560, 7);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(166, 20);
            this.Search_Box.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Search By Patient ID:";
            // 
            // Patient_Allergy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Patient_goBack_Button);
            this.Controls.Add(this.Patient_GOTOImmune_Buttone);
            this.Controls.Add(this.Patient_GOTOGeneral_Button);
            this.Controls.Add(this.Patient_GOTOFamily_Button);
            this.Controls.Add(this.Patient_GOTODemo_Button);
            this.Controls.Add(this.Allergy_Add_Button);
            this.Controls.Add(this.Allergy_Label);
            this.Controls.Add(this.Allergy_Data_Dataset);
            this.Controls.Add(this.Allergy_Modify_Label);
            this.Controls.Add(this.Allergy_Delete_Button);
            this.Controls.Add(this.Allergy_Undo_Button);
            this.Controls.Add(this.Allergy_Save_Button);
            this.Controls.Add(this.Allergy_Modify_Button);
            this.Name = "Patient_Allergy_Form";
            this.Text = "Patient_Allergy_Form";
            this.Load += new System.EventHandler(this.Patient_Allergy_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Allergy_Data_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergyHistoryTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergyHistoryTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Allergy_Modify_Button;
        private System.Windows.Forms.Button Allergy_Save_Button;
        private System.Windows.Forms.Button Allergy_Undo_Button;
        private System.Windows.Forms.Button Allergy_Delete_Button;
        private System.Windows.Forms.Label Allergy_Modify_Label;
        private System.Windows.Forms.Label Allergy_Label;
        private System.Windows.Forms.Button Allergy_Add_Button;
        private System.Windows.Forms.BindingSource iTS245FinalDataSetBindingSource;
        private ITS245FinalDataSet iTS245FinalDataSet;
        private System.Windows.Forms.BindingSource allergyHistoryTableBindingSource;
        private ITS245FinalDataSetTableAdapters.allergyHistoryTableTableAdapter allergyHistoryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allergyHRFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Patient_goBack_Button;
        private System.Windows.Forms.Button Patient_GOTOImmune_Buttone;
        private System.Windows.Forms.Button Patient_GOTOGeneral_Button;
        private System.Windows.Forms.Button Patient_GOTOFamily_Button;
        private System.Windows.Forms.Button Patient_GOTODemo_Button;
        public System.Windows.Forms.DataGridView Allergy_Data_Dataset;
        private System.Windows.Forms.BindingSource allergyHistoryTableBindingSource1;
        private System.Windows.Forms.TextBox Name_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label3;
    }
}