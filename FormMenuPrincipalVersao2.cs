using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp4 {
    public partial class FormMenuPrincipalVersao2 : Form {
        public FormMenuPrincipalVersao2() {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButton1_Click(object sender, EventArgs e) {

        }

        private void iconButton4_Click(object sender, EventArgs e) {

        }

        private void iconButton8_Click(object sender, EventArgs e) {

        }

        private void iconButton2_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void iconButton9_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {
                    }

        private void FormMenuPrincipalVersao2_Load(object sender, EventArgs e) {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton7_Click(object sender, EventArgs e) {

        }

        private void iconButton1_Click_1(object sender, EventArgs e) {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void iconButton6_Click(object sender, EventArgs e) {

        }

        private void iconButton5_Click(object sender, EventArgs e) {

        }

        private void iconButton3_Click(object sender, EventArgs e) {

        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }
    }
}
