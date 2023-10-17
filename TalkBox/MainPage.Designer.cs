using System.Speech.Synthesis;
namespace TalkBox
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phrases_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.music_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.phrases1 = new TalkBox.Phrases();
            this.music1 = new TalkBox.Music();
            this.SuspendLayout();
            // 
            // phrases_button
            // 
            this.phrases_button.Location = new System.Drawing.Point(0, 0);
            this.phrases_button.Name = "phrases_button";
            this.phrases_button.Size = new System.Drawing.Size(400, 225);
            this.phrases_button.TabIndex = 0;
            this.phrases_button.Text = "Phrases";
            this.phrases_button.UseVisualStyleBackColor = true;
            this.phrases_button.Click += new System.EventHandler(this.phrases_Click);
            this.phrases_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 225);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sounds";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // music_button
            // 
            this.music_button.Location = new System.Drawing.Point(400, 0);
            this.music_button.Name = "music_button";
            this.music_button.Size = new System.Drawing.Size(400, 225);
            this.music_button.TabIndex = 3;
            this.music_button.Text = "Music";
            this.music_button.UseVisualStyleBackColor = true;
            this.music_button.Click += new System.EventHandler(this.musicButton_click);
            this.music_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 225);
            this.button4.TabIndex = 4;
            this.button4.Text = "Audiobooks";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // phrases1
            // 
            this.phrases1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.phrases1.Location = new System.Drawing.Point(0, 0);
            this.phrases1.Name = "phrases1";
            this.phrases1.Size = new System.Drawing.Size(800, 450);
            this.phrases1.TabIndex = 1;
            this.phrases1.Load += new System.EventHandler(this.phrases1_Load_1);
            // 
            // music1
            // 
            this.music1.Location = new System.Drawing.Point(0, 0);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(800, 450);
            this.music1.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.music1);
            this.Controls.Add(this.phrases1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.music_button);
            this.Controls.Add(this.phrases_button);
            this.Controls.Add(this.button2);
            this.Name = "MainPage";
            this.Text = "Talk Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button phrases_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button music_button;
        private System.Windows.Forms.Button button4;
        private Phrases phrases1;
        private Music music1;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        
    }
}

