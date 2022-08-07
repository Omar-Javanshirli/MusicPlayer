namespace MusicPlayer
{
    partial class Music
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
            this.musicPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.musicName = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SerialNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.songName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.musicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.musicPanel.Controls.Add(this.musicName);
            this.musicPanel.Controls.Add(this.number);
            this.musicPanel.Controls.Add(this.ıconPictureBox1);
            this.musicPanel.Controls.Add(this.guna2PictureBox1);
            this.musicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.musicPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.musicPanel.Location = new System.Drawing.Point(0, 0);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(526, 30);
            this.musicPanel.TabIndex = 0;
            // 
            // musicName
            // 
            this.musicName.AutoSize = true;
            this.musicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.musicName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicName.ForeColor = System.Drawing.Color.White;
            this.musicName.Location = new System.Drawing.Point(104, 7);
            this.musicName.Name = "musicName";
            this.musicName.Size = new System.Drawing.Size(69, 17);
            this.musicName.TabIndex = 16;
            this.musicName.Text = "Somg name";
            this.musicName.UseWaitCursor = true;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.number.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.ForeColor = System.Drawing.Color.White;
            this.number.Location = new System.Drawing.Point(54, 7);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(13, 17);
            this.number.TabIndex = 15;
            this.number.Text = "1";
            this.number.UseWaitCursor = true;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ıconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(14)))), ((int)(((byte)(2)))));
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(14)))), ((int)(((byte)(2)))));
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 23;
            this.ıconPictureBox1.Location = new System.Drawing.Point(441, 3);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(32, 23);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ıconPictureBox1.TabIndex = 1;
            this.ıconPictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 23);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.SerialNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SerialNumber.Location = new System.Drawing.Point(52, 7);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(9, 15);
            this.SerialNumber.TabIndex = 1;
            this.SerialNumber.Text = "1";
            // 
            // songName
            // 
            this.songName.BackColor = System.Drawing.Color.Transparent;
            this.songName.Location = new System.Drawing.Point(0, 0);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(3, 2);
            this.songName.TabIndex = 0;
            this.songName.Text = null;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.musicPanel);
            this.Name = "Music";
            this.Size = new System.Drawing.Size(526, 30);
            this.musicPanel.ResumeLayout(false);
            this.musicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel musicPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel SerialNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel songName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label musicName;
    }
}
