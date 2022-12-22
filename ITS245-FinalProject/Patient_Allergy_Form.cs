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
    public partial class Patient_Allergy_Form : Form
    {
        public Patient_Allergy_Form()
        {
            InitializeComponent();
        }

        private void Allergy_Modify_Button_Click(object sender, EventArgs e)
        {
            Allergy_Add_Button.Enabled = true;
            Allergy_Save_Button.Enabled = true;
            Allergy_Undo_Button.Enabled = true;
            Allergy_Delete_Button.Enabled = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void Patient_Allergy_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet.allergyHistoryTable' table. You can move, or remove it, as needed.
            this.allergyHistoryTableTableAdapter.Fill(this.iTS245FinalDataSet.allergyHistoryTable);
        }

        private void Allergy_Save_Button_Click(object sender, EventArgs e)
        {
            this.allergyHistoryTableBindingSource.EndEdit();
            this.allergyHistoryTableTableAdapter.Update(this.iTS245FinalDataSet.allergyHistoryTable);
        }

        private void Patient_GOTOFamily_Button_Click_1(object sender, EventArgs e)
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
        private void Patient_GOTODemo_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void Patient_goBack_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Allergy_Undo_Button_Click(object sender, EventArgs e)
        {
            this.iTS245FinalDataSet.allergyHistoryTable.RejectChanges();
        }

        private void Allergy_Delete_Button_Click(object sender, EventArgs e)
        {
            int row = Allergy_Data_Dataset.CurrentCell.RowIndex;
            Allergy_Data_Dataset.Rows.RemoveAt(row);
        }

        private void Allergy_Add_Button_Click(object sender, EventArgs e)
        {
            Allergy_Data_Dataset.AllowUserToAddRows = true;
        }

        private void Allergy_Data_Dataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name_Display.Text = Allergy_Data_Dataset[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            Allergy_Data_Dataset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in Allergy_Data_Dataset.Rows)
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
