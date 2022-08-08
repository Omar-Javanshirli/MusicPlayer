namespace MusicPlayer.Views
{
    partial class SingerNameAndSongNameUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songNameLbl = new System.Windows.Forms.Label();
            this.singerNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songNameLbl
            // 
            this.songNameLbl.AutoSize = true;
            this.songNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.songNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.songNameLbl.Location = new System.Drawing.Point(3, 17);
            this.songNameLbl.Name = "songNameLbl";
            this.songNameLbl.Size = new System.Drawing.Size(76, 17);
            this.songNameLbl.TabIndex = 24;
            this.songNameLbl.Text = "Music Name";
            this.songNameLbl.UseWaitCursor = true;
            // 
            // singerNameLbl
            // 
            this.singerNameLbl.AutoSize = true;
            this.singerNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.singerNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singerNameLbl.ForeColor = System.Drawing.Color.White;
            this.singerNameLbl.Location = new System.Drawing.Point(-3, 0);
            this.singerNameLbl.Name = "singerNameLbl";
            this.singerNameLbl.Size = new System.Drawing.Size(80, 17);
            this.singerNameLbl.TabIndex = 23;
            this.singerNameLbl.Text = "Singer Name";
            this.singerNameLbl.UseWaitCursor = true;
            // 
            // SingerNameAndSongNameUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.songNameLbl);
            this.Controls.Add(this.singerNameLbl);
            this.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Name = "SingerNameAndSongNameUc";
            this.Size = new System.Drawing.Size(277, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label songNameLbl;
        private System.Windows.Forms.Label singerNameLbl;
    }
}
