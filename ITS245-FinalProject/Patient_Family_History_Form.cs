using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITS245_FinalProject
{
    public partial class Patient_Family_History_Form : Form
    {
        public Patient_Family_History_Form()
        {
            InitializeComponent();
        }

        private void Family_goBack_Main_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void Family_Modify_Button_Click(object sender, EventArgs e)
        {
            Family_Add_Button.Enabled = true;
            Family_Save_Button.Enabled = true;
            Family_Undo_Button.Enabled = true;
            Family_Delete_Button.Enabled = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void Patient_Family_History_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet.familyHistoryTable' table. You can move, or remove it, as needed.
            this.familyHistoryTableTableAdapter.Fill(this.iTS245FinalDataSet.familyHistoryTable);

        }


        private void Patient_GOTOGeneral_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_General_Form().Show();
        }

        private void Patient_GOTOImmune_Buttone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Immunization_Form().Show();
        }
        private void Patient_GOTODemo_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Patient_GOTOAllergy_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Allergy_Form().Show();
        }

        private void Family_Save_Button_Click(object sender, EventArgs e)
        {
            this.familyHistoryTableBindingSource.EndEdit();
            this.familyHistoryTableTableAdapter.Update(this.iTS245FinalDataSet.familyHistoryTable);
        }

        private void Family_Undo_Button_Click(object sender, EventArgs e)
        {
            this.iTS245FinalDataSet.familyHistoryTable.RejectChanges();
        }

        private void Family_Delete_Button_Click(object sender, EventArgs e)
        {
            int row = FamilyHistory_Data_Dataset.CurrentCell.RowIndex;
            FamilyHistory_Data_Dataset.Rows.RemoveAt(row);
        }

        private void Family_Add_Button_Click(object sender, EventArgs e)
        {
            FamilyHistory_Data_Dataset.AllowUserToAddRows = true;
        }

        private void FamilyHistory_Data_Dataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name_Display.Text = FamilyHistory_Data_Dataset[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            FamilyHistory_Data_Dataset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in FamilyHistory_Data_Dataset.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }


            }
        }
    }
}
