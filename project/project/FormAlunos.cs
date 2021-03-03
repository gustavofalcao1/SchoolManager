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
    public partial class FormAlunos : Form
    {
        public FormAlunos()
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

        private void ButtonCloseA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBackA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
        private void ButtonHomeA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ButtonAddA_Click(object sender, EventArgs e)
        {
            Form f = new FormAlunosAdd();
            f.ShowDialog();
        }

        private void ButtonSeachA_Click(object sender, EventArgs e)
        {
            Form f = new FormAlunosSearch();
            f.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAbout();
            f.ShowDialog();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ButtonDowA_Click(object sender, EventArgs e)
        {
            Form f = new FormAlunosDown();
            f.ShowDialog();
        }

        private void ButtonModA_Click(object sender, EventArgs e)
        {
            Form f = new FormAlunosMod();
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

        private void ButtonDelA_Click(object sender, EventArgs e)
        {
            Form f = new FormAlunosDel();
            f.ShowDialog();
        }

        private void ButtonUpA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe professor, função desativada na versão de teste gratuita. Adiquira a versão completa para ter esta função");
        }
    }
}
