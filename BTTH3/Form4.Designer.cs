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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTrackVolumeValue = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.btnLoop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDownload = new Bunifu.UI.WinForms.BunifuImageButton();
            this.trackVolume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnMuteVolume = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPrevious = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
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
            this.txtLyric = new System.Windows.Forms.RichTextBox();
            this.labType = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picSong = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTrackVolumeValue);
            this.panel1.Controls.Add(this.lblCurrentTime);
            this.panel1.Controls.Add(this.lblTotalTime);
            this.panel1.Controls.Add(this.btnLoop);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.trackVolume);
            this.panel1.Controls.Add(this.btnMuteVolume);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.bunifuHSlider1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 150);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "1";
            // 
            // lblTrackVolumeValue
            // 
            this.lblTrackVolumeValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTrackVolumeValue.AutoSize = true;
            this.lblTrackVolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackVolumeValue.Location = new System.Drawing.Point(1136, 21);
            this.lblTrackVolumeValue.Name = "lblTrackVolumeValue";
            this.lblTrackVolumeValue.Size = new System.Drawing.Size(61, 29);
            this.lblTrackVolumeValue.TabIndex = 21;
            this.lblTrackVolumeValue.Text = "50%";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(79, 75);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(58, 29);
            this.lblCurrentTime.TabIndex = 20;
            this.lblCurrentTime.Text = "0:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(807, 75);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(58, 29);
            this.lblTotalTime.TabIndex = 19;
            this.lblTotalTime.Text = "0:00";
            // 
            // btnLoop
            // 
            this.btnLoop.ActiveImage = null;
            this.btnLoop.AllowAnimations = true;
            this.btnLoop.AllowBuffering = false;
            this.btnLoop.AllowToggling = false;
            this.btnLoop.AllowZooming = true;
            this.btnLoop.AllowZoomingOnFocus = false;
            this.btnLoop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnLoop.ErrorImage")));
            this.btnLoop.FadeWhenInactive = false;
            this.btnLoop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnLoop.Image = ((System.Drawing.Image)(resources.GetObject("btnLoop.Image")));
            this.btnLoop.ImageActive = null;
            this.btnLoop.ImageLocation = null;
            this.btnLoop.ImageMargin = 20;
            this.btnLoop.ImageSize = new System.Drawing.Size(36, 42);
            this.btnLoop.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnLoop.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLoop.InitialImage")));
            this.btnLoop.Location = new System.Drawing.Point(327, 61);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Rotation = 0;
            this.btnLoop.ShowActiveImage = true;
            this.btnLoop.ShowCursorChanges = true;
            this.btnLoop.ShowImageBorders = true;
            this.btnLoop.ShowSizeMarkers = false;
            this.btnLoop.Size = new System.Drawing.Size(56, 62);
            this.btnLoop.TabIndex = 18;
            this.btnLoop.ToolTipText = "";
            this.btnLoop.WaitOnLoad = false;
            this.btnLoop.Zoom = 20;
            this.btnLoop.ZoomSpeed = 10;
            // 
            // btnDownload
            // 
            this.btnDownload.ActiveImage = null;
            this.btnDownload.AllowAnimations = true;
            this.btnDownload.AllowBuffering = false;
            this.btnDownload.AllowToggling = false;
            this.btnDownload.AllowZooming = true;
            this.btnDownload.AllowZoomingOnFocus = false;
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDownload.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.ErrorImage")));
            this.btnDownload.FadeWhenInactive = false;
            this.btnDownload.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageActive = null;
            this.btnDownload.ImageLocation = null;
            this.btnDownload.ImageMargin = 20;
            this.btnDownload.ImageSize = new System.Drawing.Size(36, 42);
            this.btnDownload.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnDownload.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.InitialImage")));
            this.btnDownload.Location = new System.Drawing.Point(579, 61);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Rotation = 0;
            this.btnDownload.ShowActiveImage = true;
            this.btnDownload.ShowCursorChanges = true;
            this.btnDownload.ShowImageBorders = true;
            this.btnDownload.ShowSizeMarkers = false;
            this.btnDownload.Size = new System.Drawing.Size(56, 62);
            this.btnDownload.TabIndex = 17;
            this.btnDownload.ToolTipText = "";
            this.btnDownload.WaitOnLoad = false;
            this.btnDownload.Zoom = 20;
            this.btnDownload.ZoomSpeed = 10;
            // 
            // trackVolume
            // 
            this.trackVolume.AllowCursorChanges = true;
            this.trackVolume.AllowHomeEndKeysDetection = false;
            this.trackVolume.AllowIncrementalClickMoves = true;
            this.trackVolume.AllowMouseDownEffects = false;
            this.trackVolume.AllowMouseHoverEffects = false;
            this.trackVolume.AllowScrollingAnimations = true;
            this.trackVolume.AllowScrollKeysDetection = true;
            this.trackVolume.AllowScrollOptionsMenu = true;
            this.trackVolume.AllowShrinkingOnFocusLost = false;
            this.trackVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackVolume.BackColor = System.Drawing.Color.Transparent;
            this.trackVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackVolume.BackgroundImage")));
            this.trackVolume.BindingContainer = null;
            this.trackVolume.BorderRadius = 2;
            this.trackVolume.BorderThickness = 1;
            this.trackVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackVolume.DrawThickBorder = false;
            this.trackVolume.DurationBeforeShrink = 2000;
            this.trackVolume.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.trackVolume.LargeChange = 10;
            this.trackVolume.Location = new System.Drawing.Point(968, 15);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Minimum = 0;
            this.trackVolume.MinimumSize = new System.Drawing.Size(0, 39);
            this.trackVolume.MinimumThumbLength = 18;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.trackVolume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.trackVolume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.trackVolume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackVolume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackVolume.ShrinkSizeLimit = 3;
            this.trackVolume.Size = new System.Drawing.Size(161, 39);
            this.trackVolume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.trackVolume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.trackVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.trackVolume.SmallChange = 1;
            this.trackVolume.TabIndex = 16;
            this.trackVolume.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.trackVolume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.trackVolume.ThumbLength = 18;
            this.trackVolume.ThumbMargin = 1;
            this.trackVolume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.trackVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.trackVolume.Value = 50;
            // 
            // btnMuteVolume
            // 
            this.btnMuteVolume.ActiveImage = null;
            this.btnMuteVolume.AllowAnimations = true;
            this.btnMuteVolume.AllowBuffering = false;
            this.btnMuteVolume.AllowToggling = false;
            this.btnMuteVolume.AllowZooming = true;
            this.btnMuteVolume.AllowZoomingOnFocus = false;
            this.btnMuteVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuteVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnMuteVolume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMuteVolume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMuteVolume.ErrorImage")));
            this.btnMuteVolume.FadeWhenInactive = false;
            this.btnMuteVolume.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMuteVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnMuteVolume.Image")));
            this.btnMuteVolume.ImageActive = null;
            this.btnMuteVolume.ImageLocation = null;
            this.btnMuteVolume.ImageMargin = 20;
            this.btnMuteVolume.ImageSize = new System.Drawing.Size(36, 42);
            this.btnMuteVolume.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnMuteVolume.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMuteVolume.InitialImage")));
            this.btnMuteVolume.Location = new System.Drawing.Point(905, 8);
            this.btnMuteVolume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMuteVolume.Name = "btnMuteVolume";
            this.btnMuteVolume.Rotation = 0;
            this.btnMuteVolume.ShowActiveImage = true;
            this.btnMuteVolume.ShowCursorChanges = true;
            this.btnMuteVolume.ShowImageBorders = true;
            this.btnMuteVolume.ShowSizeMarkers = false;
            this.btnMuteVolume.Size = new System.Drawing.Size(56, 62);
            this.btnMuteVolume.TabIndex = 15;
            this.btnMuteVolume.ToolTipText = "";
            this.btnMuteVolume.WaitOnLoad = false;
            this.btnMuteVolume.Zoom = 20;
            this.btnMuteVolume.ZoomSpeed = 10;
            // 
            // btnNext
            // 
            this.btnNext.ActiveImage = null;
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBuffering = false;
            this.btnNext.AllowToggling = false;
            this.btnNext.AllowZooming = true;
            this.btnNext.AllowZoomingOnFocus = false;
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ErrorImage")));
            this.btnNext.FadeWhenInactive = false;
            this.btnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.ImageLocation = null;
            this.btnNext.ImageMargin = 20;
            this.btnNext.ImageSize = new System.Drawing.Size(36, 42);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(516, 61);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(56, 62);
            this.btnNext.TabIndex = 14;
            this.btnNext.ToolTipText = "";
            this.btnNext.WaitOnLoad = false;
            this.btnNext.Zoom = 20;
            this.btnNext.ZoomSpeed = 10;
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = true;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 20;
            this.btnPlay.ImageSize = new System.Drawing.Size(36, 42);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(453, 61);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(56, 62);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 20;
            this.btnPlay.ZoomSpeed = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.ActiveImage = null;
            this.btnPrevious.AllowAnimations = true;
            this.btnPrevious.AllowBuffering = false;
            this.btnPrevious.AllowToggling = false;
            this.btnPrevious.AllowZooming = true;
            this.btnPrevious.AllowZoomingOnFocus = false;
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrevious.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ErrorImage")));
            this.btnPrevious.FadeWhenInactive = false;
            this.btnPrevious.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.ImageLocation = null;
            this.btnPrevious.ImageMargin = 20;
            this.btnPrevious.ImageSize = new System.Drawing.Size(36, 42);
            this.btnPrevious.ImageZoomSize = new System.Drawing.Size(56, 62);
            this.btnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.InitialImage")));
            this.btnPrevious.Location = new System.Drawing.Point(390, 61);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Rotation = 0;
            this.btnPrevious.ShowActiveImage = true;
            this.btnPrevious.ShowCursorChanges = true;
            this.btnPrevious.ShowImageBorders = true;
            this.btnPrevious.ShowSizeMarkers = false;
            this.btnPrevious.Size = new System.Drawing.Size(56, 62);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.ToolTipText = "";
            this.btnPrevious.WaitOnLoad = false;
            this.btnPrevious.Zoom = 20;
            this.btnPrevious.ZoomSpeed = 10;
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(126)))), ((int)(((byte)(225)))));
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(85, 15);
            this.bunifuHSlider1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 39);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(793, 39);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 0;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 78;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 50;
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
            this.panel2.Controls.Add(this.wplayer);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.picLove);
            this.panel2.Controls.Add(this.pb_str5);
            this.panel2.Controls.Add(this.pb_str4);
            this.panel2.Controls.Add(this.pb_str3);
            this.panel2.Controls.Add(this.pb_str2);
            this.panel2.Controls.Add(this.pb_str1);
            this.panel2.Controls.Add(this.txtLyric);
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
            this.panel2.Size = new System.Drawing.Size(1280, 570);
            this.panel2.TabIndex = 6;
            // 
            // wplayer
            // 
            this.wplayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(0, 342);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(1280, 228);
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
            this.picLove.Location = new System.Drawing.Point(390, 513);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(40, 40);
            this.picLove.TabIndex = 24;
            this.picLove.TabStop = false;
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
            // 
            // txtLyric
            // 
            this.txtLyric.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyric.Location = new System.Drawing.Point(599, 354);
            this.txtLyric.Name = "txtLyric";
            this.txtLyric.Size = new System.Drawing.Size(598, 138);
            this.txtLyric.TabIndex = 7;
            this.txtLyric.Text = "Hey Kewtiie";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(772, 254);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(135, 59);
            this.labType.TabIndex = 6;
            this.labType.Text = "name";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthor.Location = new System.Drawing.Point(772, 154);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(135, 59);
            this.labAuthor.TabIndex = 5;
            this.labAuthor.Text = "name";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(772, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(135, 59);
            this.labName.TabIndex = 4;
            this.labName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ca sĩ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 50);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTrackVolumeValue;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
        private Bunifu.UI.WinForms.BunifuImageButton btnLoop;
        private Bunifu.UI.WinForms.BunifuImageButton btnDownload;
        private Bunifu.UI.WinForms.BunifuHSlider trackVolume;
        private Bunifu.UI.WinForms.BunifuImageButton btnMuteVolume;
        private Bunifu.UI.WinForms.BunifuImageButton btnNext;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnPrevious;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSong;
        private System.Windows.Forms.RichTextBox txtLyric;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.PictureBox pb_str5;
        private System.Windows.Forms.PictureBox pb_str4;
        private System.Windows.Forms.PictureBox pb_str3;
        private System.Windows.Forms.PictureBox pb_str2;
        private System.Windows.Forms.PictureBox pb_str1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wplayer;
    }
}