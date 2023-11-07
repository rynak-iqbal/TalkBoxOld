using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace TalkBox
{
    public partial class Music : UserControl
    {
        public Music()
        {
            InitializeComponent();
        }
        private void hoverSpeak(object sender, EventArgs e)
        {
            speech.Volume = 70;
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
        }
        private void hoverLeave(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }


        private void playMusic(object sender, EventArgs e)
        {
            //string fileName = "once-in-paris.wav";
            string filePath = @"C:\TalkBox\once-in-paris.wav";
            player.URL = filePath;
            player.settings.volume = 30;
            player.controls.play();
        }

        private void Music_Load(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void back_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Visible = false;
        }
    }
}
