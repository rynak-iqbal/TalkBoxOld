using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TalkBox
{
    partial class Phrases
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public bool backClicked = false;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.Button();
            this.Family = new System.Windows.Forms.Button();
            this.Feelings = new System.Windows.Forms.Button();
            this.School = new System.Windows.Forms.Button();
            this.MealTimes = new System.Windows.Forms.Button();
            this.Outdoors = new System.Windows.Forms.Button();
            this.Indoors = new System.Windows.Forms.Button();
            this.Transportation = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 41);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.backClick);
            this.back.Enter += new System.EventHandler(this.hoverSpeak);
            this.back.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // General
            // 
            this.General.Location = new System.Drawing.Point(100, 0);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(296, 35);
            this.General.TabIndex = 6;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.CatergoryClick);
            this.General.Enter += new System.EventHandler(this.hoverSpeak);
            this.General.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(100, 35);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(296, 35);
            this.Family.TabIndex = 7;
            this.Family.Text = "Family";
            this.Family.UseVisualStyleBackColor = true;
            this.Family.Click += new System.EventHandler(this.CatergoryClick);
            this.Family.Enter += new System.EventHandler(this.hoverSpeak);
            this.Family.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // Feelings
            // 
            this.Feelings.Location = new System.Drawing.Point(100, 70);
            this.Feelings.Name = "Feelings";
            this.Feelings.Size = new System.Drawing.Size(296, 35);
            this.Feelings.TabIndex = 8;
            this.Feelings.Text = "Feelings";
            this.Feelings.UseVisualStyleBackColor = true;
            this.Feelings.Click += new System.EventHandler(this.CatergoryClick);
            this.Feelings.Enter += new System.EventHandler(this.hoverSpeak);
            this.Feelings.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // School
            // 
            this.School.Location = new System.Drawing.Point(100, 105);
            this.School.Name = "School";
            this.School.Size = new System.Drawing.Size(296, 35);
            this.School.TabIndex = 9;
            this.School.Text = "School";
            this.School.UseVisualStyleBackColor = true;
            this.School.Click += new System.EventHandler(this.CatergoryClick);
            this.School.Enter += new System.EventHandler(this.hoverSpeak);
            this.School.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // MealTimes
            // 
            this.MealTimes.Location = new System.Drawing.Point(100, 140);
            this.MealTimes.Name = "MealTimes";
            this.MealTimes.Size = new System.Drawing.Size(296, 35);
            this.MealTimes.TabIndex = 10;
            this.MealTimes.Text = "Meal Times";
            this.MealTimes.UseVisualStyleBackColor = true;
            this.MealTimes.Click += new System.EventHandler(this.CatergoryClick);
            this.MealTimes.Enter += new System.EventHandler(this.hoverSpeak);
            this.MealTimes.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // Outdoors
            // 
            this.Outdoors.Location = new System.Drawing.Point(100, 175);
            this.Outdoors.Name = "Outdoors";
            this.Outdoors.Size = new System.Drawing.Size(296, 35);
            this.Outdoors.TabIndex = 11;
            this.Outdoors.Text = "Outdoors";
            this.Outdoors.UseVisualStyleBackColor = true;
            this.Outdoors.Click += new System.EventHandler(this.CatergoryClick);
            this.Outdoors.Enter += new System.EventHandler(this.hoverSpeak);
            this.Outdoors.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // Indoors
            // 
            this.Indoors.Location = new System.Drawing.Point(100, 210);
            this.Indoors.Name = "Indoors";
            this.Indoors.Size = new System.Drawing.Size(296, 35);
            this.Indoors.TabIndex = 12;
            this.Indoors.Text = "Indoors";
            this.Indoors.UseVisualStyleBackColor = true;
            this.Indoors.Click += new System.EventHandler(this.CatergoryClick);
            this.Indoors.Enter += new System.EventHandler(this.hoverSpeak);
            this.Indoors.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // Transportation
            // 
            this.Transportation.Location = new System.Drawing.Point(100, 245);
            this.Transportation.Name = "Transportation";
            this.Transportation.Size = new System.Drawing.Size(296, 35);
            this.Transportation.TabIndex = 13;
            this.Transportation.Text = "Transportation";
            this.Transportation.UseVisualStyleBackColor = true;
            this.Transportation.Click += new System.EventHandler(this.CatergoryClick);
            this.Transportation.Enter += new System.EventHandler(this.hoverSpeak);
            this.Transportation.Leave += new System.EventHandler(this.hoverLeave);
            // 
            // categories
            // 
            this.categories.Location = new System.Drawing.Point(0, 0);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(200, 100);
            this.categories.TabIndex = 0;
            this.categories.TabStop = false;
            // 
            // Phrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Transportation);
            this.Controls.Add(this.Indoors);
            this.Controls.Add(this.Outdoors);
            this.Controls.Add(this.MealTimes);
            this.Controls.Add(this.School);
            this.Controls.Add(this.Feelings);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.General);
            this.Controls.Add(this.back);
            this.Name = "Phrases";
            this.Size = new System.Drawing.Size(464, 281);
            this.ResumeLayout(false);

        }

        #endregion

        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private System.Windows.Forms.Button back;
        private Button Transportation;
        private Button Indoors;
        private Button Outdoors;
        private Button MealTimes;
        private Button School;
        private Button Feelings;
        private Button Family;
        private Button General;
        private GroupBox categories;
    }
}
