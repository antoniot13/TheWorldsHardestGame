using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektnaZadacaTheHardestGame
{
    public partial class EndFormcs : Form
    {
        Form formaLevel;
        public int Deaths { get; set; }
        public EndFormcs(int deaths)
        {
            Deaths = deaths;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formaLevel = new Form1();
            this.Hide();
            formaLevel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void EndFormcs_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            FontFamily fontFamily = new FontFamily("Segoe Print");
            Font font = new Font(
               fontFamily,
               20,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            String s = "You finished the game with " + Deaths + " deaths.\nClick                   to improve your score!";
            g.DrawString(s, font, new SolidBrush(Color.Black), 40, 50);
            g.DrawString("PLAY AGAIN", font, new SolidBrush(Color.Red), 95, 85);

        }
    }
}
