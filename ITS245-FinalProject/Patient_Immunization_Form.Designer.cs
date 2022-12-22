namespace ITS245_FinalProject
{
    partial class Patient_Immunization_Form
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
            this.Immunization_Label = new System.Windows.Forms.Label();
            this.Immunization_Data_Dataset = new System.Windows.Forms.DataGridView();
            this.immunizationsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immunizationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.immunizationsHistoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTS245FinalDataSet = new ITS245_FinalProject.ITS245FinalDataSet();
            this.Immunization_Modify_Label = new System.Windows.Forms.Label();
            this.Immunization_Delete_Button = new System.Windows.Forms.Button();
            this.Immunization_Undo_Button = new System.Windows.Forms.Button();
            this.Immunization_Save_Button = new System.Windows.Forms.Button();
            this.Immunization_Modify_Button = new System.Windows.Forms.Button();
            this.Immunization_Add_Button = new System.Windows.Forms.Button();
            this.immunizationsHistoryTableTableAdapter = new ITS245_FinalProject.ITS245FinalDataSetTableAdapters.immunizationsHistoryTableTableAdapter();
            this.Patient_goBack_Button = new System.Windows.Forms.Button();
            this.Patient_GOTOAllergy_Buttone = new System.Windows.Forms.Button();
            this.Patient_GOTOGeneral_Button = new System.Windows.Forms.Button();
            this.Patient_GOTOFamily_Button = new System.Windows.Forms.Button();
            this.Patient_GOTODemo_Button = new System.Windows.Forms.Button();
            this.Name_Display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Immunization_Data_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immunizationsHistoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Immunization_Label
            // 
            this.Immunization_Label.AutoSize = true;
            this.Immunization_Label.Location = new System.Drawing.Point(23, 45);
            this.Immunization_Label.Name = "Immunization_Label";
            this.Immunization_Label.Size = new System.Drawing.Size(195, 13);
            this.Immunization_Label.TabIndex = 30;
            this.Immunization_Label.Text = "Patient Immunization HIstory Information";
            // 
            // Immunization_Data_Dataset
            // 
            this.Immunization_Data_Dataset.AutoGenerateColumns = false;
            this.Immunization_Data_Dataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Immunization_Data_Dataset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.immunizationsIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.vaccineDataGridViewTextBoxColumn,
            this.immunizationDateDataGridViewTextBoxColumn,
            this.experationDateDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.hCPIDDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.Immunization_Data_Dataset.DataSource = this.immunizationsHistoryTableBindingSource;
            this.Immunization_Data_Dataset.Location = new System.Drawing.Point(22, 64);
            this.Immunization_Data_Dataset.MultiSelect = false;
            this.Immunization_Data_Dataset.Name = "Immunization_Data_Dataset";
            this.Immunization_Data_Dataset.Size = new System.Drawing.Size(940, 150);
            this.Immunization_Data_Dataset.TabIndex = 29;
            this.Immunization_Data_Dataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Immunization_Data_Dataset_CellContentClick);
            // 
            // immunizationsIDDataGridViewTextBoxColumn
            // 
            this.immunizationsIDDataGridViewTextBoxColumn.DataPropertyName = "ImmunizationsID";
            this.immunizationsIDDataGridViewTextBoxColumn.HeaderText = "ImmunizationsID";
            this.immunizationsIDDataGridViewTextBoxColumn.Name = "immunizationsIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // vaccineDataGridViewTextBoxColumn
            // 
            this.vaccineDataGridViewTextBoxColumn.DataPropertyName = "Vaccine";
            this.vaccineDataGridViewTextBoxColumn.HeaderText = "Vaccine";
            this.vaccineDataGridViewTextBoxColumn.Name = "vaccineDataGridViewTextBoxColumn";
            // 
            // immunizationDateDataGridViewTextBoxColumn
            // 
            this.immunizationDateDataGridViewTextBoxColumn.DataPropertyName = "ImmunizationDate";
            this.immunizationDateDataGridViewTextBoxColumn.HeaderText = "ImmunizationDate";
            this.immunizationDateDataGridViewTextBoxColumn.Name = "immunizationDateDataGridViewTextBoxColumn";
            // 
            // experationDateDataGridViewTextBoxColumn
            // 
            this.experationDateDataGridViewTextBoxColumn.DataPropertyName = "ExperationDate";
            this.experationDateDataGridViewTextBoxColumn.HeaderText = "ExperationDate";
            this.experationDateDataGridViewTextBoxColumn.Name = "experationDateDataGridViewTextBoxColumn";
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // hCPIDDataGridViewTextBoxColumn
            // 
            this.hCPIDDataGridViewTextBoxColumn.DataPropertyName = "HCPID";
            this.hCPIDDataGridViewTextBoxColumn.HeaderText = "HCPID";
            this.hCPIDDataGridViewTextBoxColumn.Name = "hCPIDDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // immunizationsHistoryTableBindingSource
            // 
            this.immunizationsHistoryTableBindingSource.DataMember = "immunizationsHistoryTable";
            this.immunizationsHistoryTableBindingSource.DataSource = this.iTS245FinalDataSet;
            // 
            // iTS245FinalDataSet
            // 
            this.iTS245FinalDataSet.DataSetName = "ITS245FinalDataSet";
            this.iTS245FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Immunization_Modify_Label
            // 
            this.Immunization_Modify_Label.AutoSize = true;
            this.Immunization_Modify_Label.Location = new System.Drawing.Point(49, 217);
            this.Immunization_Modify_Label.Name = "Immunization_Modify_Label";
            this.Immunization_Modify_Label.Size = new System.Drawing.Size(148, 13);
            this.Immunization_Modify_Label.TabIndex = 28;
            this.Immunization_Modify_Label.Text = "Click modify to make changes";
            // 
            // Immunization_Delete_Button
            // 
            this.Immunization_Delete_Button.Enabled = false;
            this.Immunization_Delete_Button.Location = new System.Drawing.Point(49, 400);
            this.Immunization_Delete_Button.Name = "Immunization_Delete_Button";
            this.Immunization_Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Immunization_Delete_Button.TabIndex = 27;
            this.Immunization_Delete_Button.Text = "Delete";
            this.Immunization_Delete_Button.UseVisualStyleBackColor = true;
            this.Immunization_Delete_Button.Click += new System.EventHandler(this.Immunization_Delete_Button_Click);
            // 
            // Immunization_Undo_Button
            // 
            this.Immunization_Undo_Button.Enabled = false;
            this.Immunization_Undo_Button.Location = new System.Drawing.Point(49, 359);
            this.Immunization_Undo_Button.Name = "Immunization_Undo_Button";
            this.Immunization_Undo_Button.Size = new System.Drawing.Size(75, 23);
            this.Immunization_Undo_Button.TabIndex = 26;
            this.Immunization_Undo_Button.Text = "Undo";
            this.Immunization_Undo_Button.UseVisualStyleBackColor = true;
            this.Immunization_Undo_Button.Click += new System.EventHandler(this.Immunization_Undo_Button_Click);
            // 
            // Immunization_Save_Button
            // 
            this.Immunization_Save_Button.Enabled = false;
            this.Immunization_Save_Button.Location = new System.Drawing.Point(49, 315);
            this.Immunization_Save_Button.Name = "Immunization_Save_Button";
            this.Immunization_Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Immunization_Save_Button.TabIndex = 25;
            this.Immunization_Save_Button.Text = "Save";
            this.Immunization_Save_Button.UseVisualStyleBackColor = true;
            this.Immunization_Save_Button.Click += new System.EventHandler(this.Immunization_Save_Button_Click);
            // 
            // Immunization_Modify_Button
            // 
            this.Immunization_Modify_Button.Location = new System.Drawing.Point(49, 236);
            this.Immunization_Modify_Button.Name = "Immunization_Modify_Button";
            this.Immunization_Modify_Button.Size = new System.Drawing.Size(103, 25);
            this.Immunization_Modify_Button.TabIndex = 24;
            this.Immunization_Modify_Button.Text = "Modify";
            this.Immunization_Modify_Button.UseVisualStyleBackColor = true;
            this.Immunization_Modify_Button.Click += new System.EventHandler(this.Immunization_Modify_Button_Click);
            // 
            // Immunization_Add_Button
            // 
            this.Immunization_Add_Button.Enabled = false;
            this.Immunization_Add_Button.Location = new System.Drawing.Point(49, 276);
            this.Immunization_Add_Button.Name = "Immunization_Add_Button";
            this.Immunization_Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Immunization_Add_Button.TabIndex = 32;
            this.Immunization_Add_Button.Text = "Add";
            this.Immunization_Add_Button.UseVisualStyleBackColor = true;
            this.Immunization_Add_Button.Click += new System.EventHandler(this.Immunization_Add_Button_Click);
            // 
            // immunizationsHistoryTableTableAdapter
            // 
            this.immunizationsHistoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // Patient_goBack_Button
            // 
            this.Patient_goBack_Button.Location = new System.Drawing.Point(676, 389);
            this.Patient_goBack_Button.Name = "Patient_goBack_Button";
            this.Patient_goBack_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_goBack_Button.TabIndex = 43;
            this.Patient_goBack_Button.Text = "Go Back to Patient Select";
            this.Patient_goBack_Button.UseVisualStyleBackColor = true;
            this.Patient_goBack_Button.Click += new System.EventHandler(this.Patient_goBack_Button_Click);
            // 
            // Patient_GOTOAllergy_Buttone
            // 
            this.Patient_GOTOAllergy_Buttone.Location = new System.Drawing.Point(676, 348);
            this.Patient_GOTOAllergy_Buttone.Name = "Patient_GOTOAllergy_Buttone";
            this.Patient_GOTOAllergy_Buttone.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOAllergy_Buttone.TabIndex = 42;
            this.Patient_GOTOAllergy_Buttone.Text = "Go to Allergy History";
            this.Patient_GOTOAllergy_Buttone.UseVisualStyleBackColor = true;
            this.Patient_GOTOAllergy_Buttone.Click += new System.EventHandler(this.Patient_GOTOAllergy_Buttone_Click);
            // 
            // Patient_GOTOGeneral_Button
            // 
            this.Patient_GOTOGeneral_Button.Location = new System.Drawing.Point(676, 309);
            this.Patient_GOTOGeneral_Button.Name = "Patient_GOTOGeneral_Button";
            this.Patient_GOTOGeneral_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOGeneral_Button.TabIndex = 41;
            this.Patient_GOTOGeneral_Button.Text = "Go to General History";
            this.Patient_GOTOGeneral_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOGeneral_Button.Click += new System.EventHandler(this.Patient_GOTOGeneral_Button_Click);
            // 
            // Patient_GOTOFamily_Button
            // 
            this.Patient_GOTOFamily_Button.Location = new System.Drawing.Point(676, 271);
            this.Patient_GOTOFamily_Button.Name = "Patient_GOTOFamily_Button";
            this.Patient_GOTOFamily_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTOFamily_Button.TabIndex = 40;
            this.Patient_GOTOFamily_Button.Text = "Go to Family History";
            this.Patient_GOTOFamily_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTOFamily_Button.Click += new System.EventHandler(this.Patient_GOTOFamily_Button_Click);
            // 
            // Patient_GOTODemo_Button
            // 
            this.Patient_GOTODemo_Button.Location = new System.Drawing.Point(676, 233);
            this.Patient_GOTODemo_Button.Name = "Patient_GOTODemo_Button";
            this.Patient_GOTODemo_Button.Size = new System.Drawing.Size(144, 23);
            this.Patient_GOTODemo_Button.TabIndex = 39;
            this.Patient_GOTODemo_Button.Text = "Go to Demographics";
            this.Patient_GOTODemo_Button.UseVisualStyleBackColor = true;
            this.Patient_GOTODemo_Button.Click += new System.EventHandler(this.Patient_GOTODemo_Button_Click);
            // 
            // Name_Display
            // 
            this.Name_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Display.ForeColor = System.Drawing.Color.Red;
            this.Name_Display.Location = new System.Drawing.Point(120, 4);
            this.Name_Display.MaximumSize = new System.Drawing.Size(500, 100);
            this.Name_Display.Name = "Name_Display";
            this.Name_Display.Size = new System.Drawing.Size(242, 38);
            this.Name_Display.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Selected Patient: ";
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(755, 4);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 48;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(569, 4);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(166, 20);
            this.Search_Box.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Search By Patient ID:";
            // 
            // Patient_Immunization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_Display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Patient_goBack_Button);
            this.Controls.Add(this.Patient_GOTOAllergy_Buttone);
            this.Controls.Add(this.Patient_GOTOGeneral_Button);
            this.Controls.Add(this.Patient_GOTOFamily_Button);
            this.Controls.Add(this.Patient_GOTODemo_Button);
            this.Controls.Add(this.Immunization_Add_Button);
            this.Controls.Add(this.Immunization_Label);
            this.Controls.Add(this.Immunization_Data_Dataset);
            this.Controls.Add(this.Immunization_Modify_Label);
            this.Controls.Add(this.Immunization_Delete_Button);
            this.Controls.Add(this.Immunization_Undo_Button);
            this.Controls.Add(this.Immunization_Save_Button);
            this.Controls.Add(this.Immunization_Modify_Button);
            this.Name = "Patient_Immunization_Form";
            this.Text = "Patient_Immunization_Form";
            this.Load += new System.EventHandler(this.Patient_Immunization_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Immunization_Data_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immunizationsHistoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS245FinalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Immunization_Label;
        private System.Windows.Forms.DataGridView Immunization_Data_Dataset;
        private System.Windows.Forms.Label Immunization_Modify_Label;
        private System.Windows.Forms.Button Immunization_Delete_Button;
        private System.Windows.Forms.Button Immunization_Undo_Button;
        private System.Windows.Forms.Button Immunization_Save_Button;
        private System.Windows.Forms.Button Immunization_Modify_Button;
        private System.Windows.Forms.Button Immunization_Add_Button;
        private ITS245FinalDataSet iTS245FinalDataSet;
        private System.Windows.Forms.BindingSource immunizationsHistoryTableBindingSource;
        private ITS245FinalDataSetTableAdapters.immunizationsHistoryTableTableAdapter immunizationsHistoryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn immunizationsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn immunizationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Patient_goBack_Button;
        private System.Windows.Forms.Button Patient_GOTOAllergy_Buttone;
        private System.Windows.Forms.Button Patient_GOTOGeneral_Button;
        private System.Windows.Forms.Button Patient_GOTOFamily_Button;
        private System.Windows.Forms.Button Patient_GOTODemo_Button;
        private System.Windows.Forms.TextBox Name_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.Label label3;
    }
}