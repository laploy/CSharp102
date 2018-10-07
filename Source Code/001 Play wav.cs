using System;
using System.Windows.Forms;
using System.Media;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonHello_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("d:\\temp\\wav\\01c4.wav");
            player.Play();
        }
    }
}
