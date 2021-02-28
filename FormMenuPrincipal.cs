using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormMenuPrincipal : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form currentChildForm;
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            subMenuAgendar.Visible = false;
            OpenChildForm(new FormCadastroDeAlunos());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            if (subMenuAgendar.Visible == false)
            {
                subMenuAgendar.Visible = true;
            }
            else
            {
                subMenuAgendar.Visible = false;
            }
        }

        private void buttonPratica_Click(object sender, EventArgs e)
        {

        }

        private void buttonDetran_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAgendar());
            subMenuAgendar.Visible = false;
        }

        private void panelDesktop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
