namespace MusicPlayer.Views
{
    partial class SingerUc
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.singerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.singerPhotoPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.songName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singerPhotoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.guna2GradientPanel1.Controls.Add(this.songName);
            this.guna2GradientPanel1.Controls.Add(this.singerName);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(165, 182);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // singerName
            // 
            this.singerName.BackColor = System.Drawing.Color.Transparent;
            this.singerName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singerName.ForeColor = System.Drawing.Color.White;
            this.singerName.Location = new System.Drawing.Point(3, 143);
            this.singerName.Name = "singerName";
            this.singerName.Size = new System.Drawing.Size(71, 19);
            this.singerName.TabIndex = 18;
            this.singerName.Text = "Singer name";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.singerPhotoPb);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(159, 134);
            this.guna2GradientPanel2.TabIndex = 17;
            // 
            // singerPhotoPb
            // 
            this.singerPhotoPb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singerPhotoPb.ImageRotate = 0F;
            this.singerPhotoPb.Location = new System.Drawing.Point(0, 0);
            this.singerPhotoPb.Name = "singerPhotoPb";
            this.singerPhotoPb.Size = new System.Drawing.Size(159, 134);
            this.singerPhotoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.singerPhotoPb.TabIndex = 14;
            this.singerPhotoPb.TabStop = false;
            // 
            // songName
            // 
            this.songName.BackColor = System.Drawing.Color.Transparent;
            this.songName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songName.ForeColor = System.Drawing.Color.White;
            this.songName.Location = new System.Drawing.Point(3, 160);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(29, 19);
            this.songName.TabIndex = 19;
            this.songName.Text = "Song";
            // 
            // SingerUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "SingerUc";
            this.Size = new System.Drawing.Size(165, 182);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.singerPhotoPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox singerPhotoPb;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel singerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel songName;
    }
}
