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
    public partial class FormProfessorDown : Form
    {
        public FormProfessorDown()
        {
            InitializeComponent();
        }

        private void ButtonSearchP2_Click(object sender, EventArgs e)
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

                dataGridViewP2.DataSource = DS.Tables["Professor"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private void ButtonDownP2_Click(object sender, EventArgs e)
        {
            SaveFileDialog exp = new SaveFileDialog();
            exp.Filter = "Arquivo texto | *.txt";
            exp.ShowDialog();

            using (StreamWriter write = new StreamWriter(exp.FileName, false, Encoding.UTF8))
            {
                    string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                    OleDbConnection conn = new OleDbConnection(StringCon);
                    conn.Open();

                    string SQL = "Select * from Professor";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                    DataSet DS = new DataSet();
                    adapter.Fill(DS, "Professor");

                    OleDbCommand cmd = new OleDbCommand(SQL, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    try
                    {
                        while (dr.Read())

                        {
                            write.WriteLine(dr["ID"].ToString() + "\t" + dr["Nome"].ToString() + "\t" + dr["Masculino"].ToString() + "\t" + dr["Feminino"].ToString() + "\t" + dr["EstCivil"].ToString() + "\t" + dr["Nascimento"].ToString() + "\t" + dr["Nacionalidade"].ToString() + "\t" + dr["Deficiência"].ToString() + "\t" + dr["Indentificação"].ToString() + "\t" + dr["Materia1"].ToString() + "\t" + dr["Materia2"].ToString() + "\t" + dr["Materia3"].ToString() + "\t" + dr["Materia4"].ToString());
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
