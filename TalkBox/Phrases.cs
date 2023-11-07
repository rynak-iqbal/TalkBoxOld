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
            Load += readExcel;

            //this.SetAutoScrollMargin(0, 2000);


        }
        private void backClick(object sender, EventArgs e)
        {
            this.Visible = false;
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
        }
        private void hoverLeave(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void CatergoryClick(object sender, EventArgs e)
        {
            
            if (sender is Button clickedButton)
            {

                string category = clickedButton.Name;
                Console.WriteLine(category);
                MainPage.OpenPhrasesSub(category, sender, e);

            }
        }

        private void readExcel(object sender, EventArgs e)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            //string fileName = "Phrases.xlsx";
            //string filePath = Path.Combine(Path.CurrentDirectory, @"Data\", fileName);
            string filePath = @"D:\TalkBox\Phrases.xlsx";

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            int tabIndex = 1;

            wb = excel.Workbooks.Open(filePath);

            ws = wb.Worksheets[1]; // get first index

            //Console.WriteLine(Convert.ToString(ws.Cells[2, 1].Value));

            int rows = ws.UsedRange.Rows.Count;
            int btnIntialHeight = 0;
            Console.WriteLine(rows);

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(ws.Cells[i, 4].Value) != null)
                {
                    Console.WriteLine(Convert.ToString(ws.Cells[i, 4].Value));
                    Button btn = new System.Windows.Forms.Button();
                    this.SuspendLayout();
                    btn.Location = new System.Drawing.Point(100, btnIntialHeight);
                    btn.Name = Convert.ToString(ws.Cells[i, 4].Value);
                    btn.Size = new System.Drawing.Size(296, 35);
                    btn.TabIndex = tabIndex;
                    btn.Text = Convert.ToString(ws.Cells[i, 4].Value);
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += (s, EventArgs) => { loadSubMenu(sender, EventArgs, btn.Name);  };
                    btn.MouseEnter += new System.EventHandler(this.hoverSpeak);
                    btn.MouseLeave += new System.EventHandler(this.hoverLeave);

                    this.Controls.Add(btn);
                    tabIndex++;
                    btnIntialHeight = btnIntialHeight + 35;
                }
            }
            //excel.Save();
            wb.Close(0);
            excel.Quit();
            Marshal.ReleaseComObject(excel);

        }
        private void loadSubMenu(object sender, EventArgs e, string category)
        {

            //phrasesSub1.Visible = true;
            //phrasesSub1.category = category;
            Console.WriteLine("Category: " + category);
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
    }
}
