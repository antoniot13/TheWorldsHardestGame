using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektnaZadacaTheHardestGame
{
    public partial class StartForm : Form
    {
        
        Form formaLeveli;
        Form formaHowToPlay;
       
        bool soundFlag;
        public StartForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            soundFlag = true;
           
            //pictureBox4.Image = Properties.Resources.volume;
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formaLeveli = new Form1();
            formaLeveli.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formaHowToPlay = new HowToPlayForm();
            formaHowToPlay.Show();
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
          

        }


        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    
    }
}
