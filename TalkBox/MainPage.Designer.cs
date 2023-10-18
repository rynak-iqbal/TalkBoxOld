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
            this.sounds_button = new System.Windows.Forms.Button();
            this.music_button = new System.Windows.Forms.Button();
            this.audiobooks_button = new System.Windows.Forms.Button();
            this.audioBooks1 = new TalkBox.AudioBooks();
            this.sounds1 = new TalkBox.Sounds();
            this.music1 = new TalkBox.Music();
            this.phrases1 = new TalkBox.Phrases();
            this.SuspendLayout();
            // 
            // phrases_button
            // 
            this.phrases_button.Location = new System.Drawing.Point(0, 0);
            this.phrases_button.Name = "phrases_button";
            this.phrases_button.Size = new System.Drawing.Size(800, 112);
            this.phrases_button.TabIndex = 0;
            this.phrases_button.Text = "Phrases";
            this.phrases_button.UseVisualStyleBackColor = true;
            this.phrases_button.Click += new System.EventHandler(this.phrases_Click);
            this.phrases_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.phrases_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // sounds_button
            // 
            this.sounds_button.Location = new System.Drawing.Point(0, 225);
            this.sounds_button.Name = "sounds_button";
            this.sounds_button.Size = new System.Drawing.Size(800, 112);
            this.sounds_button.TabIndex = 2;
            this.sounds_button.Text = "Sounds";
            this.sounds_button.UseVisualStyleBackColor = true;
            this.sounds_button.Click += new System.EventHandler(this.soundsButton_Click);
            this.sounds_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.sounds_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // music_button
            // 
            this.music_button.Location = new System.Drawing.Point(0, 113);
            this.music_button.Name = "music_button";
            this.music_button.Size = new System.Drawing.Size(800, 112);
            this.music_button.TabIndex = 3;
            this.music_button.Text = "Music";
            this.music_button.UseVisualStyleBackColor = true;
            this.music_button.Click += new System.EventHandler(this.musicButton_click);
            this.music_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.music_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // audiobooks_button
            // 
            this.audiobooks_button.Location = new System.Drawing.Point(0, 338);
            this.audiobooks_button.Name = "audiobooks_button";
            this.audiobooks_button.Size = new System.Drawing.Size(800, 112);
            this.audiobooks_button.TabIndex = 4;
            this.audiobooks_button.Text = "Audiobooks";
            this.audiobooks_button.UseVisualStyleBackColor = true;
            this.audiobooks_button.Click += new System.EventHandler(this.audioBooks_Click);
            this.audiobooks_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.audiobooks_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // audioBooks1
            // 
            this.audioBooks1.Location = new System.Drawing.Point(0, 0);
            this.audioBooks1.Name = "audioBooks1";
            this.audioBooks1.Size = new System.Drawing.Size(800, 450);
            this.audioBooks1.TabIndex = 7;
            this.audioBooks1.Load += new System.EventHandler(this.audioBooks1_Load);
            // 
            // sounds1
            // 
            this.sounds1.Location = new System.Drawing.Point(0, 0);
            this.sounds1.Name = "sounds1";
            this.sounds1.Size = new System.Drawing.Size(800, 450);
            this.sounds1.TabIndex = 6;
            this.sounds1.Load += new System.EventHandler(this.sounds1_Load);
            // 
            // music1
            // 
            this.music1.Location = new System.Drawing.Point(0, 0);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(800, 450);
            this.music1.TabIndex = 5;
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.audioBooks1);
            this.Controls.Add(this.sounds1);
            this.Controls.Add(this.music1);
            this.Controls.Add(this.phrases1);
            this.Controls.Add(this.audiobooks_button);
            this.Controls.Add(this.music_button);
            this.Controls.Add(this.phrases_button);
            this.Controls.Add(this.sounds_button);
            this.Name = "MainPage";
            this.Text = "Talk Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button phrases_button;
        private System.Windows.Forms.Button sounds_button;
        private System.Windows.Forms.Button music_button;
        private System.Windows.Forms.Button audiobooks_button;
        private Phrases phrases1;
        private Music music1;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private Sounds sounds1;
        private AudioBooks audioBooks1;
    }
}

