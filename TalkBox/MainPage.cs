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
            this.FormClosed += new FormClosedEventHandler(FormClosed1);
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
            //phrases_button.TabIndex = 0;
            //sounds_button.TabIndex = 0;
            //music_button.TabIndex = 0;
            //audiobooks_button.TabIndex = 0;


            phrases2.Visible = true;
            //PhrasesMenu phrases = new PhrasesMenu();
            //phrases.Show();
            //this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phrases1.Visible = false;
            phrases2.Visible = false;
            music1.Visible = false;
            sounds1.Visible = false;
            audioBooks1.Visible = false;
            generalPhrases1.Visible = false;
            familyPhrases1.Visible = false;
            feelingsPhrases1.Visible = false;
            schoolPhrases1.Visible = false;
            mealPhrases1.Visible = false;
            outdoorsPhrases1.Visible = false;
            indoorsPhrases1.Visible = false;
            transportationPhrases1.Visible = false;


        }

        private void phrases1_Load_1(object sender, EventArgs e)
        {

        }

        public static void OpenPhrasesSub(string category, object sender, EventArgs e)
        {
            switch (category)
            {
                case "General":
                    Console.WriteLine(category);
                    generalPhrases1.Visible = true;
                    break;
                case "Family":
                    Console.WriteLine(category);
                    familyPhrases1.Visible = true;
                    break;
                case "Feelings":
                    Console.WriteLine(category);
                    feelingsPhrases1.Visible = true;
                    break;
                case "School":
                    Console.WriteLine(category);
                    schoolPhrases1.Visible = true;
                    break;
                case "Meal Times":
                    Console.WriteLine(category);
                    mealPhrases1.Visible = true;
                    break;
                case "Outdoors":
                    Console.WriteLine(category);
                    outdoorsPhrases1.Visible = true;
                    break;
                case "Indoors":
                    Console.WriteLine(category);
                    indoorsPhrases1.Visible = true;
                    break;
                case "Transportation":
                    Console.WriteLine(category);
                    transportationPhrases1.Visible = true;
                    break;
                default:
                    break;



            }


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

        private void FormClosed1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
