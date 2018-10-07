using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace _004_Duration
{
    // Define the duration of a note in units of milliseconds.
    public enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
    }
    public struct Note
    {
        public string noteName;
        public Duration duration;
        public Note(string noteName, Duration duration)
        {
            this.noteName = noteName;
            this.duration = duration;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] wavArray = {
                "01C4","02Db4","03D4","04Eb4",
                "05E4","06F4","07Gb4","08G4",
                "09Ab4","10A4","11Bb4","12B4","13C5"
            };
            string[] noteName = {
                "C4", "Db4", "D4", "Eb4",
                "E4", "F4", "Gb4", "G4",
                "Ab4", "A4", "Bb4", "B4", "C5"
            };

            // Create note list
            List<SoundPlayer> noteList = new List<SoundPlayer>();
            foreach (string wa in wavArray)
                noteList.Add(new SoundPlayer("d:\\temp\\" + wa + ".wav"));

            // Create dic for all notes
            Dictionary<string, SoundPlayer> myDic = new Dictionary<string, SoundPlayer>();
            for (int i = 0; i <= wavArray.Length - 1; i++)
                myDic.Add(noteName[i], noteList[i]);

            // First few notes of the song, "Mary Had A Little Lamb".
            List<Note> mySong = new List<Note>();
            mySong.Add(new Note("B4", Duration.QUARTER));
            mySong.Add(new Note("A4", Duration.QUARTER));
            mySong.Add(new Note("G4", Duration.QUARTER));
            mySong.Add(new Note("A4", Duration.QUARTER));
            mySong.Add(new Note("B4", Duration.QUARTER));
            mySong.Add(new Note("B4", Duration.QUARTER));
            mySong.Add(new Note("B4", Duration.HALF));
            mySong.Add(new Note("A4", Duration.QUARTER));
            mySong.Add(new Note("A4", Duration.QUARTER));
            mySong.Add(new Note("A4", Duration.HALF));
            mySong.Add(new Note("B4", Duration.QUARTER));
            mySong.Add(new Note("D4", Duration.QUARTER));
            mySong.Add(new Note("D4", Duration.HALF));

            // Play song
            foreach (Note n in mySong)
            {
                SoundPlayer myPlayer = myDic[n.noteName];
                myPlayer.Play();
                System.Threading.Thread.Sleep(Convert.ToInt32(n.duration));
            }

        }
    }
}
