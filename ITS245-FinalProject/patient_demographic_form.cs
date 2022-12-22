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
    public partial class patient_demographic_form : Form
    {   
        public patient_demographic_form()
        {
            InitializeComponent();
        }

        private void Patient_GOTOAllergy_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Allergy_Form().Show();
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

        private void Patient_GOTOImmune_Buttone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Immunization_Form().Show();
        }

        private void Patient_goBack_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Patient_Modify_Button_Click(object sender, EventArgs e)
        {
            Patient_Add_Button.Enabled = true;
            Patient_Save_Button.Enabled = true;
            Patient_Undo_Button.Enabled = true;
            Patient_Delete_Button.Enabled = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void patient_demographic_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet1.patientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter.Fill(this.iTS245FinalDataSet.patientTable);
            //Clears the database for reuse
            Demo_Data_Dataset.Rows.RemoveAt(0);
            Demo_Data_Dataset.Rows.RemoveAt(0);
            Demo_Data_Dataset.Rows.RemoveAt(0);
            Demo_Data_Dataset.Rows.RemoveAt(0);
        }

        private void Patient_Save_Button_Click(object sender, EventArgs e)
        {
            this.patientTableBindingSource.EndEdit();
            this.patientTableTableAdapter.Update(this.iTS245FinalDataSet.patientTable);
        }

        private void Patient_Undo_Button_Click(object sender, EventArgs e)
        {
            this.iTS245FinalDataSet.patientTable.RejectChanges();
        }

        private void Patient_Delete_Button_Click(object sender, EventArgs e)
        {
            Demo_Data_Dataset.AllowUserToDeleteRows = true;
            int row = Demo_Data_Dataset.CurrentCell.RowIndex;
            Demo_Data_Dataset.Rows.RemoveAt(row);
            this.patientTableTableAdapter.Update(this.iTS245FinalDataSet.patientTable);
              
        }

        private void Patient_Add_Button_Click(object sender, EventArgs e)
        {
            Demo_Data_Dataset.AllowUserToAddRows = true;
        }

        private void Demo_Data_Dataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name_Display.Text = Demo_Data_Dataset[e.ColumnIndex, e.RowIndex].Value.ToString();

        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            Demo_Data_Dataset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in Demo_Data_Dataset.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue) || row.Cells[2].Value.ToString().Equals(searchValue) || row.Cells[12].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }


            }
        }
    }
}
