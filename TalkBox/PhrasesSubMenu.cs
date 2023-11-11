using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Point = System.Drawing.Point;

namespace TalkBox
{
    public partial class PhrasesSubMenu : UserControl
    {
        String category;
        private Phrases phrasesPage = MainPage.phrases2;

        public PhrasesSubMenu(String category)
        {
            this.category = category;
            InitializeComponent();
            loadSub(category);
            this.Load += PhrasesSubMenu_Load;
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

        private void PhrasesSubMenu_Load(object sender, EventArgs e)
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

        private void clickSpeak(object sender, EventArgs e)
        {
            Console.WriteLine("clickSpeak");
            string s = (sender as Button).Text;
            speech.SpeakAsync(s);
        }

        private void back_Click(object sender, EventArgs e)
        {
            //backClicked = true;
            this.Visible = false;
            phrasesPage.refocusIndex();


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

        private void loadSub(String category)
        {
            string filePath = @"C:\TalkBox\Phrases.xlsx";

            int numButtons = 0;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            int tabIndex = 20;

            wb = excel.Workbooks.Open(filePath);

            ws = wb.Worksheets[1]; // get first index

            Console.WriteLine(Convert.ToString(ws.Cells[2, 1].Value));

            int rows = ws.UsedRange.Rows.Count;
            int btnHeight = 0;
            Console.WriteLine(rows);

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(ws.Cells[i, 2].Value) == category)
                {
                    Button btn = new Button();
                    this.SuspendLayout();

                    btn.Location = new Point(0, btnHeight);
                    btn.Name = Convert.ToString(ws.Cells[i, 1].Value);
                    btn.Size = new Size(464, 35);
                    btn.TabIndex = tabIndex;
                    btn.Text = Convert.ToString(ws.Cells[i, 1].Value);
                    btn.UseVisualStyleBackColor = true;

                    btn.Click += new EventHandler(this.clickSpeak);
                    btn.Enter += new EventHandler(this.hoverSpeak);
                    btn.Leave += new EventHandler(this.hoverLeave);

                    this.Controls.Add(btn);
                    btnHeight = btnHeight + 35;
                    tabIndex++;
                    numButtons++;
                }
                
            }

            Console.WriteLine("Number of Buttons: " + numButtons);
            if (numButtons == 0)
            {

                //Button add = new Button();
                //this.SuspendLayout();

                //add.Location = new Point(this.ClientSize.Width/2, this.ClientSize.Height/2);
                //add.Size = new Size(300, 200);
                //add.Name = "add";
                //add.Text = "Add to this category!";
                //add.UseVisualStyleBackColor = true;
                //add.TabIndex = 100;
                //add.Click += new EventHandler(this.addButton);

                //this.Controls.Add(add);

                //add.Focus();
                //add.Select();

                speech.SpeakAsync("This category is currently empty.");
            }

            //excel.Save();
            wb.Close(0);
            excel.Quit();
            Marshal.ReleaseComObject(excel);
        }

    }
}
