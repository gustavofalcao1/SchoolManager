using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Biblioteca para conexão com MDB utilizando OleDb

namespace project
{
    public partial class FormAlunosAdd : Form
    {
        public FormAlunosAdd()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormHome());
            Application.Run(new FormAlunos());
        }//Chamada das forms

        private void ButtonCheckA1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Alunos(Nome,Masculino,Feminino,EstCivil,Nascimento,Nacionalidade,Deficiência,Indentificação,Curso) Values ";
                SQL += "('"+textBoxNomeA1.Text+"','"+checkBoxSmA1.Checked+"','"+checkBoxSfA1.Checked+"','"+comboBoxCiviA1.Text+"','"+dateTimePickerA1.Text+"','"+textBoxPaisA1.Text+"','"+checkBoxSimA1.Checked+"','"+textBoxIndA1.Text+"','"+comboBoxCursoA1.Text+"')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxNomeA1.Clear();
                textBoxPaisA1.Clear();
                textBoxIndA1.Clear();
               

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }

        private void TextBoxNomeA1_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void CheckBoxSmA1_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Masculino

        private void CheckBoxSfA1_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Feminino

        private void ComboBoxCiviA1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Estado Civil

        private void DateTimePickerA1_ValueChanged(object sender, EventArgs e)
        {

        }//Nascimento

        private void TextBoxPaisA1_TextChanged(object sender, EventArgs e)
        {

        }//Nacionalidade

        private void CheckBoxSimA1_CheckedChanged(object sender, EventArgs e)
        {

        }//Deficiência

        private void TextBoxIndA1_TextChanged(object sender, EventArgs e)
        {

        }//Indentificação

        private void ComboBoxCursoA1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Curso

    }
}
