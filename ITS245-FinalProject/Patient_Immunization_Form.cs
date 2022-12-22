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
    public partial class Patient_Immunization_Form : Form
    {
        public Patient_Immunization_Form()
        {
            InitializeComponent();
        }

        private void Immunization_goBack_Main_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void Immunization_Modify_Button_Click(object sender, EventArgs e)
        {
            Immunization_Add_Button.Enabled = true;
            Immunization_Save_Button.Enabled = true;
            Immunization_Undo_Button.Enabled = true;
            Immunization_Delete_Button.Enabled = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void Patient_Immunization_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet.immunizationsHistoryTable' table. You can move, or remove it, as needed.
            this.immunizationsHistoryTableTableAdapter.Fill(this.iTS245FinalDataSet.immunizationsHistoryTable);

        }

        private void Patient_GOTODemo_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void Patient_GOTOFamily_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Family_History_Form().Show();
        }

        private void Patient_GOTOGeneral_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_General_Form().Show();
        }

        private void Patient_GOTOAllergy_Buttone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Allergy_Form().Show();
        }

        private void Patient_goBack_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Immunization_Save_Button_Click(object sender, EventArgs e)
        {
            this.immunizationsHistoryTableBindingSource.EndEdit();
            this.immunizationsHistoryTableTableAdapter.Update(this.iTS245FinalDataSet.immunizationsHistoryTable);
        }

        private void Immunization_Undo_Button_Click(object sender, EventArgs e)
        {
            this.iTS245FinalDataSet.immunizationsHistoryTable.RejectChanges();
        }

        private void Immunization_Delete_Button_Click(object sender, EventArgs e)
        {
            int row = Immunization_Data_Dataset.CurrentCell.RowIndex;
            Immunization_Data_Dataset.Rows.RemoveAt(row);
        }

        private void Immunization_Add_Button_Click(object sender, EventArgs e)
        {
            Immunization_Data_Dataset.AllowUserToAddRows = true;
        }

        private void Immunization_Data_Dataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name_Display.Text = Immunization_Data_Dataset[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            Immunization_Data_Dataset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in Immunization_Data_Dataset.Rows)
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
