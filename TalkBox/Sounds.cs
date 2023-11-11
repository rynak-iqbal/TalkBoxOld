using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkBox
{
    public partial class Sounds : UserControl
    {
        public Sounds()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                back_Click(this, EventArgs.Empty);

            }
            return base.ProcessCmdKey(ref msg, keyData);
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


        private void playBirds(object sender, EventArgs e)
        {
            player.URL = @"C:\TalkBox\birds.mp3";
            player.settings.volume = 30;
            player.controls.play();
        }
        private void back_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Visible = false;
        }
        private void stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }
        private void Sounds_Load(object sender, EventArgs e)
        {

        }
    }
}
