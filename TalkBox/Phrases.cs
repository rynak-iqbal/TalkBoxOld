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
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using Button = System.Windows.Forms.Button;
using System.IO;
using System.Reflection;

namespace TalkBox
{
    public partial class Phrases : UserControl
    {

        public Phrases()
        {
            InitializeComponent();


        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    this.back_Click(this, EventArgs.Empty);
                    return true;
                case Keys.Right:
                    Console.WriteLine("Select");
                    Control focusedControl = this.ActiveControl;
                    (focusedControl as Button).PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        // refocus index after returning from sub menu
        public void refocusIndex()
        {
            this.BringToFront();
            btn1.Select();
            btn1.Focus();

        }


        private void clickSpeak(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
        }

        private void back_Click(object sender, EventArgs e)
        {
            //backClicked = true;
            this.Visible = false;
        }

        private void hoverSpeak(object sender, EventArgs e)
        {
            speech.Volume = 70;
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
            Console.WriteLine(s);
        }
        private void hoverLeave(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void CatergoryClick(object sender, EventArgs e)
        {
            
            if (sender is Button clickedButton)
            {

                string category = clickedButton.Text;
                Console.WriteLine(category);
                MainPage.OpenPhrasesSub(category, this.ParentForm);

            }
        }    

        private void Phrases_Load(object sender, EventArgs e)
        {
            
        }

        private void Phrases_Load_1(object sender, EventArgs e)
        {
            //phrasesSub1.Visible = false;
        }

        private void phrasesSub1_Load(object sender, EventArgs e)
        {

        }

        private void Phrases_Load_2(object sender, EventArgs e)
        {

        }
    }
}
