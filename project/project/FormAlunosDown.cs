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
using System.IO;

namespace project
{
    public partial class FormAlunosDown : Form
    {
        public FormAlunosDown()
        {
            InitializeComponent();
        }

        private void ButtonSearchA2_Click(object sender, EventArgs e)
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

                dataGridViewA2.DataSource = DS.Tables["Alunos"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private void ButtonDownA2_Click(object sender, EventArgs e)
        {
            SaveFileDialog exp = new SaveFileDialog();
            exp.Filter = "Arquivo texto | *.txt";
            exp.ShowDialog();

            using (StreamWriter write = new StreamWriter(exp.FileName, false, Encoding.UTF8))
            {
                    string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                    OleDbConnection conn = new OleDbConnection(StringCon);
                    conn.Open();

                    string SQL = "Select * from Alunos";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "Alunos");

                    OleDbCommand cmd = new OleDbCommand(SQL, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    try
                    {
                        while (dr.Read())

                        {
                            write.WriteLine(dr["ID"].ToString() + "\t" + dr["Nome"].ToString() + "\t" + dr["Masculino"].ToString() + "\t" + dr["Feminino"].ToString() + "\t" + dr["EstCivil"].ToString() + "\t" + dr["Nascimento"].ToString() + "\t" + dr["Nacionalidade"].ToString() + "\t" + dr["Deficiência"].ToString() + "\t" + dr["Indentificação"].ToString() + "\t" + dr["Curso"].ToString());
                        }
                    }
                    catch (Exception error)
                    {

                        MessageBox.Show(error.Message);
                    }
            }

        }
            
    }
}
