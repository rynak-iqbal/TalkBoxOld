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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
    }

        private void hoverSpeak(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            speech.Volume = 70;
            speech.SpeakAsync(s);
        }
        private void hoverLeave(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void phrases_Click(object sender, EventArgs e)
        {

            phrases1.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phrases1.Visible = false;
            music1.Visible = false;
            sounds1.Visible = false;
            audioBooks1.Visible = false;
        }

        private void phrases1_Load_1(object sender, EventArgs e)
        {

        }

        private void musicButton_click(object sender, EventArgs e)
        {
            music1.Visible = true;
        }
        private void musicPage_Load_1(object sender, EventArgs e)
        {

        }

        private void audioBooks_Click(object sender, EventArgs e)
        {
            audioBooks1.Visible = true;
        }

        private void sounds1_Load(object sender, EventArgs e)
        {

        }

        private void soundsButton_Click(object sender, EventArgs e)
        {
            sounds1.Visible = true;
        }

        private void audioBooks1_Load(object sender, EventArgs e)
        {

        }
    }
}
