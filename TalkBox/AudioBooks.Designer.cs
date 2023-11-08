using System.Speech.Synthesis;
namespace TalkBox
{
    partial class AudioBooks
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
            this.stop = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(3, 52);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(89, 41);
            this.stop.TabIndex = 0;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseLeave += new System.EventHandler(this.hoverLeave);
            this.stop.MouseHover += new System.EventHandler(this.hoverSpeak);
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(91, 99);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(296, 45);
            this.book.TabIndex = 1;
            this.book.Text = "Goldilocks";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            this.book.MouseLeave += new System.EventHandler(this.hoverLeave);
            this.book.MouseHover += new System.EventHandler(this.hoverSpeak);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 41);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseLeave += new System.EventHandler(this.hoverLeave);
            this.back.MouseHover += new System.EventHandler(this.hoverSpeak);
            // 
            // AudioBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stop);
            this.Controls.Add(this.book);
            this.Controls.Add(this.back);
            this.Name = "AudioBooks";
            this.Size = new System.Drawing.Size(464, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button back;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
    }
}
