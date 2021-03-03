using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new FormAbout());
            Application.Run(new FormAlunos());
            Application.Run(new FormAlunosAdd());
            Application.Run(new FormAlunosSearch());
            Application.Run(new FormAlunosDown());
            Application.Run(new FormAlunosMod());
            Application.Run(new FormAlunosMod1());
            Application.Run(new FormAlunosDel());
            Application.Run(new FormHome());
            Application.Run(new FormProfessor());
            Application.Run(new FormProfessorAdd());
            Application.Run(new FormProfessorSearch());
            Application.Run(new FormProfessorDown());
            Application.Run(new FormProfessorMod());
            Application.Run(new FormProfessorMod1());
            Application.Run(new FormProfessorDel());
        }
        private void ButtonCloseP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonBackP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
        private void ButtonHomeP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ButtonAddP_Click(object sender, EventArgs e)
        {
            Form f = new FormProfessorAdd();
            f.ShowDialog();
        }

        private void ButtonSeachP_Click(object sender, EventArgs e)
        {
            Form f = new FormProfessorSearch();
            f.ShowDialog();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SobreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f = new FormAbout();
            f.ShowDialog();
        }

        private void ButtonDowP_Click(object sender, EventArgs e)
        {
            Form f = new FormProfessorDown();
            f.ShowDialog();
        }

        private void ButtonModP_Click(object sender, EventArgs e)
        {
            Form f = new FormProfessorMod();
            f.ShowDialog();
        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAlunos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormProfessor();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ButtonDelP_Click(object sender, EventArgs e)
        {
            Form f = new FormProfessorDel();
            f.ShowDialog();
        }

        private void ButtonUpP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe professor, função desativada na versão de teste gratuita. Adiquira a versão completa para ter esta função");
        }
    }
}
