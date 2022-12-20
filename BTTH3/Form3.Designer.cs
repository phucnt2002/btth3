namespace BTTH3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.pan_home = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.Hometimer = new System.Windows.Forms.Timer(this.components);
            this.panMenu = new System.Windows.Forms.Panel();
            this.panHome = new System.Windows.Forms.Panel();
            this.search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.pan_home.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(231)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.pan_home);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.bunifuButton21);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(278, 720);
            this.sidebar.MinimumSize = new System.Drawing.Size(77, 720);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(278, 720);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(9, 25);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(48, 50);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBtn.TabIndex = 1;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // pan_home
            // 
            this.pan_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(251)))));
            this.pan_home.Controls.Add(this.panel5);
            this.pan_home.Controls.Add(this.panel4);
            this.pan_home.Controls.Add(this.panel3);
            this.pan_home.Controls.Add(this.panel2);
            this.pan_home.Location = new System.Drawing.Point(3, 109);
            this.pan_home.MaximumSize = new System.Drawing.Size(275, 300);
            this.pan_home.MinimumSize = new System.Drawing.Size(275, 60);
            this.pan_home.Name = "pan_home";
            this.pan_home.Size = new System.Drawing.Size(275, 60);
            this.pan_home.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(3, 221);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 74);
            this.panel5.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(251)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, -1);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(303, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "                 Rap";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(0, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 74);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(251)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-2, -1);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(303, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "                 Acoustic ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 74);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(251)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, -1);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(303, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "                 Remix";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 58);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(231)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "                 Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(3, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 67);
            this.panel6.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(231)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-3, -2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 80);
            this.button5.TabIndex = 2;
            this.button5.Text = "                 Playlist";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Location = new System.Drawing.Point(3, 248);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 76);
            this.panel7.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(231)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-3, -5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(303, 86);
            this.button6.TabIndex = 5;
            this.button6.Text = "                 Favorite";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(3, 330);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 76);
            this.panel8.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(42)))), ((int)(((byte)(231)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-3, -5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 86);
            this.button7.TabIndex = 5;
            this.button7.Text = "                  History";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.Blue;
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Thoát";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges1;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.Red;
            this.bunifuButton21.IdleBorderRadius = 1;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.Blue;
            this.bunifuButton21.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.IdleIconLeftImage")));
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(3, 412);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 1;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 1;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.Blue;
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.OnIdleState.IconLeftImage")));
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 1;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(275, 62);
            this.bunifuButton21.TabIndex = 0;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Hometimer
            // 
            this.Hometimer.Interval = 10;
            this.Hometimer.Tick += new System.EventHandler(this.Hometimer_Tick);
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.panHome);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.Location = new System.Drawing.Point(278, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1002, 720);
            this.panMenu.TabIndex = 1;
            // 
            // panHome
            // 
            this.panHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(93)))), ((int)(((byte)(231)))));
            this.panHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panHome.Controls.Add(this.search);
            this.panHome.Controls.Add(this.flowLayoutPanel1);
            this.panHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHome.Location = new System.Drawing.Point(0, 0);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(1002, 720);
            this.panHome.TabIndex = 2;
            // 
            // search
            // 
            this.search.AcceptsReturn = false;
            this.search.AcceptsTab = false;
            this.search.AnimationSpeed = 200;
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.AutoSizeHeight = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search.BorderColorIdle = System.Drawing.Color.Silver;
            this.search.BorderRadius = 1;
            this.search.BorderThickness = 1;
            this.search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.search.DefaultText = "";
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.FillColor = System.Drawing.Color.White;
            this.search.HideSelection = true;
            this.search.IconLeft = null;
            this.search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.search.IconPadding = 10;
            this.search.IconRight = ((System.Drawing.Image)(resources.GetObject("search.IconRight")));
            this.search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Lines = new string[0];
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.MaxLength = 32767;
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Modified = false;
            this.search.Multiline = false;
            this.search.Name = "search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search.OnIdleState = stateProperties4;
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.search.PlaceholderText = "Enter song, author, type";
            this.search.ReadOnly = false;
            this.search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.ShortcutsEnabled = true;
            this.search.Size = new System.Drawing.Size(1002, 59);
            this.search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search.TabIndex = 4;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.TextMarginBottom = 0;
            this.search.TextMarginLeft = 3;
            this.search.TextMarginTop = 1;
            this.search.TextPlaceholder = "Enter song, author, type";
            this.search.UseSystemPasswordChar = false;
            this.search.WordWrap = true;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1002, 661);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.pan_home.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pan_home;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer Hometimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panHome;
        private Bunifu.UI.WinForms.BunifuTextBox search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}