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
    public partial class FormProfessorAdd : Form
    {
        public FormProfessorAdd()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormHome());
            Application.Run(new FormAlunos());
        }//Chamada das forms que irei usar neste script

        private void ButtonBackP1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAlunos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para botão voltar, voltar para form Alunos

        private void ButtonHomeP1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para o botão Home voltar para form Home

        private void ButtonCloseP1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Comando para o botao fechar a form

        private void ButtonCheckP1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Professor(Nome,Masculino,Feminino,EstCivil,Nascimento,Nacionalidade,Deficiência,Indentificação,Materia1,Materia2,Materia3,Materia4) Values ";
                SQL += "('"+textBoxNomeP1.Text+"','"+checkBoxSmP1.Checked+"','"+checkBoxSfP1.Checked+"','"+comboBoxCiviP1.Text+"','"+dateTimePickerP1.Text+"','"+textBoxPaisP1.Text+"','"+checkBoxSimP1.Checked+"','"+textBoxIndP1.Text+"','"+comboBoxMateria1P1.Text+ "','" + comboBoxMateria2P1.Text + "','" + comboBoxMateria3P1.Text + "','" + comboBoxMateria4P1.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxNomeP1.Clear();
                textBoxPaisP1.Clear();
                textBoxIndP1.Clear();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de error caso não tenha conexão
        }

        private void TextBoxNomeP1_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void CheckBoxSmP1_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Masculino

        private void CheckBoxSfP1_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Feminino

        private void ComboBoxCiviP1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Estado Civil

        private void DateTimePickerP1_ValueChanged(object sender, EventArgs e)
        {

        }//Nascimento

        private void TextBoxPaisP1_TextChanged(object sender, EventArgs e)
        {

        }//Nacionalidade

        private void CheckBoxSimP1_CheckedChanged(object sender, EventArgs e)
        {

        }//Deficiência

        private void TextBoxIndP1_TextChanged(object sender, EventArgs e)
        {

        }//Indentificação

        private void ComboBoxMateriaP1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Materia

    }
}
