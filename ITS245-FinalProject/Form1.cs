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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Home_Confirm_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new patient_demographic_form().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTS245FinalDataSet.patientTable' table. You can move, or remove it, as needed.
            this.patientTableTableAdapter.Fill(this.iTS245FinalDataSet.patientTable);
        }

        private void Home_Patient_Database_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Main_Display.Text = Home_Patient_Database[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchValue = Search_Box.Text;

            Home_Patient_Database.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            {
                foreach (DataGridViewRow row in Home_Patient_Database.Rows)
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
