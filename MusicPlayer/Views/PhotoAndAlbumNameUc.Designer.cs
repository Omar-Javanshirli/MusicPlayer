namespace MusicPlayer.Views
{
    partial class PhotoAndAlbumNameUc
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
            this.components = new System.ComponentModel.Container();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.prevBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.albumNameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.singerPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.singerNameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.guna2GradientPanel1.Controls.Add(this.prevBtn);
            this.guna2GradientPanel1.Controls.Add(this.nextBtn);
            this.guna2GradientPanel1.Controls.Add(this.albumNameLbl);
            this.guna2GradientPanel1.Controls.Add(this.singerPhoto);
            this.guna2GradientPanel1.Controls.Add(this.singerNameLbl);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(90)))), ((int)(((byte)(132)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(551, 154);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.prevBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.prevBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.prevBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.prevBtn.FillColor = System.Drawing.Color.Transparent;
            this.prevBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prevBtn.ForeColor = System.Drawing.Color.White;
            this.prevBtn.Image = global::MusicPlayer.Properties.Resources.icons8_prev_80;
            this.prevBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.prevBtn.Location = new System.Drawing.Point(0, 59);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(33, 32);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextBtn.FillColor = System.Drawing.Color.Transparent;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nextBtn.Image = global::MusicPlayer.Properties.Resources.icons8_right_button_80;
            this.nextBtn.ImageSize = new System.Drawing.Size(60, 60);
            this.nextBtn.Location = new System.Drawing.Point(515, 59);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(33, 34);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // albumNameLbl
            // 
            this.albumNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.albumNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.albumNameLbl.Location = new System.Drawing.Point(56, 84);
            this.albumNameLbl.Name = "albumNameLbl";
            this.albumNameLbl.Size = new System.Drawing.Size(91, 25);
            this.albumNameLbl.TabIndex = 3;
            this.albumNameLbl.Text = "Album name";
            // 
            // singerPhoto
            // 
            this.singerPhoto.Dock = System.Windows.Forms.DockStyle.Right;
            this.singerPhoto.ImageRotate = 0F;
            this.singerPhoto.Location = new System.Drawing.Point(355, 0);
            this.singerPhoto.Name = "singerPhoto";
            this.singerPhoto.Size = new System.Drawing.Size(196, 154);
            this.singerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.singerPhoto.TabIndex = 2;
            this.singerPhoto.TabStop = false;
            // 
            // singerNameLbl
            // 
            this.singerNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.singerNameLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singerNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.singerNameLbl.Location = new System.Drawing.Point(56, 59);
            this.singerNameLbl.Name = "singerNameLbl";
            this.singerNameLbl.Size = new System.Drawing.Size(111, 29);
            this.singerNameLbl.TabIndex = 1;
            this.singerNameLbl.Text = "Singer name";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.singerPhoto;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PhotoAndAlbumNameUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "PhotoAndAlbumNameUc";
            this.Size = new System.Drawing.Size(551, 154);
            this.Load += new System.EventHandler(this.PhotoAndAlbumNameUc_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.singerPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox singerPhoto;
        private Guna.UI2.WinForms.Guna2HtmlLabel singerNameLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel albumNameLbl;
        private Guna.UI2.WinForms.Guna2Button nextBtn;
        private Guna.UI2.WinForms.Guna2Button prevBtn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
    }
}
