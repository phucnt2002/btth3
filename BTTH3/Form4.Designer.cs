namespace BTTH3
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.picLove = new System.Windows.Forms.PictureBox();
            this.pb_str5 = new System.Windows.Forms.PictureBox();
            this.pb_str4 = new System.Windows.Forms.PictureBox();
            this.pb_str3 = new System.Windows.Forms.PictureBox();
            this.pb_str2 = new System.Windows.Forms.PictureBox();
            this.pb_str1 = new System.Windows.Forms.PictureBox();
            this.labType = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picSong = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLyric = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_core = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ActiveImage = null;
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowBuffering = false;
            this.btnExit.AllowToggling = false;
            this.btnExit.AllowZooming = true;
            this.btnExit.AllowZoomingOnFocus = false;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImage")));
            this.btnExit.FadeWhenInactive = false;
            this.btnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.ImageLocation = null;
            this.btnExit.ImageMargin = 20;
            this.btnExit.ImageSize = new System.Drawing.Size(36, 42);
            this.btnExit.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExit.InitialImage")));
            this.btnExit.Location = new System.Drawing.Point(1224, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0;
            this.btnExit.ShowActiveImage = true;
            this.btnExit.ShowCursorChanges = true;
            this.btnExit.ShowImageBorders = true;
            this.btnExit.ShowSizeMarkers = false;
            this.btnExit.Size = new System.Drawing.Size(56, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.ToolTipText = "";
            this.btnExit.WaitOnLoad = false;
            this.btnExit.Zoom = 20;
            this.btnExit.ZoomSpeed = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_core);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.wplayer);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.picLove);
            this.panel2.Controls.Add(this.pb_str5);
            this.panel2.Controls.Add(this.pb_str4);
            this.panel2.Controls.Add(this.pb_str3);
            this.panel2.Controls.Add(this.pb_str2);
            this.panel2.Controls.Add(this.pb_str1);
            this.panel2.Controls.Add(this.labType);
            this.panel2.Controls.Add(this.labAuthor);
            this.panel2.Controls.Add(this.labName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picSong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 720);
            this.panel2.TabIndex = 6;
            // 
            // wplayer
            // 
            this.wplayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(0, 674);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(1280, 46);
            this.wplayer.TabIndex = 26;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(36, 42);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1224, -1);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 62);
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // picLove
            // 
            this.picLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLove.BackgroundImage")));
            this.picLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLove.Location = new System.Drawing.Point(460, 513);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(40, 40);
            this.picLove.TabIndex = 24;
            this.picLove.TabStop = false;
            this.picLove.Click += new System.EventHandler(this.picLove_Click);
            // 
            // pb_str5
            // 
            this.pb_str5.BackColor = System.Drawing.Color.Transparent;
            this.pb_str5.Image = ((System.Drawing.Image)(resources.GetObject("pb_str5.Image")));
            this.pb_str5.Location = new System.Drawing.Point(304, 523);
            this.pb_str5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_str5.Name = "pb_str5";
            this.pb_str5.Size = new System.Drawing.Size(30, 30);
            this.pb_str5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_str5.TabIndex = 23;
            this.pb_str5.TabStop = false;
            this.pb_str5.Click += new System.EventHandler(this.pb_str5_Click);
            // 
            // pb_str4
            // 
            this.pb_str4.BackColor = System.Drawing.Color.Transparent;
            this.pb_str4.Image = ((System.Drawing.Image)(resources.GetObject("pb_str4.Image")));
            this.pb_str4.Location = new System.Drawing.Point(246, 523);
            this.pb_str4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_str4.Name = "pb_str4";
            this.pb_str4.Size = new System.Drawing.Size(30, 30);
            this.pb_str4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_str4.TabIndex = 22;
            this.pb_str4.TabStop = false;
            this.pb_str4.Click += new System.EventHandler(this.pb_str4_Click);
            // 
            // pb_str3
            // 
            this.pb_str3.BackColor = System.Drawing.Color.Transparent;
            this.pb_str3.Image = ((System.Drawing.Image)(resources.GetObject("pb_str3.Image")));
            this.pb_str3.Location = new System.Drawing.Point(192, 523);
            this.pb_str3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_str3.Name = "pb_str3";
            this.pb_str3.Size = new System.Drawing.Size(30, 30);
            this.pb_str3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_str3.TabIndex = 21;
            this.pb_str3.TabStop = false;
            this.pb_str3.Click += new System.EventHandler(this.pb_str3_Click);
            // 
            // pb_str2
            // 
            this.pb_str2.BackColor = System.Drawing.Color.Transparent;
            this.pb_str2.Image = ((System.Drawing.Image)(resources.GetObject("pb_str2.Image")));
            this.pb_str2.Location = new System.Drawing.Point(137, 523);
            this.pb_str2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_str2.Name = "pb_str2";
            this.pb_str2.Size = new System.Drawing.Size(30, 30);
            this.pb_str2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_str2.TabIndex = 20;
            this.pb_str2.TabStop = false;
            this.pb_str2.Click += new System.EventHandler(this.pb_str2_Click);
            // 
            // pb_str1
            // 
            this.pb_str1.BackColor = System.Drawing.Color.Transparent;
            this.pb_str1.Image = ((System.Drawing.Image)(resources.GetObject("pb_str1.Image")));
            this.pb_str1.Location = new System.Drawing.Point(82, 523);
            this.pb_str1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_str1.Name = "pb_str1";
            this.pb_str1.Size = new System.Drawing.Size(30, 30);
            this.pb_str1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_str1.TabIndex = 19;
            this.pb_str1.TabStop = false;
            this.pb_str1.Click += new System.EventHandler(this.pb_str1_Click);
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(724, 254);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(135, 59);
            this.labType.TabIndex = 6;
            this.labType.Text = "name";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthor.Location = new System.Drawing.Point(724, 154);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(135, 59);
            this.labAuthor.TabIndex = 5;
            this.labAuthor.Text = "name";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(724, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(135, 59);
            this.labName.TabIndex = 4;
            this.labName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ca sĩ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bài hát: ";
            // 
            // picSong
            // 
            this.picSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSong.Location = new System.Drawing.Point(21, 22);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(470, 470);
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLyric
            // 
            this.txtLyric.AutoSize = true;
            this.txtLyric.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyric.Location = new System.Drawing.Point(3, 0);
            this.txtLyric.Name = "txtLyric";
            this.txtLyric.Size = new System.Drawing.Size(69, 24);
            this.txtLyric.TabIndex = 27;
            this.txtLyric.Text = "txtLyric";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtLyric);
            this.panel1.Location = new System.Drawing.Point(551, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 217);
            this.panel1.TabIndex = 28;
            // 
            // lbl_core
            // 
            this.lbl_core.AutoSize = true;
            this.lbl_core.BackColor = System.Drawing.Color.Transparent;
            this.lbl_core.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core.ForeColor = System.Drawing.Color.Red;
            this.lbl_core.Location = new System.Drawing.Point(383, 524);
            this.lbl_core.Name = "lbl_core";
            this.lbl_core.Size = new System.Drawing.Size(25, 29);
            this.lbl_core.TabIndex = 28;
            this.lbl_core.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSong;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.PictureBox pb_str5;
        private System.Windows.Forms.PictureBox pb_str4;
        private System.Windows.Forms.PictureBox pb_str3;
        private System.Windows.Forms.PictureBox pb_str2;
        private System.Windows.Forms.PictureBox pb_str1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wplayer;
        private System.Windows.Forms.Label txtLyric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_core;
    }
}