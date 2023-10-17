using System.Speech.Synthesis;
namespace TalkBox
{
    partial class Sounds
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

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
            this.birds = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(109, 41);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.back.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // birds
            // 
            this.birds.Location = new System.Drawing.Point(207, 170);
            this.birds.Name = "birds";
            this.birds.Size = new System.Drawing.Size(385, 82);
            this.birds.TabIndex = 4;
            this.birds.Text = "Birds";
            this.birds.UseVisualStyleBackColor = true;
            this.birds.Click += new System.EventHandler(this.playBirds);
            this.birds.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.birds.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(3, 50);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(109, 41);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseEnter += new System.EventHandler(this.hoverSpeak);
            this.stop.MouseLeave += new System.EventHandler(this.hoverLeave);
            // 
            // Sounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stop);
            this.Controls.Add(this.birds);
            this.Controls.Add(this.back);
            this.Name = "Sounds";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Sounds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button birds;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private System.Windows.Forms.Button stop;
    }
}
