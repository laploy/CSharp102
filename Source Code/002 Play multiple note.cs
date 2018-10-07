using System;
using System.Media;
using System.Windows.Forms;

namespace _001_Play_multiple_note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\wav\\10A4.wav");
            player.Play();
            System.Threading.Thread.Sleep(800);
            player = new SoundPlayer("d:\\temp\\wav\\08G4.wav");
            player.Play();
            System.Threading.Thread.Sleep(400);
            player = new SoundPlayer("d:\\temp\\wav\\06F4.wav");
            player.Play();
            System.Threading.Thread.Sleep(800);
            player = new SoundPlayer("d:\\temp\\wav\\08G4.wav");
            player.Play();
            System.Threading.Thread.Sleep(600);
            player = new SoundPlayer("d:\\temp\\wav\\10A4.wav");
            player.Play();
            System.Threading.Thread.Sleep(600);
            player = new SoundPlayer("d:\\temp\\wav\\10A4.wav");
            player.Play();
            System.Threading.Thread.Sleep(600);
            player = new SoundPlayer("d:\\temp\\wav\\10A4.wav");
            player.Play();
            System.Threading.Thread.Sleep(600);
        }
    }
}
