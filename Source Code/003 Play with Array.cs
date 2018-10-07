using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _003_Play_with_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // play chromatic scale 
            // use array and List to shorten code
            string[] wavArray = {
                "01C4","02Db4","03D4","04Eb4",
                "05E4","06F4","07Gb4","08G4",
                "09Ab4","10A4","11Bb4","12B4","13C5"
            };
            List<SoundPlayer> playList = new List<SoundPlayer>();
            // Create play list
            foreach (string wa in wavArray)
                playList.Add(new SoundPlayer("d:\\temp\\" + wa + ".wav"));
            // Play play list
            foreach (SoundPlayer pl in playList)
                pl.PlaySync();
        }
    }
}
