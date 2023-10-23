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

namespace TalkBox
{
    public partial class Phrases : UserControl
    {
        public Phrases()
        {
            InitializeComponent();
            Load+=readExcel;

            this.SetAutoScrollMargin(0, 2000);

        }

        private void clickSpeak(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
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
        private void hoverLeave(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
        }

        private void readExcel(object sender, EventArgs e)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            string fileName = "Phrases.xlsx";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);

            ws = wb.Worksheets[1]; // get first index

            Console.WriteLine(Convert.ToString(ws.Cells[2, 1].Value));

            int rows = ws.UsedRange.Rows.Count;
            int btnIntialHeight = -50;
            Console.WriteLine(rows);

            for (int i = 2; i <= rows; i++)
            {
                Button btn = new System.Windows.Forms.Button();
                this.SuspendLayout();
                btnIntialHeight = btnIntialHeight + 100;

                btn.Location = new System.Drawing.Point(200, btnIntialHeight);
                btn.Name = Convert.ToString(ws.Cells[i, 1].Value);
                btn.Size = new System.Drawing.Size(385, 82);
                btn.TabIndex = 0;
                btn.Text = Convert.ToString(ws.Cells[i, 1].Value);
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(this.clickSpeak);
                btn.MouseEnter += new System.EventHandler(this.hoverSpeak);
                btn.MouseLeave += new System.EventHandler(this.hoverLeave);

                this.Controls.Add(btn);
            }
        
        }

        private void Phrases_Load(object sender, EventArgs e)
        {

        }

        private void Phrases_Load_1(object sender, EventArgs e)
        {

        }
    }
}
