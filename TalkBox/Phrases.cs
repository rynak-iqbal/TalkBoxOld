using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TalkBox
{
    public partial class Phrases : UserControl
    {
        public Phrases()
        {
            InitializeComponent();
        }

        private void hello_Click(object sender, EventArgs e)
        {
            speech.Volume = 80;
            speech.SpeakAsync("Hello");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void hoverSpeak(object sender, EventArgs e)
        {
            speech.Volume = 70;
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
        }
        private void Phrases_Load(object sender, EventArgs e)
        {

        }
    }
}
