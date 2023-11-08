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

            phrases2.Visible = true;
            phrases2.Select();
            Control firstControlWithTabIndex = FindControlByTabIndex(phrases2, 6);
            if (firstControlWithTabIndex != null)
            {
                firstControlWithTabIndex.Focus();
            }
        }

        private Control FindControlByTabIndex(Control container, int tabIndex)
        {
            foreach (Control control in container.Controls)
            {
                if (control.TabIndex == tabIndex)
                {
                    return control;
                }
            }
            return null;
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

            Control c = null;
            switch (category)
            {
                case "General":
                    Console.WriteLine(category);
                    generalPhrases1.Visible = true;
                    c = generalPhrases1;
                    break;
                case "Family":
                    Console.WriteLine(category);
                    familyPhrases1.Visible = true;
                    c = familyPhrases1;
                    break;
                case "Feelings":
                    Console.WriteLine(category);
                    feelingsPhrases1.Visible = true;
                    c = feelingsPhrases1;
                    break;
                case "School":
                    Console.WriteLine(category);
                    schoolPhrases1.Visible = true;
                    c = schoolPhrases1;
                    break;
                case "Meal Times":
                    Console.WriteLine(category);
                    mealPhrases1.Visible = true;
                    c = mealPhrases1;
                    break;
                case "Outdoors":
                    Console.WriteLine(category);
                    outdoorsPhrases1.Visible = true;
                    c = outdoorsPhrases1;
                    break;
                case "Indoors":
                    Console.WriteLine(category);
                    indoorsPhrases1.Visible = true;
                    c = indoorsPhrases1;
                    break;
                case "Transportation":
                    Console.WriteLine(category);
                    transportationPhrases1.Visible = true;
                    c = transportationPhrases1;
                    break;
                default:
                    break;
            }
            c.Select();
            foreach (Control control in c.Controls)
            {
                if (control.TabIndex == 20)
                {
                    control.Focus();
                }
            }
        }

        private void musicButton_click(object sender, EventArgs e)
        {
            music1.Visible = true;
            music1.BringToFront();

            music1.Select();
            Control firstControlWithTabIndex = FindControlByTabIndex(music1, 1);
            if (firstControlWithTabIndex != null)
            {
                firstControlWithTabIndex.Focus();
            }

            phrases1.Visible = false;
            phrases2.Visible = false;
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
        private void musicPage_Load_1(object sender, EventArgs e)
        {

        }

        private void audioBooks_Click(object sender, EventArgs e)
        {
            audioBooks1.Visible = true;
            audioBooks1.BringToFront();

            audioBooks1.Select();
            Control firstControlWithTabIndex = FindControlByTabIndex(audioBooks1, 1);
            if (firstControlWithTabIndex != null)
            {
                firstControlWithTabIndex.Focus();
            }

            phrases1.Visible = false;
            phrases2.Visible = false;
            music1.Visible = false;
            sounds1.Visible = false;
            generalPhrases1.Visible = false;
            familyPhrases1.Visible = false;
            feelingsPhrases1.Visible = false;
            schoolPhrases1.Visible = false;
            mealPhrases1.Visible = false;
            outdoorsPhrases1.Visible = false;
            indoorsPhrases1.Visible = false;
            transportationPhrases1.Visible = false;
        }

        private void sounds1_Load(object sender, EventArgs e)
        {

        }

        private void soundsButton_Click(object sender, EventArgs e)
        {
            sounds1.Visible = true;
            sounds1.BringToFront();

            sounds1.Select();
            Control firstControlWithTabIndex = FindControlByTabIndex(sounds1, 1);
            if (firstControlWithTabIndex != null)
            {
                firstControlWithTabIndex.Focus();
            }

            phrases1.Visible = false;
            phrases2.Visible = false;
            music1.Visible = false;
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

        private void audioBooks1_Load(object sender, EventArgs e)
        {

        }

        private void FormClosed1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
