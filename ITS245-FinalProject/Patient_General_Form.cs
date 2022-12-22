using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITS245_FinalProject
{
    public partial class Patient_General_Form : Form
    {
        public Patient_General_Form()
        {
            InitializeComponent();
        }

        private void General_goBack_Main_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void General_Modify_Button_Click(object sender, EventArgs e)
        {
            General_Add_Button.Enabled = true;
            General_Save_Button.Enabled = true;
            General_Undo_Button.Enabled = true;
            General_Delete_Button.Enabled = true;
            Genral_AddTXT_Button.Enabled = true;
            this.BackColor = System.Drawing.Color.White;
        }

        private void Patient_General_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet.generalMedicalHistoryTable' table. You can move, or remove it, as needed.
            this.generalMedicalHistoryTableTableAdapter.Fill(this.iTS245FinalDataSet.generalMedicalHistoryTable);

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

        private void Patient_GOTOAllergy_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient_Allergy_Form().Show();
        }

        private void Genral_AddTXT_Button_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("General_History.txt"))
            {
                for (int i = 0; i < General_Data_Dataset.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < General_Data_Dataset.Columns.Count; j++)
                    {
                        tw.Write($"{General_Data_Dataset.Rows[i].Cells[j].Value.ToString()+ ","}");
                    }
                    tw.WriteLine();
                }
            }
        }

        private void General_Save_Button_Click(object sender, EventArgs e)
        {
            this.generalMedicalHistoryTableBindingSource.EndEdit();
            this.generalMedicalHistoryTableTableAdapter.Update(this.iTS245FinalDataSet.generalMedicalHistoryTable);
        }

        private void General_Undo_Button_Click(object sender, EventArgs e)
        {
            this.iTS245FinalDataSet.generalMedicalHistoryTable.RejectChanges();
        }

        private void General_Delete_Button_Click(object sender, EventArgs e)
        {
            int row = General_Data_Dataset.CurrentCell.RowIndex;
            General_Data_Dataset.Rows.RemoveAt(row);
        }

        private void General_Add_Button_Click(object sender, EventArgs e)
        {
            General_Data_Dataset.AllowUserToAddRows = true;
        }

        private void General_Data_Dataset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Name_Display.Text = General_Data_Dataset[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            General_Data_Dataset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in General_Data_Dataset.Rows)
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
