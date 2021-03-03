using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class FormProfessorMod : Form
    {
        public FormProfessorMod()
        {
            InitializeComponent();
        }

        private void ButtonSearchP4_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Professor";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL,conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Professor");

                dataGridViewP4.DataSource = DS.Tables["Professor"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void ModificarToolStripMenuItemP4_Click(object sender, EventArgs e)
        {
            FormProfessorMod1 frm = new FormProfessorMod1();
            frm.ID = dataGridViewP4.SelectedCells[0].Value.ToString();
            frm.textBoxNomeP3.Text = dataGridViewP4.SelectedCells[1].Value.ToString();
            frm.comboBoxCiviP3.Text = dataGridViewP4.SelectedCells[4].Value.ToString();
            frm.dateTimePickerP3.Text = dataGridViewP4.SelectedCells[5].Value.ToString();
            frm.textBoxPaisP3.Text = dataGridViewP4.SelectedCells[6].Value.ToString();
            frm.textBoxIndP3.Text = dataGridViewP4.SelectedCells[8].Value.ToString();
            frm.comboBoxMateria1P3.Text = dataGridViewP4.SelectedCells[9].Value.ToString();
            frm.comboBoxMateria2P3.Text = dataGridViewP4.SelectedCells[10].Value.ToString();
            frm.comboBoxMateria3P3.Text = dataGridViewP4.SelectedCells[11].Value.ToString();
            frm.comboBoxMateria4P3.Text = dataGridViewP4.SelectedCells[12].Value.ToString();

            frm.ShowDialog();
        }
    }
}
