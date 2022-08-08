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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.songNameLbl = new System.Windows.Forms.Label();
            this.singerNameLbl = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.songNameLbl);
            this.guna2GradientPanel1.Controls.Add(this.singerNameLbl);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(72, 34);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // songNameLbl
            // 
            this.songNameLbl.AutoSize = true;
            this.songNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.songNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.songNameLbl.Location = new System.Drawing.Point(-3, 17);
            this.songNameLbl.Name = "songNameLbl";
            this.songNameLbl.Size = new System.Drawing.Size(76, 17);
            this.songNameLbl.TabIndex = 20;
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
            this.singerNameLbl.TabIndex = 19;
            this.singerNameLbl.Text = "Singer Name";
            this.singerNameLbl.UseWaitCursor = true;
            // 
            // SingerNameAndSongNameUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "SingerNameAndSongNameUc";
            this.Size = new System.Drawing.Size(72, 34);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label songNameLbl;
        private System.Windows.Forms.Label singerNameLbl;
    }
}
