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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink1();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink1()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.islagaia.pt");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink2();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }
        private void VisitLink2()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.facebook.com/gustavo.falcao.73113");
        }
    }
}
