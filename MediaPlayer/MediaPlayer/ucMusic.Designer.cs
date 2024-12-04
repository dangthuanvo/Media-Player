
namespace MediaPlayer
{
    partial class ucMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusic));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tab1Music = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.range = new Bunifu.Framework.UI.BunifuRange();
            this.speedadjustDropBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.loopButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.muteButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.labelTimer = new System.Windows.Forms.Label();
            this.backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.slowButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nextButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.fastButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.playpauseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bunifuHSlider2 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.playerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.voiceRecord1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.rcLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.stopButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.startButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSnackbar2 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.bunifuSnackbar3 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.shuffleButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.record = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.backtodefaultButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.editButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tab1Music.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.voiceRecord1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1Music
            // 
            this.tab1Music.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1Music.Controls.Add(this.tabDefault);
            this.tab1Music.Controls.Add(this.tabPlay);
            this.tab1Music.Controls.Add(this.tabPage3);
            this.tab1Music.Location = new System.Drawing.Point(0, 53);
            this.tab1Music.Name = "tab1Music";
            this.tab1Music.SelectedIndex = 0;
            this.tab1Music.Size = new System.Drawing.Size(940, 467);
            this.tab1Music.TabIndex = 0;
            // 
            // tabDefault
            // 
            this.tabDefault.BackgroundImage = global::MediaPlayer.Properties.Resources.photo_1420161900862_9a86fa1f5c792;
            this.tabDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDefault.Location = new System.Drawing.Point(4, 22);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefault.Size = new System.Drawing.Size(932, 441);
            this.tabDefault.TabIndex = 0;
            this.tabDefault.Text = "tabDefault";
            this.tabDefault.UseVisualStyleBackColor = true;
            // 
            // tabPlay
            // 
            this.tabPlay.BackColor = System.Drawing.Color.Indigo;
            this.tabPlay.Controls.Add(this.bunifuPanel1);
            this.tabPlay.Controls.Add(this.labelAuthor);
            this.tabPlay.Controls.Add(this.labelTitle);
            this.tabPlay.Controls.Add(this.labelDuration);
            this.tabPlay.Controls.Add(this.label3);
            this.tabPlay.Controls.Add(this.label2);
            this.tabPlay.Controls.Add(this.lbArtist);
            this.tabPlay.Controls.Add(this.playerMusic);
            this.tabPlay.Controls.Add(this.pictureBoxGif);
            this.tabPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPlay.Location = new System.Drawing.Point(4, 22);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlay.Size = new System.Drawing.Size(932, 441);
            this.tabPlay.TabIndex = 1;
            this.tabPlay.Text = "tabPlay";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Controls.Add(this.speedadjustDropBox);
            this.bunifuPanel1.Controls.Add(this.loopButton);
            this.bunifuPanel1.Controls.Add(this.muteButton);
            this.bunifuPanel1.Controls.Add(this.labelTimer);
            this.bunifuPanel1.Controls.Add(this.backButton);
            this.bunifuPanel1.Controls.Add(this.slowButton);
            this.bunifuPanel1.Controls.Add(this.nextButton);
            this.bunifuPanel1.Controls.Add(this.fastButton);
            this.bunifuPanel1.Controls.Add(this.playpauseButton);
            this.bunifuPanel1.Controls.Add(this.bunifuHSlider2);
            this.bunifuPanel1.Controls.Add(this.bunifuHSlider1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 383);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(926, 55);
            this.bunifuPanel1.TabIndex = 7;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.range);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(926, 55);
            this.bunifuPanel2.TabIndex = 23;
            // 
            // range
            // 
            this.range.BackColor = System.Drawing.Color.Transparent;
            this.range.BackgroudColor = System.Drawing.Color.DarkGray;
            this.range.BorderRadius = 0;
            this.range.IndicatorColor = System.Drawing.Color.Indigo;
            this.range.Location = new System.Drawing.Point(3, 16);
            this.range.MaximumRange = 100;
            this.range.Name = "range";
            this.range.RangeMax = 49;
            this.range.RangeMin = 0;
            this.range.Size = new System.Drawing.Size(920, 30);
            this.range.TabIndex = 0;
            this.range.RangeChanged += new System.EventHandler(this.range_RangeChanged);
            // 
            // speedadjustDropBox
            // 
            this.speedadjustDropBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.speedadjustDropBox.BackColor = System.Drawing.Color.Transparent;
            this.speedadjustDropBox.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.speedadjustDropBox.BorderColor = System.Drawing.Color.White;
            this.speedadjustDropBox.BorderRadius = 1;
            this.speedadjustDropBox.Color = System.Drawing.Color.White;
            this.speedadjustDropBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.speedadjustDropBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.speedadjustDropBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.speedadjustDropBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.speedadjustDropBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.speedadjustDropBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.speedadjustDropBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.speedadjustDropBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.speedadjustDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedadjustDropBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.speedadjustDropBox.FillDropDown = true;
            this.speedadjustDropBox.FillIndicator = false;
            this.speedadjustDropBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speedadjustDropBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.speedadjustDropBox.ForeColor = System.Drawing.Color.White;
            this.speedadjustDropBox.FormattingEnabled = true;
            this.speedadjustDropBox.Icon = null;
            this.speedadjustDropBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.speedadjustDropBox.IndicatorColor = System.Drawing.Color.DarkGray;
            this.speedadjustDropBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.speedadjustDropBox.IndicatorThickness = 2;
            this.speedadjustDropBox.IsDropdownOpened = false;
            this.speedadjustDropBox.ItemBackColor = System.Drawing.Color.White;
            this.speedadjustDropBox.ItemBorderColor = System.Drawing.Color.White;
            this.speedadjustDropBox.ItemForeColor = System.Drawing.Color.Black;
            this.speedadjustDropBox.ItemHeight = 26;
            this.speedadjustDropBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.speedadjustDropBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.speedadjustDropBox.Items.AddRange(new object[] {
            "0.25",
            "0.5",
            "1",
            "2",
            "4"});
            this.speedadjustDropBox.ItemTopMargin = 3;
            this.speedadjustDropBox.Location = new System.Drawing.Point(662, 12);
            this.speedadjustDropBox.Name = "speedadjustDropBox";
            this.speedadjustDropBox.Size = new System.Drawing.Size(49, 32);
            this.speedadjustDropBox.TabIndex = 20;
            this.speedadjustDropBox.Text = null;
            this.speedadjustDropBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.speedadjustDropBox.TextLeftMargin = 0;
            this.speedadjustDropBox.SelectedIndexChanged += new System.EventHandler(this.speedadjustDropBox_SelectedIndexChanged);
            // 
            // loopButton
            // 
            this.loopButton.ActiveImage = null;
            this.loopButton.AllowAnimations = true;
            this.loopButton.AllowBuffering = false;
            this.loopButton.AllowToggling = false;
            this.loopButton.AllowZooming = false;
            this.loopButton.AllowZoomingOnFocus = false;
            this.loopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loopButton.BackColor = System.Drawing.Color.SlateBlue;
            this.loopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loopButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("loopButton.ErrorImage")));
            this.loopButton.FadeWhenInactive = false;
            this.loopButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.loopButton.Image = global::MediaPlayer.Properties.Resources.oval_loop_64px;
            this.loopButton.ImageActive = null;
            this.loopButton.ImageLocation = null;
            this.loopButton.ImageMargin = 20;
            this.loopButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loopButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.loopButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("loopButton.InitialImage")));
            this.loopButton.Location = new System.Drawing.Point(717, 8);
            this.loopButton.Name = "loopButton";
            this.loopButton.Rotation = 0;
            this.loopButton.ShowActiveImage = true;
            this.loopButton.ShowCursorChanges = true;
            this.loopButton.ShowImageBorders = true;
            this.loopButton.ShowSizeMarkers = false;
            this.loopButton.Size = new System.Drawing.Size(40, 40);
            this.loopButton.TabIndex = 19;
            this.loopButton.ToolTipText = "";
            this.loopButton.WaitOnLoad = false;
            this.loopButton.Zoom = 20;
            this.loopButton.ZoomSpeed = 10;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.ActiveImage = null;
            this.muteButton.AllowAnimations = true;
            this.muteButton.AllowBuffering = false;
            this.muteButton.AllowToggling = false;
            this.muteButton.AllowZooming = false;
            this.muteButton.AllowZoomingOnFocus = false;
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.muteButton.BackColor = System.Drawing.Color.SlateBlue;
            this.muteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.muteButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("muteButton.ErrorImage")));
            this.muteButton.FadeWhenInactive = false;
            this.muteButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.muteButton.Image = global::MediaPlayer.Properties.Resources.max4;
            this.muteButton.ImageActive = null;
            this.muteButton.ImageLocation = null;
            this.muteButton.ImageMargin = 20;
            this.muteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.muteButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.muteButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("muteButton.InitialImage")));
            this.muteButton.Location = new System.Drawing.Point(757, 8);
            this.muteButton.Name = "muteButton";
            this.muteButton.Rotation = 0;
            this.muteButton.ShowActiveImage = true;
            this.muteButton.ShowCursorChanges = true;
            this.muteButton.ShowImageBorders = true;
            this.muteButton.ShowSizeMarkers = false;
            this.muteButton.Size = new System.Drawing.Size(40, 40);
            this.muteButton.TabIndex = 18;
            this.muteButton.ToolTipText = "";
            this.muteButton.WaitOnLoad = false;
            this.muteButton.Zoom = 20;
            this.muteButton.ZoomSpeed = 10;
            this.muteButton.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Location = new System.Drawing.Point(614, 21);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(34, 13);
            this.labelTimer.TabIndex = 17;
            this.labelTimer.Text = "00:00";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Image = global::MediaPlayer.Properties.Resources._2_back3;
            this.backButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.backButton.ImageRotate = 0F;
            this.backButton.ImageSize = new System.Drawing.Size(40, 40);
            this.backButton.Location = new System.Drawing.Point(7, 6);
            this.backButton.Name = "backButton";
            this.backButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.backButton.PressedState.Parent = this.backButton;
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 16;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // slowButton
            // 
            this.slowButton.BackColor = System.Drawing.Color.Transparent;
            this.slowButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.slowButton.CheckedState.Parent = this.slowButton;
            this.slowButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.slowButton.HoverState.Parent = this.slowButton;
            this.slowButton.Image = global::MediaPlayer.Properties.Resources.back3;
            this.slowButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.slowButton.ImageRotate = 0F;
            this.slowButton.ImageSize = new System.Drawing.Size(40, 40);
            this.slowButton.Location = new System.Drawing.Point(63, 6);
            this.slowButton.Name = "slowButton";
            this.slowButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.slowButton.PressedState.Parent = this.slowButton;
            this.slowButton.ShadowDecoration.Parent = this.slowButton;
            this.slowButton.Size = new System.Drawing.Size(40, 40);
            this.slowButton.TabIndex = 15;
            this.slowButton.Click += new System.EventHandler(this.slowButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextButton.CheckedState.Parent = this.nextButton;
            this.nextButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextButton.HoverState.Parent = this.nextButton;
            this.nextButton.Image = global::MediaPlayer.Properties.Resources._2fw2;
            this.nextButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.nextButton.ImageRotate = 0F;
            this.nextButton.ImageSize = new System.Drawing.Size(40, 40);
            this.nextButton.Location = new System.Drawing.Point(231, 7);
            this.nextButton.Name = "nextButton";
            this.nextButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextButton.PressedState.Parent = this.nextButton;
            this.nextButton.ShadowDecoration.Parent = this.nextButton;
            this.nextButton.Size = new System.Drawing.Size(40, 40);
            this.nextButton.TabIndex = 14;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // fastButton
            // 
            this.fastButton.BackColor = System.Drawing.Color.Transparent;
            this.fastButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.fastButton.CheckedState.Parent = this.fastButton;
            this.fastButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.fastButton.HoverState.Parent = this.fastButton;
            this.fastButton.Image = global::MediaPlayer.Properties.Resources.fw3;
            this.fastButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.fastButton.ImageRotate = 0F;
            this.fastButton.ImageSize = new System.Drawing.Size(40, 40);
            this.fastButton.Location = new System.Drawing.Point(175, 7);
            this.fastButton.Name = "fastButton";
            this.fastButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.fastButton.PressedState.Parent = this.fastButton;
            this.fastButton.ShadowDecoration.Parent = this.fastButton;
            this.fastButton.Size = new System.Drawing.Size(40, 40);
            this.fastButton.TabIndex = 13;
            this.fastButton.Click += new System.EventHandler(this.fastButton_Click);
            // 
            // playpauseButton
            // 
            this.playpauseButton.BackColor = System.Drawing.Color.Transparent;
            this.playpauseButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playpauseButton.CheckedState.Parent = this.playpauseButton;
            this.playpauseButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.playpauseButton.HoverState.Parent = this.playpauseButton;
            this.playpauseButton.Image = global::MediaPlayer.Properties.Resources.pause3;
            this.playpauseButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.playpauseButton.ImageRotate = 0F;
            this.playpauseButton.ImageSize = new System.Drawing.Size(40, 40);
            this.playpauseButton.Location = new System.Drawing.Point(119, 7);
            this.playpauseButton.Name = "playpauseButton";
            this.playpauseButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.playpauseButton.PressedState.Parent = this.playpauseButton;
            this.playpauseButton.ShadowDecoration.Parent = this.playpauseButton;
            this.playpauseButton.Size = new System.Drawing.Size(40, 40);
            this.playpauseButton.TabIndex = 12;
            this.playpauseButton.Click += new System.EventHandler(this.playpauseButton_Click);
            // 
            // bunifuHSlider2
            // 
            this.bunifuHSlider2.AllowCursorChanges = true;
            this.bunifuHSlider2.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider2.AllowIncrementalClickMoves = true;
            this.bunifuHSlider2.AllowMouseDownEffects = false;
            this.bunifuHSlider2.AllowMouseHoverEffects = false;
            this.bunifuHSlider2.AllowScrollingAnimations = true;
            this.bunifuHSlider2.AllowScrollKeysDetection = true;
            this.bunifuHSlider2.AllowScrollOptionsMenu = true;
            this.bunifuHSlider2.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuHSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider2.BackgroundImage")));
            this.bunifuHSlider2.BindingContainer = null;
            this.bunifuHSlider2.BorderRadius = 2;
            this.bunifuHSlider2.BorderThickness = 1;
            this.bunifuHSlider2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider2.DrawThickBorder = false;
            this.bunifuHSlider2.DurationBeforeShrink = 2000;
            this.bunifuHSlider2.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider2.LargeChange = 10;
            this.bunifuHSlider2.Location = new System.Drawing.Point(799, 13);
            this.bunifuHSlider2.Maximum = 100;
            this.bunifuHSlider2.Minimum = 0;
            this.bunifuHSlider2.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider2.MinimumThumbLength = 18;
            this.bunifuHSlider2.Name = "bunifuHSlider2";
            this.bunifuHSlider2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.ShrinkSizeLimit = 3;
            this.bunifuHSlider2.Size = new System.Drawing.Size(124, 31);
            this.bunifuHSlider2.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider2.SmallChange = 1;
            this.bunifuHSlider2.TabIndex = 7;
            this.bunifuHSlider2.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider2.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider2.ThumbLength = 18;
            this.bunifuHSlider2.ThumbMargin = 1;
            this.bunifuHSlider2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider2.Value = 50;
            this.bunifuHSlider2.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider2_Scroll);
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
            this.bunifuHSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.LargeChange = 1;
            this.bunifuHSlider1.Location = new System.Drawing.Point(279, 12);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(322, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 6;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 18;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 0;
            this.bunifuHSlider1.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            this.bunifuHSlider1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuHSlider1_MouseMove);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Black;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAuthor.Location = new System.Drawing.Point(79, 30);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(36, 15);
            this.labelAuthor.TabIndex = 18;
            this.labelAuthor.Text = "None";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Black;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(79, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(36, 15);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "None";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.Black;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDuration.Location = new System.Drawing.Point(79, 53);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(36, 15);
            this.labelDuration.TabIndex = 16;
            this.labelDuration.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.BackColor = System.Drawing.Color.Black;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbArtist.Location = new System.Drawing.Point(9, 26);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(59, 20);
            this.lbArtist.TabIndex = 9;
            this.lbArtist.Text = "Author";
            // 
            // playerMusic
            // 
            this.playerMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerMusic.Enabled = true;
            this.playerMusic.Location = new System.Drawing.Point(3, 428);
            this.playerMusic.Name = "playerMusic";
            this.playerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerMusic.OcxState")));
            this.playerMusic.Size = new System.Drawing.Size(10, 10);
            this.playerMusic.TabIndex = 0;
            this.playerMusic.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGif.Image = global::MediaPlayer.Properties.Resources._2;
            this.pictureBoxGif.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(926, 395);
            this.pictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 8;
            this.pictureBoxGif.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.voiceRecord1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(932, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabRecord";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // voiceRecord1
            // 
            this.voiceRecord1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.voiceRecord1.Audio_CaptureDevice = "";
            this.voiceRecord1.Audio_CaptureDevice_CustomLatency = 0;
            this.voiceRecord1.Audio_CaptureDevice_Format = "";
            this.voiceRecord1.Audio_CaptureDevice_Format_UseBest = true;
            this.voiceRecord1.Audio_CaptureDevice_Line = "";
            this.voiceRecord1.Audio_CaptureDevice_MasterDevice = null;
            this.voiceRecord1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.voiceRecord1.Audio_CaptureDevice_Path = null;
            this.voiceRecord1.Audio_CaptureSourceFilter = null;
            this.voiceRecord1.Audio_Channel_Mapper = null;
            this.voiceRecord1.Audio_Decoder = null;
            this.voiceRecord1.Audio_Effects_Enabled = false;
            this.voiceRecord1.Audio_Enhancer_Enabled = false;
            this.voiceRecord1.Audio_OutputDevice = "Default DirectSound Device";
            this.voiceRecord1.Audio_PCM_Converter = null;
            this.voiceRecord1.Audio_PlayAudio = true;
            this.voiceRecord1.Audio_RecordAudio = true;
            this.voiceRecord1.Audio_Sample_Grabber_Enabled = false;
            this.voiceRecord1.Audio_VUMeter_Enabled = false;
            this.voiceRecord1.Audio_VUMeter_Pro_Enabled = false;
            this.voiceRecord1.Audio_VUMeter_Pro_Volume = 100;
            this.voiceRecord1.BackColor = System.Drawing.Color.Black;
            this.voiceRecord1.Barcode_Reader_Enabled = false;
            this.voiceRecord1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.voiceRecord1.BDA_Source = null;
            this.voiceRecord1.ChromaKey = null;
            this.voiceRecord1.Controls.Add(this.rcLabel);
            this.voiceRecord1.Controls.Add(this.exitButton);
            this.voiceRecord1.Controls.Add(this.stopButton);
            this.voiceRecord1.Controls.Add(this.startButton);
            this.voiceRecord1.Controls.Add(this.pictureBox1);
            this.voiceRecord1.Custom_Source = null;
            this.voiceRecord1.CustomRedist_Auto = true;
            this.voiceRecord1.CustomRedist_DisableDialog = false;
            this.voiceRecord1.CustomRedist_Path = null;
            this.voiceRecord1.Debug_Dir = "";
            this.voiceRecord1.Debug_DisableMessageDialogs = false;
            this.voiceRecord1.Debug_Mode = false;
            this.voiceRecord1.Debug_Telemetry = true;
            this.voiceRecord1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.voiceRecord1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.voiceRecord1.Decklink_Input_IREUSA = false;
            this.voiceRecord1.Decklink_Input_SMPTE = false;
            this.voiceRecord1.Decklink_Output = null;
            this.voiceRecord1.Decklink_Source = null;
            this.voiceRecord1.DirectCapture_Muxer = null;
            this.voiceRecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voiceRecord1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.voiceRecord1.Face_Tracking = null;
            this.voiceRecord1.IP_Camera_Source = null;
            this.voiceRecord1.Location = new System.Drawing.Point(3, 3);
            this.voiceRecord1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.voiceRecord1.Motion_Detection = null;
            this.voiceRecord1.Motion_DetectionEx = null;
            this.voiceRecord1.MPEG_Audio_Decoder = "";
            this.voiceRecord1.MPEG_Demuxer = null;
            this.voiceRecord1.MPEG_Video_Decoder = "";
            this.voiceRecord1.MultiScreen_Enabled = false;
            this.voiceRecord1.Name = "voiceRecord1";
            this.voiceRecord1.Network_Streaming_Audio_Enabled = false;
            this.voiceRecord1.Network_Streaming_Enabled = false;
            this.voiceRecord1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.voiceRecord1.Network_Streaming_Network_Port = 100;
            this.voiceRecord1.Network_Streaming_Output = null;
            this.voiceRecord1.Network_Streaming_URL = "";
            this.voiceRecord1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.voiceRecord1.OSD_Enabled = false;
            this.voiceRecord1.Output_Filename = "output.mp4";
            this.voiceRecord1.Output_Format = null;
            this.voiceRecord1.PIP_AddSampleGrabbers = false;
            this.voiceRecord1.PIP_ChromaKeySettings = null;
            this.voiceRecord1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.voiceRecord1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.voiceRecord1.Push_Source = null;
            this.voiceRecord1.Screen_Capture_Source = null;
            this.voiceRecord1.SeparateCapture_AutostartCapture = false;
            this.voiceRecord1.SeparateCapture_Enabled = false;
            this.voiceRecord1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.voiceRecord1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.voiceRecord1.SeparateCapture_GMFMode = true;
            this.voiceRecord1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.voiceRecord1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.voiceRecord1.Size = new System.Drawing.Size(926, 435);
            this.voiceRecord1.Start_DelayEnabled = false;
            this.voiceRecord1.StatusOverlay = null;
            this.voiceRecord1.TabIndex = 1;
            this.voiceRecord1.Tags = null;
            this.voiceRecord1.Timeshift_Settings = null;
            this.voiceRecord1.TVTuner_Channel = 0;
            this.voiceRecord1.TVTuner_Country = "";
            this.voiceRecord1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.voiceRecord1.TVTuner_FM_Tuning_Step = 160000000;
            this.voiceRecord1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.voiceRecord1.TVTuner_Frequency = 0;
            this.voiceRecord1.TVTuner_InputType = "";
            this.voiceRecord1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.voiceRecord1.TVTuner_Name = "";
            this.voiceRecord1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.voiceRecord1.Video_CaptureDevice = "";
            this.voiceRecord1.Video_CaptureDevice_CustomPinName = null;
            this.voiceRecord1.Video_CaptureDevice_Format = "";
            this.voiceRecord1.Video_CaptureDevice_Format_UseBest = true;
            this.voiceRecord1.Video_CaptureDevice_FrameRate = 25D;
            this.voiceRecord1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.voiceRecord1.Video_CaptureDevice_IsAudioSource = false;
            this.voiceRecord1.Video_CaptureDevice_Path = null;
            this.voiceRecord1.Video_CaptureDevice_UseClosedCaptions = false;
            this.voiceRecord1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.voiceRecord1.Video_Crop = null;
            this.voiceRecord1.Video_Decoder = null;
            this.voiceRecord1.Video_Effects_AllowMultipleStreams = false;
            this.voiceRecord1.Video_Effects_Enabled = false;
            this.voiceRecord1.Video_Effects_GPU_Enabled = false;
            this.voiceRecord1.Video_Effects_MergeImageLogos = false;
            this.voiceRecord1.Video_Effects_MergeTextLogos = false;
            this.voiceRecord1.Video_Resize = null;
            this.voiceRecord1.Video_ResizeOrCrop_Enabled = false;
            this.voiceRecord1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.voiceRecord1.Video_Sample_Grabber_Enabled = true;
            this.voiceRecord1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.voiceRecord1.Video_Still_Frames_Grabber_Enabled = false;
            this.voiceRecord1.Virtual_Camera_Output_Enabled = false;
            this.voiceRecord1.Virtual_Camera_Output_LicenseKey = null;
            this.voiceRecord1.VLC_Path = null;
            // 
            // rcLabel
            // 
            this.rcLabel.AllowParentOverrides = false;
            this.rcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rcLabel.AutoEllipsis = false;
            this.rcLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.rcLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.rcLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rcLabel.ForeColor = System.Drawing.Color.Red;
            this.rcLabel.Location = new System.Drawing.Point(802, 20);
            this.rcLabel.Name = "rcLabel";
            this.rcLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rcLabel.Size = new System.Drawing.Size(65, 15);
            this.rcLabel.TabIndex = 4;
            this.rcLabel.Text = "RECORDING";
            this.rcLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.rcLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = false;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = true;
            this.exitButton.AllowZoomingOnFocus = false;
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("exitButton.ErrorImage")));
            this.exitButton.FadeWhenInactive = false;
            this.exitButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.exitButton.Image = global::MediaPlayer.Properties.Resources.close22;
            this.exitButton.ImageActive = null;
            this.exitButton.ImageLocation = null;
            this.exitButton.ImageMargin = 20;
            this.exitButton.ImageSize = new System.Drawing.Size(30, 30);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(873, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 20;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.ActiveImage = null;
            this.stopButton.AllowAnimations = true;
            this.stopButton.AllowBuffering = false;
            this.stopButton.AllowToggling = false;
            this.stopButton.AllowZooming = true;
            this.stopButton.AllowZoomingOnFocus = false;
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stopButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("stopButton.ErrorImage")));
            this.stopButton.FadeWhenInactive = false;
            this.stopButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.stopButton.Image = global::MediaPlayer.Properties.Resources.stop21;
            this.stopButton.ImageActive = null;
            this.stopButton.ImageLocation = null;
            this.stopButton.ImageMargin = 20;
            this.stopButton.ImageSize = new System.Drawing.Size(30, 30);
            this.stopButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.stopButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("stopButton.InitialImage")));
            this.stopButton.Location = new System.Drawing.Point(7, 59);
            this.stopButton.Name = "stopButton";
            this.stopButton.Rotation = 0;
            this.stopButton.ShowActiveImage = true;
            this.stopButton.ShowCursorChanges = true;
            this.stopButton.ShowImageBorders = true;
            this.stopButton.ShowSizeMarkers = false;
            this.stopButton.Size = new System.Drawing.Size(50, 50);
            this.stopButton.TabIndex = 2;
            this.stopButton.ToolTipText = "";
            this.stopButton.WaitOnLoad = false;
            this.stopButton.Zoom = 20;
            this.stopButton.ZoomSpeed = 10;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.ActiveImage = null;
            this.startButton.AllowAnimations = true;
            this.startButton.AllowBuffering = false;
            this.startButton.AllowToggling = false;
            this.startButton.AllowZooming = true;
            this.startButton.AllowZoomingOnFocus = false;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("startButton.ErrorImage")));
            this.startButton.FadeWhenInactive = false;
            this.startButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.startButton.Image = global::MediaPlayer.Properties.Resources.record22;
            this.startButton.ImageActive = null;
            this.startButton.ImageLocation = null;
            this.startButton.ImageMargin = 20;
            this.startButton.ImageSize = new System.Drawing.Size(30, 30);
            this.startButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.startButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("startButton.InitialImage")));
            this.startButton.Location = new System.Drawing.Point(7, 3);
            this.startButton.Name = "startButton";
            this.startButton.Rotation = 0;
            this.startButton.ShowActiveImage = true;
            this.startButton.ShowCursorChanges = true;
            this.startButton.ShowImageBorders = true;
            this.startButton.ShowSizeMarkers = false;
            this.startButton.Size = new System.Drawing.Size(50, 50);
            this.startButton.TabIndex = 1;
            this.startButton.ToolTipText = "";
            this.startButton.WaitOnLoad = false;
            this.startButton.Zoom = 20;
            this.startButton.ZoomSpeed = 10;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.BeneficialImaginativeCurlew_size_restricted;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSnackbar2
            // 
            this.bunifuSnackbar2.AllowDragging = false;
            this.bunifuSnackbar2.AllowMultipleViews = true;
            this.bunifuSnackbar2.ClickToClose = true;
            this.bunifuSnackbar2.DoubleClickToClose = true;
            this.bunifuSnackbar2.DurationAfterIdle = 3000;
            this.bunifuSnackbar2.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar2.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar2.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.FadeCloseIcon = false;
            this.bunifuSnackbar2.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar2.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar2.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.Margin = 10;
            this.bunifuSnackbar2.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar2.MaximumViews = 7;
            this.bunifuSnackbar2.MessageRightMargin = 15;
            this.bunifuSnackbar2.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar2.ShowBorders = false;
            this.bunifuSnackbar2.ShowCloseIcon = false;
            this.bunifuSnackbar2.ShowIcon = true;
            this.bunifuSnackbar2.ShowShadows = true;
            this.bunifuSnackbar2.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar2.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar2.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.ViewsMargin = 7;
            this.bunifuSnackbar2.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar2.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar2.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.ZoomCloseIcon = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuSnackbar3
            // 
            this.bunifuSnackbar3.AllowDragging = false;
            this.bunifuSnackbar3.AllowMultipleViews = true;
            this.bunifuSnackbar3.ClickToClose = true;
            this.bunifuSnackbar3.DoubleClickToClose = true;
            this.bunifuSnackbar3.DurationAfterIdle = 3000;
            this.bunifuSnackbar3.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar3.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar3.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar3.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar3.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon4")));
            this.bunifuSnackbar3.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar3.FadeCloseIcon = false;
            this.bunifuSnackbar3.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar3.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar3.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar3.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar3.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon5")));
            this.bunifuSnackbar3.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar3.Margin = 10;
            this.bunifuSnackbar3.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar3.MaximumViews = 7;
            this.bunifuSnackbar3.MessageRightMargin = 15;
            this.bunifuSnackbar3.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar3.ShowBorders = false;
            this.bunifuSnackbar3.ShowCloseIcon = false;
            this.bunifuSnackbar3.ShowIcon = true;
            this.bunifuSnackbar3.ShowShadows = true;
            this.bunifuSnackbar3.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar3.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar3.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar3.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar3.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon6")));
            this.bunifuSnackbar3.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar3.ViewsMargin = 7;
            this.bunifuSnackbar3.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar3.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar3.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar3.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar3.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar3.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar3.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar3.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon7")));
            this.bunifuSnackbar3.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar3.ZoomCloseIcon = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveImage = null;
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowBuffering = false;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AllowZooming = false;
            this.btnSearch.AllowZoomingOnFocus = false;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Enabled = false;
            this.btnSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ErrorImage")));
            this.btnSearch.FadeWhenInactive = false;
            this.btnSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSearch.Image = global::MediaPlayer.Properties.Resources.icons8_search_32px5;
            this.btnSearch.ImageActive = null;
            this.btnSearch.ImageLocation = null;
            this.btnSearch.ImageMargin = 20;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.InitialImage")));
            this.btnSearch.Location = new System.Drawing.Point(661, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0;
            this.btnSearch.ShowActiveImage = true;
            this.btnSearch.ShowCursorChanges = true;
            this.btnSearch.ShowImageBorders = true;
            this.btnSearch.ShowSizeMarkers = false;
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.ToolTipText = "";
            this.btnSearch.WaitOnLoad = false;
            this.btnSearch.Zoom = 20;
            this.btnSearch.ZoomSpeed = 10;
            // 
            // shuffleButton
            // 
            this.shuffleButton.ActiveImage = null;
            this.shuffleButton.AllowAnimations = true;
            this.shuffleButton.AllowBuffering = false;
            this.shuffleButton.AllowToggling = false;
            this.shuffleButton.AllowZooming = false;
            this.shuffleButton.AllowZoomingOnFocus = false;
            this.shuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.shuffleButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.ErrorImage")));
            this.shuffleButton.FadeWhenInactive = false;
            this.shuffleButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.shuffleButton.Image = global::MediaPlayer.Properties.Resources.shuffle_32px;
            this.shuffleButton.ImageActive = null;
            this.shuffleButton.ImageLocation = null;
            this.shuffleButton.ImageMargin = 20;
            this.shuffleButton.ImageSize = new System.Drawing.Size(30, 30);
            this.shuffleButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.shuffleButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.InitialImage")));
            this.shuffleButton.Location = new System.Drawing.Point(181, 1);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Rotation = 0;
            this.shuffleButton.ShowActiveImage = true;
            this.shuffleButton.ShowCursorChanges = true;
            this.shuffleButton.ShowImageBorders = true;
            this.shuffleButton.ShowSizeMarkers = false;
            this.shuffleButton.Size = new System.Drawing.Size(50, 50);
            this.shuffleButton.TabIndex = 11;
            this.shuffleButton.ToolTipText = "";
            this.shuffleButton.WaitOnLoad = false;
            this.shuffleButton.Zoom = 20;
            this.shuffleButton.ZoomSpeed = 10;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // record
            // 
            this.record.ActiveImage = null;
            this.record.AllowAnimations = true;
            this.record.AllowBuffering = false;
            this.record.AllowToggling = false;
            this.record.AllowZooming = false;
            this.record.AllowZoomingOnFocus = false;
            this.record.BackColor = System.Drawing.Color.Transparent;
            this.record.DialogResult = System.Windows.Forms.DialogResult.None;
            this.record.ErrorImage = ((System.Drawing.Image)(resources.GetObject("record.ErrorImage")));
            this.record.FadeWhenInactive = false;
            this.record.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.record.Image = global::MediaPlayer.Properties.Resources.voice_recorder_32px1;
            this.record.ImageActive = null;
            this.record.ImageLocation = null;
            this.record.ImageMargin = 20;
            this.record.ImageSize = new System.Drawing.Size(30, 30);
            this.record.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.record.InitialImage = ((System.Drawing.Image)(resources.GetObject("record.InitialImage")));
            this.record.Location = new System.Drawing.Point(125, 1);
            this.record.Name = "record";
            this.record.Rotation = 0;
            this.record.ShowActiveImage = true;
            this.record.ShowCursorChanges = true;
            this.record.ShowImageBorders = true;
            this.record.ShowSizeMarkers = false;
            this.record.Size = new System.Drawing.Size(50, 50);
            this.record.TabIndex = 10;
            this.record.ToolTipText = "";
            this.record.WaitOnLoad = false;
            this.record.Zoom = 20;
            this.record.ZoomSpeed = 10;
            this.record.Click += new System.EventHandler(this.Record_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(717, 8);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Bạn đang tìm gì?";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(217, 39);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 5;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Bạn đang tìm gì?";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            this.bunifuTextBox1.TextChange += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            this.bunifuTextBox1.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // backtodefaultButton
            // 
            this.backtodefaultButton.ActiveImage = null;
            this.backtodefaultButton.AllowAnimations = true;
            this.backtodefaultButton.AllowBuffering = false;
            this.backtodefaultButton.AllowToggling = false;
            this.backtodefaultButton.AllowZooming = false;
            this.backtodefaultButton.AllowZoomingOnFocus = false;
            this.backtodefaultButton.BackColor = System.Drawing.Color.Transparent;
            this.backtodefaultButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backtodefaultButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backtodefaultButton.ErrorImage")));
            this.backtodefaultButton.FadeWhenInactive = false;
            this.backtodefaultButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.backtodefaultButton.Image = global::MediaPlayer.Properties.Resources.undo_32px2;
            this.backtodefaultButton.ImageActive = null;
            this.backtodefaultButton.ImageLocation = null;
            this.backtodefaultButton.ImageMargin = 20;
            this.backtodefaultButton.ImageSize = new System.Drawing.Size(30, 30);
            this.backtodefaultButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.backtodefaultButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("backtodefaultButton.InitialImage")));
            this.backtodefaultButton.Location = new System.Drawing.Point(237, 1);
            this.backtodefaultButton.Name = "backtodefaultButton";
            this.backtodefaultButton.Rotation = 0;
            this.backtodefaultButton.ShowActiveImage = true;
            this.backtodefaultButton.ShowCursorChanges = true;
            this.backtodefaultButton.ShowImageBorders = true;
            this.backtodefaultButton.ShowSizeMarkers = false;
            this.backtodefaultButton.Size = new System.Drawing.Size(50, 50);
            this.backtodefaultButton.TabIndex = 4;
            this.backtodefaultButton.ToolTipText = "";
            this.backtodefaultButton.WaitOnLoad = false;
            this.backtodefaultButton.Zoom = 20;
            this.backtodefaultButton.ZoomSpeed = 10;
            this.backtodefaultButton.Click += new System.EventHandler(this.backtodefaultButton_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = false;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = global::MediaPlayer.Properties.Resources.opened_folder_32px2;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 20;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(69, 1);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton4.TabIndex = 2;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = false;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::MediaPlayer.Properties.Resources.addpro3;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 20;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(15, 1);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton3.TabIndex = 1;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // editButton
            // 
            this.editButton.ActiveImage = null;
            this.editButton.AllowAnimations = true;
            this.editButton.AllowBuffering = false;
            this.editButton.AllowToggling = false;
            this.editButton.AllowZooming = false;
            this.editButton.AllowZoomingOnFocus = false;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("editButton.ErrorImage")));
            this.editButton.FadeWhenInactive = false;
            this.editButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.editButton.Image = global::MediaPlayer.Properties.Resources.edit_32px;
            this.editButton.ImageActive = null;
            this.editButton.ImageLocation = null;
            this.editButton.ImageMargin = 20;
            this.editButton.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.editButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("editButton.InitialImage")));
            this.editButton.Location = new System.Drawing.Point(293, 1);
            this.editButton.Name = "editButton";
            this.editButton.Rotation = 0;
            this.editButton.ShowActiveImage = true;
            this.editButton.ShowCursorChanges = true;
            this.editButton.ShowImageBorders = true;
            this.editButton.ShowSizeMarkers = false;
            this.editButton.Size = new System.Drawing.Size(50, 50);
            this.editButton.TabIndex = 15;
            this.editButton.ToolTipText = "";
            this.editButton.WaitOnLoad = false;
            this.editButton.Zoom = 20;
            this.editButton.ZoomSpeed = 10;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ucMusic
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.record);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.backtodefaultButton);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.tab1Music);
            this.Name = "ucMusic";
            this.Size = new System.Drawing.Size(940, 520);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucMusic_Paint);
            this.tab1Music.ResumeLayout(false);
            this.tabPlay.ResumeLayout(false);
            this.tabPlay.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.voiceRecord1.ResumeLayout(false);
            this.voiceRecord1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1Music;
        private System.Windows.Forms.TabPage tabPlay;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuImageButton backtodefaultButton;
        private AxWMPLib.AxWindowsMediaPlayer playerMusic;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbArtist;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar2;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar3;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuImageButton record;
        private System.Windows.Forms.TabPage tabPage3;
        private VisioForge.Controls.UI.WinForms.VideoCapture voiceRecord1;
        private Bunifu.UI.WinForms.BunifuLabel rcLabel;
        private Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private Bunifu.UI.WinForms.BunifuImageButton stopButton;
        private Bunifu.UI.WinForms.BunifuImageButton startButton;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDuration;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton muteButton;
        private System.Windows.Forms.Label labelTimer;
        private Guna.UI2.WinForms.Guna2ImageButton backButton;
        private Guna.UI2.WinForms.Guna2ImageButton slowButton;
        private Guna.UI2.WinForms.Guna2ImageButton nextButton;
        private Guna.UI2.WinForms.Guna2ImageButton fastButton;
        private Guna.UI2.WinForms.Guna2ImageButton playpauseButton;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider2;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private System.Windows.Forms.TabPage tabDefault;
        private Bunifu.UI.WinForms.BunifuImageButton loopButton;
        private Bunifu.UI.WinForms.BunifuImageButton shuffleButton;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDropdown speedadjustDropBox;
        private Bunifu.UI.WinForms.BunifuImageButton editButton;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuRange range;
    }
}
