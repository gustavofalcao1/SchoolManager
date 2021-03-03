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
    public partial class FormAlunosMod1 : Form
    {
        public FormAlunosMod1()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormHome());
            Application.Run(new FormAlunos());
        }//Chamada das forms que irei usar neste script

        private void ButtonBackA3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAlunos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para botão voltar, voltar para form Alunos

        private void ButtonHomeA3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para o botão Home voltar para form Home

        private void ButtonCloseA3_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Comando para o botao fechar a form

        public string ID;
        public void ButtonModA3_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Alunos set Nome ='" + textBoxNomeA3.Text + "',";
                SQL += "EstCivil = '" + comboBoxCiviA3.Text + "',";
                SQL += "Nascimento = '" + dateTimePickerA3.Text + "',";
                SQL += "Nacionalidade = '" + textBoxPaisA3.Text + "',";
                SQL += "Indentificação = '" + textBoxIndA3.Text + "',";
                SQL += "Curso = '" + comboBoxCursoA3.Text + "' ";
                SQL += "Where ID = " + ID;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Modificados com Sucesso!");               

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de error caso não tenha conexão
        }

        private void TextBoxNomeA3_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void CheckBoxSmA3_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Masculino

        private void CheckBoxSfA3_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Feminino

        private void ComboBoxCiviA3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Estado Civil

        private void DateTimePickerA3_ValueChanged(object sender, EventArgs e)
        {

        }//Nascimento

        private void TextBoxPaisA3_TextChanged(object sender, EventArgs e)
        {

        }//Nacionalidade

        private void CheckBoxSimA3_CheckedChanged(object sender, EventArgs e)
        {

        }//Deficiência

        private void TextBoxIndA3_TextChanged(object sender, EventArgs e)
        {

        }//Indentificação

        private void ComboBoxCursoA3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Curso

    }
}
