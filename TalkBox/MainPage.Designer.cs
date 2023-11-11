﻿using System.Speech.Synthesis;
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

            phrases2 = new TalkBox.Phrases();
            this.audioBooks1 = new TalkBox.AudioBooks();
            this.sounds1 = new TalkBox.Sounds();
            this.music1 = new TalkBox.Music();
            this.SuspendLayout();
            // 
            // phrases_button
            // 
            this.phrases_button.Location = new System.Drawing.Point(0, 0);
            this.phrases_button.Name = "phrases_button";
            this.phrases_button.Size = new System.Drawing.Size(464, 70);
            this.phrases_button.TabIndex = 0;
            this.phrases_button.Text = "Phrases";
            this.phrases_button.UseVisualStyleBackColor = true;
            this.phrases_button.Click += new System.EventHandler(this.phrases_Click);
            this.phrases_button.Enter += new System.EventHandler(this.hoverSpeak);
            this.phrases_button.Leave += new System.EventHandler(this.hoverLeave);
            this.phrases_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.phrases_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // sounds_button
            // 
            this.sounds_button.Location = new System.Drawing.Point(0, 70);
            this.sounds_button.Name = "sounds_button";
            this.sounds_button.Size = new System.Drawing.Size(464, 70);
            this.sounds_button.TabIndex = 1;
            this.sounds_button.Text = "Sounds";
            this.sounds_button.UseVisualStyleBackColor = true;
            this.sounds_button.Click += new System.EventHandler(this.soundsButton_Click);
            this.sounds_button.Enter += new System.EventHandler(this.hoverSpeak);
            this.sounds_button.Leave += new System.EventHandler(this.hoverLeave);
            this.sounds_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.sounds_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // music_button
            // 
            this.music_button.Location = new System.Drawing.Point(0, 140);
            this.music_button.Name = "music_button";
            this.music_button.Size = new System.Drawing.Size(464, 70);
            this.music_button.TabIndex = 2;
            this.music_button.Text = "Music";
            this.music_button.UseVisualStyleBackColor = true;
            this.music_button.Click += new System.EventHandler(this.musicButton_click);
            this.music_button.Enter += new System.EventHandler(this.hoverSpeak);
            this.music_button.Leave += new System.EventHandler(this.hoverLeave);
            this.music_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.music_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // audiobooks_button
            // 
            this.audiobooks_button.Location = new System.Drawing.Point(0, 210);
            this.audiobooks_button.Name = "audiobooks_button";
            this.audiobooks_button.Size = new System.Drawing.Size(464, 70);
            this.audiobooks_button.TabIndex = 3;
            this.audiobooks_button.Text = "Audiobooks";
            this.audiobooks_button.UseVisualStyleBackColor = true;
            this.audiobooks_button.Click += new System.EventHandler(this.audioBooks_Click);
            this.audiobooks_button.Enter += new System.EventHandler(this.hoverSpeak);
            this.audiobooks_button.Leave += new System.EventHandler(this.hoverLeave);
            this.audiobooks_button.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.audiobooks_button.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // phrases2
            // 
            phrases2.Location = new System.Drawing.Point(0, -1);
            phrases2.Name = "phrases2";
            phrases2.Size = new System.Drawing.Size(464, 281);
            phrases2.TabIndex = 8;
            // 
            // audioBooks1
            // 
            this.audioBooks1.Location = new System.Drawing.Point(0, 0);
            this.audioBooks1.Name = "audioBooks1";
            this.audioBooks1.Size = new System.Drawing.Size(464, 280);
            this.audioBooks1.TabIndex = 9;
            this.audioBooks1.Load += new System.EventHandler(this.audioBooks1_Load);
            // 
            // sounds1
            // 
            this.sounds1.Location = new System.Drawing.Point(0, 0);
            this.sounds1.Name = "sounds1";
            this.sounds1.Size = new System.Drawing.Size(464, 280);
            this.sounds1.TabIndex = 10;
            this.sounds1.Load += new System.EventHandler(this.sounds1_Load);
            // 
            // music1
            // 
            this.music1.AutoScroll = true;
            this.music1.Location = new System.Drawing.Point(0, 0);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(464, 280);
            this.music1.TabIndex = 11;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(phrases2);
            this.Controls.Add(this.audioBooks1);
            this.Controls.Add(this.audiobooks_button);
            this.Controls.Add(this.music_button);
            this.Controls.Add(this.phrases_button);
            this.Controls.Add(this.sounds_button);
            this.Controls.Add(this.sounds1);
            this.Controls.Add(this.music1);
            this.KeyPreview = true;
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
        private Music music1;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private Sounds sounds1;
        private AudioBooks audioBooks1;
        public static Phrases phrases2;
    }
}

