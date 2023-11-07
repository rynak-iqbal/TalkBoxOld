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
    public partial class TransportationPhrases : UserControl
    {
        public TransportationPhrases()
        {
            InitializeComponent();
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



        private void loadTransportation()
        {
            string filePath = @"C:\TalkBox\Phrases.xlsx";

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            int tabIndex = 1;

            wb = excel.Workbooks.Open(filePath);

            ws = wb.Worksheets[1]; // get first index

            Console.WriteLine(Convert.ToString(ws.Cells[2, 1].Value));

            int rows = ws.UsedRange.Rows.Count;
            int btnHeight = 0;
            Console.WriteLine(rows);

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(ws.Cells[i, 2].Value) == "Transportation")
                {
                    Button btn = new System.Windows.Forms.Button();
                    this.SuspendLayout();

                    btn.Location = new System.Drawing.Point(200, btnHeight);
                    btn.Name = Convert.ToString(ws.Cells[i, 1].Value);
                    btn.Size = new System.Drawing.Size(296, 35);
                    btn.TabIndex = tabIndex;
                    btn.Text = Convert.ToString(ws.Cells[i, 1].Value);
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new System.EventHandler(this.clickSpeak);
                    btn.Enter += new System.EventHandler(this.hoverSpeak);
                    btn.Leave += new System.EventHandler(this.hoverLeave);

                    this.Controls.Add(btn);
                    btnHeight = btnHeight + 35;
                    tabIndex++;
                }
            }

            //excel.Save();
            wb.Close(0);
            excel.Quit();
            Marshal.ReleaseComObject(excel);

        }
    }
}
