using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void playMusic(object sender, EventArgs e)
        {
            player.URL = @"D:\TalkBox\once-in-paris.wav";
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
            this.Visible = false;
        }
    }
}
