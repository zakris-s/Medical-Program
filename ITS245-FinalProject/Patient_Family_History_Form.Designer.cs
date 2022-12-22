namespace ITS245_FinalProject
{
    partial class Patient_Family_History_Form
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
            this.Allergy_Label = new System.Windows.Forms.Label();
            this.FamilyHistory_Data_Dataset = new System.Windows.Forms.DataGridView();
            this.familyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.livesWithPatientDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.majorDisorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificTypeDisorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hisorderHRFDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.familyHistoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTS245FinalDataSet = new ITS245_FinalProject.ITS245FinalDataSet();
            this.Family_Modify_Label = new System.Windows.Forms.Label();
            this.Family_Delete_Button = new System.Windows.Forms.Button();
            this.Family_Undo_Button = new System.Windows.Forms.Button();
            this.Family_Save_Button = new System.Windows.Forms.Button();
            this.Family_Modify_Button = new System.Windows.Forms.Button();
            this.Family_Add_Button = new System.Windows.Forms.Button();
            this.familyHistoryTableTableAdapter = new ITS245_FinalProject.ITS245FinalDataSetTableAdapters.familyHistoryTableTableAdapter();
            this.Patient_GOTOImmune_Buttone = new System.Windows.Forms.Button();
            this.Patient_GOTOGeneral_Button = new System.Windows.Forms.Button();
            this.Patient_GOTOAllergy_Button = new System.Windows.Forms.Button();
            this.Patient_GOTODemo_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_Display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyHistory_Data_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyHistoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Allergy_Label
            // 
            this.Allergy_Label.AutoSize = true;
            this.Allergy_Label.Location = new System.Drawing.Point(52, 45);
            this.Allergy_Label.Name = "Allergy_Label";
            this.Allergy_Label.Size = new System.Drawing.Size(163, 13);
            this.Allergy_Label.TabIndex = 14;
            this.Allergy_Label.Text = "Patient Family HIstory Information";
            // 
            // FamilyHistory_Data_Dataset
            // 
            this.FamilyHistory_Data_Dataset.AllowUserToAddRows = false;
            this.FamilyHistory_Data_Dataset.AutoGenerateColumns = false;
            this.FamilyHistory_Data_Dataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FamilyHistory_Data_Dataset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.familyIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.aliveDataGridViewCheckBoxColumn,
            this.livesWithPatientDataGridViewCheckBoxColumn,
            this.majorDisorderDataGridViewTextBoxColumn,
            this.specificTypeDisorderDataGridViewTextBoxColumn,
            this.hisorderHRFDataGridViewCheckBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.FamilyHistory_Data_Dataset.DataSource = this.familyHistoryTableBindingSource;
            this.FamilyHistory_Data_Dataset.Location = new System.Drawing.Point(52, 64);
            this.FamilyHistory_Data_Dataset.MultiSelect = false;
            this.FamilyHistory_Data_Dataset.Name = "FamilyHistory_Data_Dataset";
            this.FamilyHistory_Data_Dataset.Size = new System.Drawing.Size(1043, 150);
            this.FamilyHistory_Data_Dataset.TabIndex = 13;
            this.FamilyHistory_Data_Dataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FamilyHistory_Data_Dataset_CellContentClick);
            // 
            // familyIDDataGridViewTextBoxColumn
            // 
            this.familyIDDataGridViewTextBoxColumn.DataPropertyName = "FamilyID";
            this.familyIDDataGridViewTextBoxColumn.HeaderText = "FamilyID";
            this.familyIDDataGridViewTextBoxColumn.Name = "familyIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "Relation";
            this.relationDataGridViewTextBoxColumn.HeaderText = "Relation";
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            // 
            // aliveDataGridViewCheckBoxColumn
            // 
            this.aliveDataGridViewCheckBoxColumn.DataPropertyName = "Alive";
            this.aliveDataGridViewCheckBoxColumn.HeaderText = "Alive";
            this.aliveDataGridViewCheckBoxColumn.Name = "aliveDataGridViewCheckBoxColumn";
            // 
            // livesWithPatientDataGridViewCheckBoxColumn
            // 
            this.livesWithPatientDataGridViewCheckBoxColumn.DataPropertyName = "Lives with patient";
            this.livesWithPatientDataGridViewCheckBoxColumn.HeaderText = "Lives with patient";
            this.livesWithPatientDataGridViewCheckBoxColumn.Name = "livesWithPatientDataGridViewCheckBoxColumn";
            // 
            // majorDisorderDataGridViewTextBoxColumn
            // 
            this.majorDisorderDataGridViewTextBoxColumn.DataPropertyName = "MajorDisorder";
            this.majorDisorderDataGridViewTextBoxColumn.HeaderText = "MajorDisorder";
            this.majorDisorderDataGridViewTextBoxColumn.Name = "majorDisorderDataGridViewTextBoxColumn";
            // 
            // specificTypeDisorderDataGridViewTextBoxColumn
            // 
            this.specificTypeDisorderDataGridViewTextBoxColumn.DataPropertyName = "SpecificTypeDisorder";
            this.specificTypeDisorderDataGridViewTextBoxColumn.HeaderText = "SpecificTypeDisorder";
            this.specificTypeDisorderDataGridViewTextBoxColumn.Name = "specificTypeDisorderDataGridViewTextBoxColumn";
            // 
            // hisorderHRFDataGridViewCheckBoxColumn
            // 
            this.hisorderHRFDataGridViewCheckBoxColumn.DataPropertyName = "HisorderHRF";
            this.hisorderHRFDataGridViewCheckBoxColumn.HeaderText = "HisorderHRF";
            this.hisorderHRFDataGridViewCheckBoxColumn.Name = "hisorderHRFDataGridViewCheckBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // familyHistoryTableBindingSource
            // 
            this.familyHistoryTableBindingSource.DataMember = "familyHistoryTable";
            this.familyHistoryTableBindingSource.DataSource = this.iTS245FinalDataSet;
            // 
            // iTS245FinalDataSet
            // 
            this.iTS245FinalDataSet.DataSetName = "ITS245FinalDataSet";
            this.iTS245FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Family_Modify_Label
            // 
            this.Family_Modify_Label.AutoSize = true;
            this.Family_Modify_Label.Location = new System.Drawing.Point(49, 217);
            this.Family_Modify_Label.Name = "Family_Modify_Label";
            this.Family_Modify_Label.Size = new System.Drawing.Size(148, 13);
            this.Family_Modify_Label.TabIndex = 12;
            this.Family_Modify_Label.Text = "Click modify to make changes";
            // 
            // Family_Delete_Button
            // 
            this.Family_Delete_Button.Enabled = false;
            this.Family_Delete_Button.Location = new System.Drawing.Point(49, 400);
            this.Family_Delete_Button.Name = "Family_Delete_Button";
            this.Family_Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Family_Delete_Button.TabIndex = 11;
            this.Family_Delete_Button.Text = "Delete";
            this.Family_Delete_Button.UseVisualStyleBackColor = true;
            this.Family_Delete_Button.Click += new System.EventHandler(this.Family_Delete_Button_Click);
            // 
            // Family_Undo_Button
            // 
            this.Family_Undo_Button.Enabled = false;
            this.Family_Undo_Button.Location = new System.Drawing.Point(49, 359);
            this.Family_Undo_Button.Name = "Family_Undo_Button";
            this.Family_Undo_Button.Size = new System.Drawing.Size(75, 23);
            this.Family_Undo_Button.TabIndex = 10;
            this.Family_Undo_Button.Text = "Undo";
            this.Family_Undo_Button.UseVisualStyleBackColor = true;
            this.Family_Undo_Button.Click += new System.EventHandler(this.Family_Undo_Button_Click);
            // 
            // Family_Save_Button
            // 
            this.Family_Save_Button.Enabled = false;
            this.Family_Save_Button.Location = new System.Drawing.Point(49, 315);
            this.Family_Save_Button.Name = "Family_Save_Button";
            this.Family_Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Family_Save_Button.TabIndex = 9;
            this.Family_Save_Button.Text = "Save";
            this.Family_Save_Button.UseVisualStyleBackColor = true;
            this.Family_Save_Button.Click += new System.EventHandler(this.Family_Save_Button_Click);
            // 
            // Family_Modify_Button
            // 
            this.Family_Modify_Button.Location = new System.Drawing.Point(49, 236);
            this.Family_Modify_Button.Name = "Family_Modify_Button";
            this.Family_Modify_Button.Size = new System.Drawing.Size(103, 25);
            this.Family_Modify_Button.TabIndex = 8;
            this.Family_Modify_Button.Text = "Modify";
            this.Family_Modify_Button.UseVisualStyleBackColor = true;
            this.Family_Modify_Button.Click += new System.EventHandler(this.Family_Modify_Button_Click);
            // 
            // Family_Add_Button
            // 
            this.Family_Add_Button.Enabled = false;
            this.Family_Add_Button.Location = new System.Drawing.Point(49, 276);
            this.Family_Add_Button.Name = "Family_Add_Button";
            this.Family_Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Family_Add_Button.TabIndex = 33;
            this.Family_Add_Button.Text = "Add";
            this.Family_Add_Button.UseVisualStyleBackColor = true;
            this.Family_Add_Button.Click += new System.EventHandler(this.Family_Add_Button_Click);
            // 
            // familyHistoryTableTableAdapter
            // 
            this.familyHistoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // Patient_GOTOImmune_Buttone
            // 
            this.Patient_GOTOImmune_Buttone.Location = new System.Drawing.Point(802, 359);
            this.Patient_GOTOImmune_Buttone.Name = "Patient_GOTOImmune_Buttone";
            this.Patient_GOTOImmune_Buttone.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOImmune_Buttone.TabIndex = 42;
            this.Patient_GOTOImmune_Buttone.Text = "Go to Immunization History";
            this.Patient_GOTOImmune_Buttone.UseVisualStyleBackColor = true;
            this.Patient_GOTOImmune_Buttone.Click += new System.EventHandler(this.Patient_GOTOImmune_Buttone_Click);
            // 
            // Patient_GOTOGeneral_Button
            // 
            this.Patient_GOTOGeneral_Button.Location = new System.Drawing.Point(802, 320);
            this.Patient_GOTOGeneral_Button.Name = "Patient_GOTOGeneral_Button";
            this.Patient_GOTOGeneral_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOGeneral_Button.TabIndex = 41;
            this.Patient_GOTOGeneral_Button.Text = "Go to General History";
            this.Patient_GOTOGeneral_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOGeneral_Button.Click += new System.EventHandler(this.Patient_GOTOGeneral_Button_Click);
            // 
            // Patient_GOTOAllergy_Button
            // 
            this.Patient_GOTOAllergy_Button.Location = new System.Drawing.Point(802, 282);
            this.Patient_GOTOAllergy_Button.Name = "Patient_GOTOAllergy_Button";
            this.Patient_GOTOAllergy_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOAllergy_Button.TabIndex = 40;
            this.Patient_GOTOAllergy_Button.Text = "Go to Allergy History";
            this.Patient_GOTOAllergy_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOAllergy_Button.Click += new System.EventHandler(this.Patient_GOTOAllergy_Button_Click);
            // 
            // Patient_GOTODemo_Button
            // 
            this.Patient_GOTODemo_Button.Location = new System.Drawing.Point(802, 244);
            this.Patient_GOTODemo_Button.Name = "Patient_GOTODemo_Button";
            this.Patient_GOTODemo_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTODemo_Button.TabIndex = 39;
            this.Patient_GOTODemo_Button.Text = "Go to Demographics";
            this.Patient_GOTODemo_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTODemo_Button.Click += new System.EventHandler(this.Patient_GOTODemo_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Go Back to Patient Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_Display
            // 
            this.Name_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Display.ForeColor = System.Drawing.Color.Red;
            this.Name_Display.Location = new System.Drawing.Point(148, 4);
            this.Name_Display.MaximumSize = new System.Drawing.Size(500, 100);
            this.Name_Display.Name = "Name_Display";
            this.Name_Display.Size = new System.Drawing.Size(242, 38);
            this.Name_Display.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Selected Patient: ";
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(761, 4);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 48;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(575, 4);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(166, 20);
            this.Search_Box.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search By Patient ID:";
            // 
            // Patient_Family_History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Patient_GOTOImmune_Buttone);
            this.Controls.Add(this.Patient_GOTOGeneral_Button);
            this.Controls.Add(this.Patient_GOTOAllergy_Button);
            this.Controls.Add(this.Patient_GOTODemo_Button);
            this.Controls.Add(this.Family_Add_Button);
            this.Controls.Add(this.Allergy_Label);
            this.Controls.Add(this.FamilyHistory_Data_Dataset);
            this.Controls.Add(this.Family_Modify_Label);
            this.Controls.Add(this.Family_Delete_Button);
            this.Controls.Add(this.Family_Undo_Button);
            this.Controls.Add(this.Family_Save_Button);
            this.Controls.Add(this.Family_Modify_Button);
            this.Name = "Patient_Family_History_Form";
            this.Text = "Patient_Family_History_Form";
            this.Load += new System.EventHandler(this.Patient_Family_History_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FamilyHistory_Data_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyHistoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Allergy_Label;
        private System.Windows.Forms.DataGridView FamilyHistory_Data_Dataset;
        private System.Windows.Forms.Label Family_Modify_Label;
        private System.Windows.Forms.Button Family_Delete_Button;
        private System.Windows.Forms.Button Family_Undo_Button;
        private System.Windows.Forms.Button Family_Save_Button;
        private System.Windows.Forms.Button Family_Modify_Button;
        private System.Windows.Forms.Button Family_Add_Button;
        private ITS245FinalDataSet iTS245FinalDataSet;
        private System.Windows.Forms.BindingSource familyHistoryTableBindingSource;
        private ITS245FinalDataSetTableAdapters.familyHistoryTableTableAdapter familyHistoryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aliveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn livesWithPatientDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDisorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificTypeDisorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hisorderHRFDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Patient_GOTOImmune_Buttone;
        private System.Windows.Forms.Button Patient_GOTOGeneral_Button;
        private System.Windows.Forms.Button Patient_GOTOAllergy_Button;
        private System.Windows.Forms.Button Patient_GOTODemo_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label3;
    }
}