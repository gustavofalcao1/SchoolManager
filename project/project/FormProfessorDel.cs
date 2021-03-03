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
    public partial class FormProfessorDel : Form
    {
        public FormProfessorDel()
        {
            InitializeComponent();
        }

        private void ButtonSearchP5_Click(object sender, EventArgs e)
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

                dataGridViewP5.DataSource = DS.Tables["Professor"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void DeletarToolStripMenuItemP5_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                string cod = dataGridViewP5.SelectedCells[0].Value.ToString();
                string SQL = "Delete * from Professor where ID =" + cod;
                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados deletados com sucesso!!");

                ButtonSearchP5_Click(sender, e);

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
