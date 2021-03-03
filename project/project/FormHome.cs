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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

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
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAlunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAlunos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ButtonProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormProfessor();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAbout();
            f.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormHome();
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

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormAlunos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
