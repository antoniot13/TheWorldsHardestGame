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
    public partial class HowToPlayForm : Form
    {
        Form startForma;
        Form formaLevel;
        public HowToPlayForm()
        {
            InitializeComponent();
        }

        private void HowToPlayForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            FontFamily fontFamily = new FontFamily("Segoe Print");
            Font font = new Font(
               fontFamily,
               20,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            String s = "You are the      square. Avoid the       circles and move to \n the         beacon" +
            " to complete the level. You must complete \n 3 levels in order to finish the game. Your score is reflection \n of how " +
            "many times you have died; the less, the better. \n";
            s += " You move the square with W, A, D, S keys.";
            g.DrawString(s, font, new SolidBrush(Color.Black), 10, 10);
            g.DrawString("red", font, new SolidBrush(Color.Red), 134, 10);
            g.DrawString("blue", font, new SolidBrush(Color.Blue), 358, 10);
            g.DrawString("green", font, new SolidBrush(Color.Green), 58, 45);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startForma = new StartForm();
            startForma.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formaLevel = new Form1();
            formaLevel.Show();
            this.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void HowToPlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
