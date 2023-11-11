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
using Point = System.Drawing.Point;

namespace TalkBox
{
    public partial class Phrases : UserControl
    {

        public List<Button> categoryButtons = new List<Button>();


        public Phrases()
        {
            InitializeComponent();
            loadCategories();
            this.Load += Phrases_Load;

        }

        private void Phrases_Load(object sender, EventArgs e)
        {
            SubscribeToEnterEvent(this);
        }

        public void SubscribeToEnterEvent(Control container)
        {
            foreach (Control control in container.Controls)
            {
                control.Enter += Control_Enter;

                // If the control is a container, recursively subscribe to its child controls
                if (control.HasChildren)
                {
                    SubscribeToEnterEvent(control);
                }
            }
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            Console.WriteLine($"Tab index changed for: {((Control)sender).TabIndex}");

            Control btn = sender as Control;
            int index = btn.TabIndex;

            if (btn != null)
            {
                // Calculate the Y-coordinate to bring the control into view
                int newY = btn.Location.Y - AutoScrollPosition.Y;

                // Determine the maximum visible area
                int maxVisibleY = ClientSize.Height - btn.Height;

                // If the button is out of the max screen size, move all buttons up
                if (newY < 0 || newY > maxVisibleY)
                {
                    // Calculate adjustment value for button movement
                    int adjustment = newY < 0 ? -newY : maxVisibleY - newY;

                    // Move each button in the form by the adjustment value - simulate scroll
                    foreach (Control control in Controls)
                    {
                        control.Location = new Point(control.Location.X, control.Location.Y + adjustment);
                    }
                }
            }

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

        private void loadCategories()
        {
            string filePath = @"C:\TalkBox\Phrases.xlsx";


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            int tabIndex = 4;

            wb = excel.Workbooks.Open(filePath);

            ws = wb.Worksheets[1]; // get first index

            Console.WriteLine(Convert.ToString(ws.Cells[2, 1].Value));

            int rows = ws.UsedRange.Rows.Count;
            int btnHeight = 0;
            Console.WriteLine(rows);

            int btnNum = 0;

            for (int i = 2; i <= rows; i++)
            {
                String btnText = Convert.ToString(ws.Cells[i, 4].Value);
                if (!String.IsNullOrEmpty(btnText))
                {
                    String name = "btn" + btnNum;
                    Button btn = new Button();
                    this.SuspendLayout();

                    btn.Location = new Point(0, btnHeight);
                    btn.Name = name;
                    btn.Size = new Size(464, 35);
                    btn.TabIndex = tabIndex;
                    btn.Text = Convert.ToString(ws.Cells[i, 4].Value);
                    btn.UseVisualStyleBackColor = true;

                    btn.Click += new EventHandler(this.CatergoryClick);
                    btn.Enter += new EventHandler(this.hoverSpeak);
                    btn.Leave += new EventHandler(this.hoverLeave);

                    this.Controls.Add(btn);
                    btnHeight = btnHeight + 35;
                    tabIndex++;
                    btnNum++;


                    categoryButtons.Add(btn);
                }
            }
            


            //excel.Save();
            wb.Close(0);
            excel.Quit();
            Marshal.ReleaseComObject(excel);
        }



        // refocus index after returning from sub menu
        public void refocusIndex()
        {
            if (categoryButtons.Count > 0)
            {
                Button btn = categoryButtons[0];
                this.BringToFront();
                btn.Select();
                btn.Focus();
            }


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





 

        private void Phrases_Load_2(object sender, EventArgs e)
        {

        }
    }
}
