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
    public partial class FormAlunosSearch : Form
    {
        public FormAlunosSearch()
        {
            InitializeComponent();
        }

        private void ButtonSearchA1_Click(object sender, EventArgs e)
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

                dataGridViewA1.DataSource = DS.Tables["Alunos"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
