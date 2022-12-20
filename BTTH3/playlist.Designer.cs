namespace BTTH3
{
    partial class playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.picPlaylist = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.labName = new System.Windows.Forms.Label();
            this.bunifuIconButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuIconButton1);
            this.bunifuGradientPanel1.Controls.Add(this.picPlaylist);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.labName);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(338, 333);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.bunifuGradientPanel1_Click);
            // 
            // picPlaylist
            // 
            this.picPlaylist.AllowFocused = false;
            this.picPlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlaylist.AutoSizeHeight = true;
            this.picPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlaylist.BorderRadius = 0;
            this.picPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("picPlaylist.Image")));
            this.picPlaylist.IsCircle = false;
            this.picPlaylist.Location = new System.Drawing.Point(48, 16);
            this.picPlaylist.Name = "picPlaylist";
            this.picPlaylist.Size = new System.Drawing.Size(242, 242);
            this.picPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlaylist.TabIndex = 8;
            this.picPlaylist.TabStop = false;
            this.picPlaylist.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.picPlaylist.Click += new System.EventHandler(this.picPlaylist_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(279, 273);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(128, 278);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(71, 29);
            this.labName.TabIndex = 6;
            this.labName.Text = "Dạ Vũ";
            // 
            // bunifuIconButton1
            // 
            this.bunifuIconButton1.AllowAnimations = true;
            this.bunifuIconButton1.AllowBorderColorChanges = true;
            this.bunifuIconButton1.AllowMouseEffects = true;
            this.bunifuIconButton1.AnimationSpeed = 200;
            this.bunifuIconButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButton1.BorderRadius = 1;
            this.bunifuIconButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButton1.BorderThickness = 1;
            this.bunifuIconButton1.ColorContrastOnClick = 30;
            this.bunifuIconButton1.ColorContrastOnHover = 30;
            this.bunifuIconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuIconButton1.CustomizableEdges = borderEdges1;
            this.bunifuIconButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuIconButton1.Image")));
            this.bunifuIconButton1.ImageMargin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.bunifuIconButton1.Location = new System.Drawing.Point(303, 0);
            this.bunifuIconButton1.Name = "bunifuIconButton1";
            this.bunifuIconButton1.RoundBorders = false;
            this.bunifuIconButton1.ShowBorders = true;
            this.bunifuIconButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButton1.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.bunifuIconButton1.TabIndex = 9;
            this.bunifuIconButton1.Click += new System.EventHandler(this.bunifuIconButton1_Click);
            // 
            // playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "playlist";
            this.Size = new System.Drawing.Size(338, 333);
            this.Load += new System.EventHandler(this.playlist_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox picPlaylist;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label labName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
    }
}
