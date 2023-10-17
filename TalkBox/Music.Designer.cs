using System.Speech.Synthesis;
namespace TalkBox
{
    partial class Music
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back_Click);
            this.button2.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Song";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playMusic);
            this.button1.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(3, 50);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(109, 39);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.stop_Click);
            this.Stop.MouseEnter += new System.EventHandler(this.hoverSpeak);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Music";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Music_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Stop;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
    }
}
