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
    public partial class FormAlunosMod : Form
    {
        public FormAlunosMod()
        {
            InitializeComponent();
        }

        private void ButtonSearchA4_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Alunos";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL,conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Alunos");

                dataGridViewA4.DataSource = DS.Tables["Alunos"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlunosMod1 frm = new FormAlunosMod1();
            frm.ID = dataGridViewA4.SelectedCells[0].Value.ToString();
            frm.textBoxNomeA3.Text = dataGridViewA4.SelectedCells[1].Value.ToString();
            frm.comboBoxCiviA3.Text = dataGridViewA4.SelectedCells[4].Value.ToString();
            frm.dateTimePickerA3.Text = dataGridViewA4.SelectedCells[5].Value.ToString();
            frm.textBoxPaisA3.Text = dataGridViewA4.SelectedCells[6].Value.ToString();
            frm.textBoxIndA3.Text = dataGridViewA4.SelectedCells[8].Value.ToString();
            frm.comboBoxCursoA3.Text = dataGridViewA4.SelectedCells[9].Value.ToString();

            frm.ShowDialog();
        }
    }
}
