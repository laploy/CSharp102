using System;
using System.Media;
using System.Windows.Forms;

namespace _005_Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\01C4.wav");
            player.Play();
        }
        private void buttonDb_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\02Db4.wav");
            player.Play();
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\03D4.wav");
            player.Play();
        }
        private void buttonEb_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\04Eb4.wav");
            player.Play();
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\05E4.wav");
            player.Play();
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\06F4.wav");
            player.Play();
        }
        private void buttonGb_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\07Gb4.wav");
            player.Play();
        }
        private void buttonG_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\08G4.wav");
            player.Play();
        }
        private void buttonAb_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\09Ab4.wav");
            player.Play();
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\10A4.wav");
            player.Play();
        }
        private void buttonBb_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\11Bb4.wav");
            player.Play();
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\12B4.wav");
            player.Play();
        }
        private void buttonC5_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\13C5.wav");
            player.Play();
        }
    }
}
