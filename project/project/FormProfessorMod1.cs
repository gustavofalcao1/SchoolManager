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
    public partial class FormProfessorMod1 : Form
    {
        public FormProfessorMod1()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormHome());
            Application.Run(new FormProfessor());
        }//Chamada das forms que irei usar neste script

        private void ButtonBackP3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormProfessor();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para botão voltar, voltar para form Professor

        private void ButtonHomeP3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }//Comando para o botão Home voltar para form Home

        private void ButtonCloseP3_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Comando para o botao fechar a form

        public string ID;
        public void ButtonModP3_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GestorEscolar\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Professor set Nome ='" + textBoxNomeP3.Text + "',";
                SQL += "EstCivil = '" + comboBoxCiviP3.Text + "',";
                SQL += "Nascimento = '" + dateTimePickerP3.Text + "',";
                SQL += "Nacionalidade = '" + textBoxPaisP3.Text + "',";
                SQL += "Indentificação = '" + textBoxIndP3.Text + "',";
                SQL += "Materia1 = '" + comboBoxMateria1P3.Text + "',";
                SQL += "Materia2 = '" + comboBoxMateria2P3.Text + "',";
                SQL += "Materia3 = '" + comboBoxMateria3P3.Text + "',";
                SQL += "Materia4 = '" + comboBoxMateria4P3.Text + "' ";
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

        private void TextBoxNomeP3_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void CheckBoxSmP3_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Masculino

        private void CheckBoxSfP3_CheckedChanged(object sender, EventArgs e)
        {

        }//Sexo.Feminino

        private void ComboBoxCiviP3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Estado Civil

        private void DateTimePickerP3_ValueChanged(object sender, EventArgs e)
        {

        }//Nascimento

        private void TextBoxPaisP3_TextChanged(object sender, EventArgs e)
        {

        }//Nacionalidade

        private void CheckBoxSimP3_CheckedChanged(object sender, EventArgs e)
        {

        }//Deficiência

        private void TextBoxIndP3_TextChanged(object sender, EventArgs e)
        {

        }//Indentificação

        private void ComboBoxCursoP3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//Curso

    }
}
