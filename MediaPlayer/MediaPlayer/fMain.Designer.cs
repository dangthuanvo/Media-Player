
namespace MediaPlayer
{
    partial class fMain
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ucDefault1 = new MediaPlayer.ucDefault();
            this.ucVideo1 = new MediaPlayer.ucVideo();
            this.ucMusic1 = new MediaPlayer.ucMusic();
            this.ucPicture1 = new MediaPlayer.ucPicture();
            this.ucHome1 = new MediaPlayer.ucHome();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.historyButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.YoutubeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.logoutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.returnButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.settingButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.quitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.musicButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.videoButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.homeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.border = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuToggleSwitch1 = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.hellolb = new System.Windows.Forms.Label();
            this.progressBar = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.minButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.exitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.maxButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.logoMain = new System.Windows.Forms.PictureBox();
            this.ctrLB = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainPanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.ucDefault1);
            this.mainPanel.Controls.Add(this.ucVideo1);
            this.mainPanel.Controls.Add(this.ucMusic1);
            this.mainPanel.Controls.Add(this.ucPicture1);
            this.mainPanel.Controls.Add(this.ucHome1);
            this.bunifuTransition1.SetDecoration(this.mainPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.mainPanel.Location = new System.Drawing.Point(57, 37);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(940, 520);
            this.mainPanel.TabIndex = 4;
            // 
            // ucDefault1
            // 
            this.ucDefault1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuTransition1.SetDecoration(this.ucDefault1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ucDefault1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDefault1.Location = new System.Drawing.Point(0, 0);
            this.ucDefault1.Name = "ucDefault1";
            this.ucDefault1.Size = new System.Drawing.Size(940, 520);
            this.ucDefault1.TabIndex = 0;
            // 
            // ucVideo1
            // 
            this.ucVideo1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.ucVideo1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ucVideo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVideo1.Location = new System.Drawing.Point(0, 0);
            this.ucVideo1.Name = "ucVideo1";
            this.ucVideo1.Size = new System.Drawing.Size(940, 520);
            this.ucVideo1.TabIndex = 4;
            // 
            // ucMusic1
            // 
            this.ucMusic1.BackColor = System.Drawing.Color.White;
            this.ucMusic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.ucMusic1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ucMusic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMusic1.Location = new System.Drawing.Point(0, 0);
            this.ucMusic1.Name = "ucMusic1";
            this.ucMusic1.Size = new System.Drawing.Size(940, 520);
            this.ucMusic1.TabIndex = 2;
            // 
            // ucPicture1
            // 
            this.ucPicture1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.ucPicture1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ucPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPicture1.Location = new System.Drawing.Point(0, 0);
            this.ucPicture1.Name = "ucPicture1";
            this.ucPicture1.Size = new System.Drawing.Size(940, 520);
            this.ucPicture1.TabIndex = 5;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.Transparent;
            this.ucHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.ucHome1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(940, 520);
            this.ucHome1.TabIndex = 1;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Indigo;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.historyButton);
            this.bunifuPanel2.Controls.Add(this.YoutubeButton);
            this.bunifuPanel2.Controls.Add(this.logoutButton);
            this.bunifuPanel2.Controls.Add(this.returnButton);
            this.bunifuPanel2.Controls.Add(this.settingButton);
            this.bunifuPanel2.Controls.Add(this.quitButton);
            this.bunifuPanel2.Controls.Add(this.musicButton);
            this.bunifuPanel2.Controls.Add(this.pictureButton);
            this.bunifuPanel2.Controls.Add(this.videoButton);
            this.bunifuPanel2.Controls.Add(this.homeButton);
            this.bunifuTransition1.SetDecoration(this.bunifuPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(57, 560);
            this.bunifuPanel2.TabIndex = 3;
            // 
            // historyButton
            // 
            this.historyButton.ActiveImage = null;
            this.historyButton.AllowAnimations = true;
            this.historyButton.AllowBuffering = false;
            this.historyButton.AllowToggling = false;
            this.historyButton.AllowZooming = true;
            this.historyButton.AllowZoomingOnFocus = false;
            this.historyButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.historyButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.historyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.historyButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("historyButton.ErrorImage")));
            this.historyButton.FadeWhenInactive = false;
            this.historyButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.historyButton.Image = global::MediaPlayer.Properties.Resources.order_history_32px;
            this.historyButton.ImageActive = null;
            this.historyButton.ImageLocation = null;
            this.historyButton.ImageMargin = 20;
            this.historyButton.ImageSize = new System.Drawing.Size(30, 30);
            this.historyButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.historyButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("historyButton.InitialImage")));
            this.historyButton.Location = new System.Drawing.Point(3, 313);
            this.historyButton.Name = "historyButton";
            this.historyButton.Rotation = 0;
            this.historyButton.ShowActiveImage = true;
            this.historyButton.ShowCursorChanges = true;
            this.historyButton.ShowImageBorders = true;
            this.historyButton.ShowSizeMarkers = false;
            this.historyButton.Size = new System.Drawing.Size(50, 50);
            this.historyButton.TabIndex = 7;
            this.historyButton.ToolTipText = "";
            this.historyButton.WaitOnLoad = false;
            this.historyButton.Zoom = 20;
            this.historyButton.ZoomSpeed = 10;
            this.historyButton.ZoomedIn += new System.EventHandler(this.historyIn);
            this.historyButton.ZoomedOut += new System.EventHandler(this.historyOut);
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // YoutubeButton
            // 
            this.YoutubeButton.ActiveImage = null;
            this.YoutubeButton.AllowAnimations = true;
            this.YoutubeButton.AllowBuffering = false;
            this.YoutubeButton.AllowToggling = false;
            this.YoutubeButton.AllowZooming = true;
            this.YoutubeButton.AllowZoomingOnFocus = false;
            this.YoutubeButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.YoutubeButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.YoutubeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.YoutubeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("YoutubeButton.ErrorImage")));
            this.YoutubeButton.FadeWhenInactive = false;
            this.YoutubeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.YoutubeButton.Image = global::MediaPlayer.Properties.Resources.Cryptocurrency_Global_64px;
            this.YoutubeButton.ImageActive = null;
            this.YoutubeButton.ImageLocation = null;
            this.YoutubeButton.ImageMargin = 20;
            this.YoutubeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.YoutubeButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.YoutubeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("YoutubeButton.InitialImage")));
            this.YoutubeButton.Location = new System.Drawing.Point(3, 257);
            this.YoutubeButton.Name = "YoutubeButton";
            this.YoutubeButton.Rotation = 0;
            this.YoutubeButton.ShowActiveImage = true;
            this.YoutubeButton.ShowCursorChanges = true;
            this.YoutubeButton.ShowImageBorders = true;
            this.YoutubeButton.ShowSizeMarkers = false;
            this.YoutubeButton.Size = new System.Drawing.Size(50, 50);
            this.YoutubeButton.TabIndex = 7;
            this.YoutubeButton.ToolTipText = "";
            this.YoutubeButton.WaitOnLoad = false;
            this.YoutubeButton.Zoom = 20;
            this.YoutubeButton.ZoomSpeed = 10;
            this.YoutubeButton.ZoomedIn += new System.EventHandler(this.YoutubeIn);
            this.YoutubeButton.ZoomedOut += new System.EventHandler(this.YoutubeOut);
            this.YoutubeButton.Click += new System.EventHandler(this.YoutubeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.AllowAnimations = true;
            this.logoutButton.AllowMouseEffects = true;
            this.logoutButton.AllowToggling = false;
            this.logoutButton.AnimationSpeed = 200;
            this.logoutButton.AutoGenerateColors = false;
            this.logoutButton.AutoRoundBorders = false;
            this.logoutButton.AutoSizeLeftIcon = true;
            this.logoutButton.AutoSizeRightIcon = true;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackColor1 = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.logoutButton.ButtonText = "LOG OUT";
            this.logoutButton.ButtonTextMarginLeft = 0;
            this.logoutButton.ColorContrastOnClick = 45;
            this.logoutButton.ColorContrastOnHover = 45;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.logoutButton.CustomizableEdges = borderEdges1;
            this.bunifuTransition1.SetDecoration(this.logoutButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logoutButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logoutButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logoutButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.logoutButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.logoutButton.IconMarginLeft = 11;
            this.logoutButton.IconPadding = 10;
            this.logoutButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.logoutButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.logoutButton.IconSize = 25;
            this.logoutButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.IdleBorderRadius = 1;
            this.logoutButton.IdleBorderThickness = 1;
            this.logoutButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.logoutButton.IdleIconLeftImage = null;
            this.logoutButton.IdleIconRightImage = null;
            this.logoutButton.IndicateFocus = false;
            this.logoutButton.Location = new System.Drawing.Point(0, 443);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.logoutButton.OnDisabledState.BorderRadius = 1;
            this.logoutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.logoutButton.OnDisabledState.BorderThickness = 1;
            this.logoutButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.logoutButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.logoutButton.OnDisabledState.IconLeftImage = null;
            this.logoutButton.OnDisabledState.IconRightImage = null;
            this.logoutButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logoutButton.onHoverState.BorderRadius = 1;
            this.logoutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.logoutButton.onHoverState.BorderThickness = 1;
            this.logoutButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.logoutButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.logoutButton.onHoverState.IconLeftImage = null;
            this.logoutButton.onHoverState.IconRightImage = null;
            this.logoutButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.OnIdleState.BorderRadius = 1;
            this.logoutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.logoutButton.OnIdleState.BorderThickness = 1;
            this.logoutButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.logoutButton.OnIdleState.IconLeftImage = null;
            this.logoutButton.OnIdleState.IconRightImage = null;
            this.logoutButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logoutButton.OnPressedState.BorderRadius = 1;
            this.logoutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.logoutButton.OnPressedState.BorderThickness = 1;
            this.logoutButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.logoutButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.logoutButton.OnPressedState.IconLeftImage = null;
            this.logoutButton.OnPressedState.IconRightImage = null;
            this.logoutButton.Size = new System.Drawing.Size(57, 39);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.logoutButton.TextMarginLeft = 0;
            this.logoutButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.logoutButton.UseDefaultRadiusAndThickness = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.ActiveImage = null;
            this.returnButton.AllowAnimations = true;
            this.returnButton.AllowBuffering = false;
            this.returnButton.AllowToggling = false;
            this.returnButton.AllowZooming = true;
            this.returnButton.AllowZoomingOnFocus = false;
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.returnButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.returnButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returnButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("returnButton.ErrorImage")));
            this.returnButton.FadeWhenInactive = false;
            this.returnButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.ImageActive = null;
            this.returnButton.ImageLocation = null;
            this.returnButton.ImageMargin = 20;
            this.returnButton.ImageSize = new System.Drawing.Size(30, 30);
            this.returnButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.returnButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("returnButton.InitialImage")));
            this.returnButton.Location = new System.Drawing.Point(3, 369);
            this.returnButton.Name = "returnButton";
            this.returnButton.Rotation = 0;
            this.returnButton.ShowActiveImage = true;
            this.returnButton.ShowCursorChanges = true;
            this.returnButton.ShowImageBorders = true;
            this.returnButton.ShowSizeMarkers = false;
            this.returnButton.Size = new System.Drawing.Size(50, 50);
            this.returnButton.TabIndex = 6;
            this.returnButton.ToolTipText = "";
            this.returnButton.WaitOnLoad = false;
            this.returnButton.Zoom = 20;
            this.returnButton.ZoomSpeed = 10;
            this.returnButton.Click += new System.EventHandler(this.returnButtonHome_Click);
            // 
            // settingButton
            // 
            this.settingButton.AllowAnimations = true;
            this.settingButton.AllowMouseEffects = true;
            this.settingButton.AllowToggling = false;
            this.settingButton.AnimationSpeed = 200;
            this.settingButton.AutoGenerateColors = false;
            this.settingButton.AutoRoundBorders = false;
            this.settingButton.AutoSizeLeftIcon = true;
            this.settingButton.AutoSizeRightIcon = true;
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.BackColor1 = System.Drawing.Color.Transparent;
            this.settingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingButton.BackgroundImage")));
            this.settingButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.settingButton.ButtonText = "SETTING";
            this.settingButton.ButtonTextMarginLeft = 0;
            this.settingButton.ColorContrastOnClick = 45;
            this.settingButton.ColorContrastOnHover = 45;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.settingButton.CustomizableEdges = borderEdges2;
            this.bunifuTransition1.SetDecoration(this.settingButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.settingButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.settingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingButton.ForeColor = System.Drawing.Color.White;
            this.settingButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.settingButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.settingButton.IconMarginLeft = 11;
            this.settingButton.IconPadding = 10;
            this.settingButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.settingButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.settingButton.IconSize = 25;
            this.settingButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.settingButton.IdleBorderRadius = 1;
            this.settingButton.IdleBorderThickness = 1;
            this.settingButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.settingButton.IdleIconLeftImage = null;
            this.settingButton.IdleIconRightImage = null;
            this.settingButton.IndicateFocus = false;
            this.settingButton.Location = new System.Drawing.Point(0, 482);
            this.settingButton.Name = "settingButton";
            this.settingButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.settingButton.OnDisabledState.BorderRadius = 1;
            this.settingButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.settingButton.OnDisabledState.BorderThickness = 1;
            this.settingButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.settingButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.settingButton.OnDisabledState.IconLeftImage = null;
            this.settingButton.OnDisabledState.IconRightImage = null;
            this.settingButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.settingButton.onHoverState.BorderRadius = 1;
            this.settingButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.settingButton.onHoverState.BorderThickness = 1;
            this.settingButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.settingButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.settingButton.onHoverState.IconLeftImage = null;
            this.settingButton.onHoverState.IconRightImage = null;
            this.settingButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.settingButton.OnIdleState.BorderRadius = 1;
            this.settingButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.settingButton.OnIdleState.BorderThickness = 1;
            this.settingButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.settingButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.settingButton.OnIdleState.IconLeftImage = null;
            this.settingButton.OnIdleState.IconRightImage = null;
            this.settingButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.settingButton.OnPressedState.BorderRadius = 1;
            this.settingButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.settingButton.OnPressedState.BorderThickness = 1;
            this.settingButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.settingButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.settingButton.OnPressedState.IconLeftImage = null;
            this.settingButton.OnPressedState.IconRightImage = null;
            this.settingButton.Size = new System.Drawing.Size(57, 39);
            this.settingButton.TabIndex = 2;
            this.settingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingButton.TextMarginLeft = 0;
            this.settingButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.settingButton.UseDefaultRadiusAndThickness = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click_1);
            // 
            // quitButton
            // 
            this.quitButton.AllowAnimations = true;
            this.quitButton.AllowMouseEffects = true;
            this.quitButton.AllowToggling = false;
            this.quitButton.AnimationSpeed = 200;
            this.quitButton.AutoGenerateColors = false;
            this.quitButton.AutoRoundBorders = false;
            this.quitButton.AutoSizeLeftIcon = true;
            this.quitButton.AutoSizeRightIcon = true;
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackColor1 = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitButton.BackgroundImage")));
            this.quitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.quitButton.ButtonText = "QUIT";
            this.quitButton.ButtonTextMarginLeft = 0;
            this.quitButton.ColorContrastOnClick = 45;
            this.quitButton.ColorContrastOnHover = 45;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.quitButton.CustomizableEdges = borderEdges3;
            this.bunifuTransition1.SetDecoration(this.quitButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.quitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.quitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.quitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.quitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quitButton.ForeColor = System.Drawing.Color.Transparent;
            this.quitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.quitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.quitButton.IconMarginLeft = 11;
            this.quitButton.IconPadding = 10;
            this.quitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.quitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.quitButton.IconSize = 25;
            this.quitButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.quitButton.IdleBorderRadius = 1;
            this.quitButton.IdleBorderThickness = 1;
            this.quitButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.quitButton.IdleIconLeftImage = null;
            this.quitButton.IdleIconRightImage = null;
            this.quitButton.IndicateFocus = false;
            this.quitButton.Location = new System.Drawing.Point(0, 521);
            this.quitButton.Name = "quitButton";
            this.quitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.quitButton.OnDisabledState.BorderRadius = 1;
            this.quitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.quitButton.OnDisabledState.BorderThickness = 1;
            this.quitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.quitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.quitButton.OnDisabledState.IconLeftImage = null;
            this.quitButton.OnDisabledState.IconRightImage = null;
            this.quitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.quitButton.onHoverState.BorderRadius = 1;
            this.quitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.quitButton.onHoverState.BorderThickness = 1;
            this.quitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.quitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.quitButton.onHoverState.IconLeftImage = null;
            this.quitButton.onHoverState.IconRightImage = null;
            this.quitButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.quitButton.OnIdleState.BorderRadius = 1;
            this.quitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.quitButton.OnIdleState.BorderThickness = 1;
            this.quitButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.quitButton.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.quitButton.OnIdleState.IconLeftImage = null;
            this.quitButton.OnIdleState.IconRightImage = null;
            this.quitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.quitButton.OnPressedState.BorderRadius = 1;
            this.quitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.quitButton.OnPressedState.BorderThickness = 1;
            this.quitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.quitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.quitButton.OnPressedState.IconLeftImage = null;
            this.quitButton.OnPressedState.IconRightImage = null;
            this.quitButton.Size = new System.Drawing.Size(57, 39);
            this.quitButton.TabIndex = 1;
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.quitButton.TextMarginLeft = 0;
            this.quitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.quitButton.UseDefaultRadiusAndThickness = true;
            this.quitButton.Click += new System.EventHandler(this.helpButton_Click_1);
            // 
            // musicButton
            // 
            this.musicButton.ActiveImage = null;
            this.musicButton.AllowAnimations = true;
            this.musicButton.AllowBuffering = false;
            this.musicButton.AllowToggling = false;
            this.musicButton.AllowZooming = true;
            this.musicButton.AllowZoomingOnFocus = false;
            this.musicButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.musicButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.musicButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.musicButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("musicButton.ErrorImage")));
            this.musicButton.FadeWhenInactive = false;
            this.musicButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.musicButton.Image = ((System.Drawing.Image)(resources.GetObject("musicButton.Image")));
            this.musicButton.ImageActive = null;
            this.musicButton.ImageLocation = null;
            this.musicButton.ImageMargin = 20;
            this.musicButton.ImageSize = new System.Drawing.Size(30, 30);
            this.musicButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.musicButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("musicButton.InitialImage")));
            this.musicButton.Location = new System.Drawing.Point(3, 145);
            this.musicButton.Name = "musicButton";
            this.musicButton.Rotation = 0;
            this.musicButton.ShowActiveImage = true;
            this.musicButton.ShowCursorChanges = true;
            this.musicButton.ShowImageBorders = true;
            this.musicButton.ShowSizeMarkers = false;
            this.musicButton.Size = new System.Drawing.Size(50, 50);
            this.musicButton.TabIndex = 2;
            this.musicButton.ToolTipText = "";
            this.musicButton.WaitOnLoad = false;
            this.musicButton.Zoom = 20;
            this.musicButton.ZoomSpeed = 10;
            this.musicButton.ZoomedIn += new System.EventHandler(this.musicIn);
            this.musicButton.ZoomedOut += new System.EventHandler(this.musicOut);
            this.musicButton.Click += new System.EventHandler(this.musicClick);
            // 
            // pictureButton
            // 
            this.pictureButton.ActiveImage = null;
            this.pictureButton.AllowAnimations = true;
            this.pictureButton.AllowBuffering = false;
            this.pictureButton.AllowToggling = false;
            this.pictureButton.AllowZooming = true;
            this.pictureButton.AllowZoomingOnFocus = false;
            this.pictureButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.pictureButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pictureButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureButton.ErrorImage")));
            this.pictureButton.FadeWhenInactive = false;
            this.pictureButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.pictureButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureButton.Image")));
            this.pictureButton.ImageActive = null;
            this.pictureButton.ImageLocation = null;
            this.pictureButton.ImageMargin = 20;
            this.pictureButton.ImageSize = new System.Drawing.Size(30, 30);
            this.pictureButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.pictureButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureButton.InitialImage")));
            this.pictureButton.Location = new System.Drawing.Point(3, 201);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Rotation = 0;
            this.pictureButton.ShowActiveImage = true;
            this.pictureButton.ShowCursorChanges = true;
            this.pictureButton.ShowImageBorders = true;
            this.pictureButton.ShowSizeMarkers = false;
            this.pictureButton.Size = new System.Drawing.Size(50, 50);
            this.pictureButton.TabIndex = 1;
            this.pictureButton.ToolTipText = "";
            this.pictureButton.WaitOnLoad = false;
            this.pictureButton.Zoom = 20;
            this.pictureButton.ZoomSpeed = 10;
            this.pictureButton.ZoomedIn += new System.EventHandler(this.pictureIn);
            this.pictureButton.ZoomedOut += new System.EventHandler(this.pictureOut);
            this.pictureButton.Click += new System.EventHandler(this.pictureClick);
            // 
            // videoButton
            // 
            this.videoButton.ActiveImage = null;
            this.videoButton.AllowAnimations = true;
            this.videoButton.AllowBuffering = false;
            this.videoButton.AllowToggling = false;
            this.videoButton.AllowZooming = true;
            this.videoButton.AllowZoomingOnFocus = false;
            this.videoButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.videoButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.videoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.videoButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("videoButton.ErrorImage")));
            this.videoButton.FadeWhenInactive = false;
            this.videoButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.videoButton.Image = ((System.Drawing.Image)(resources.GetObject("videoButton.Image")));
            this.videoButton.ImageActive = null;
            this.videoButton.ImageLocation = null;
            this.videoButton.ImageMargin = 20;
            this.videoButton.ImageSize = new System.Drawing.Size(30, 30);
            this.videoButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.videoButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("videoButton.InitialImage")));
            this.videoButton.Location = new System.Drawing.Point(3, 89);
            this.videoButton.Name = "videoButton";
            this.videoButton.Rotation = 0;
            this.videoButton.ShowActiveImage = true;
            this.videoButton.ShowCursorChanges = true;
            this.videoButton.ShowImageBorders = true;
            this.videoButton.ShowSizeMarkers = false;
            this.videoButton.Size = new System.Drawing.Size(50, 50);
            this.videoButton.TabIndex = 1;
            this.videoButton.ToolTipText = "";
            this.videoButton.WaitOnLoad = false;
            this.videoButton.Zoom = 20;
            this.videoButton.ZoomSpeed = 10;
            this.videoButton.ZoomedIn += new System.EventHandler(this.videoIn);
            this.videoButton.ZoomedOut += new System.EventHandler(this.videoOut);
            this.videoButton.Click += new System.EventHandler(this.videoClick);
            // 
            // homeButton
            // 
            this.homeButton.ActiveImage = null;
            this.homeButton.AllowAnimations = true;
            this.homeButton.AllowBuffering = false;
            this.homeButton.AllowToggling = false;
            this.homeButton.AllowZooming = true;
            this.homeButton.AllowZoomingOnFocus = false;
            this.homeButton.BackColor = System.Drawing.Color.Indigo;
            this.bunifuTransition1.SetDecoration(this.homeButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.homeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.homeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("homeButton.ErrorImage")));
            this.homeButton.FadeWhenInactive = false;
            this.homeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageActive = null;
            this.homeButton.ImageLocation = null;
            this.homeButton.ImageMargin = 20;
            this.homeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.homeButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.homeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("homeButton.InitialImage")));
            this.homeButton.Location = new System.Drawing.Point(3, 34);
            this.homeButton.Name = "homeButton";
            this.homeButton.Rotation = 0;
            this.homeButton.ShowActiveImage = true;
            this.homeButton.ShowCursorChanges = true;
            this.homeButton.ShowImageBorders = true;
            this.homeButton.ShowSizeMarkers = false;
            this.homeButton.Size = new System.Drawing.Size(50, 50);
            this.homeButton.TabIndex = 0;
            this.homeButton.ToolTipText = "";
            this.homeButton.WaitOnLoad = false;
            this.homeButton.Zoom = 20;
            this.homeButton.ZoomSpeed = 10;
            this.homeButton.ZoomedIn += new System.EventHandler(this.homeIn);
            this.homeButton.ZoomedOut += new System.EventHandler(this.homeOut);
            this.homeButton.Click += new System.EventHandler(this.homeClick);
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackgroundColor = System.Drawing.Color.Indigo;
            this.border.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("border.BackgroundImage")));
            this.border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.border.BorderColor = System.Drawing.Color.Indigo;
            this.border.BorderRadius = 3;
            this.border.BorderThickness = 1;
            this.border.Controls.Add(this.bunifuToggleSwitch1);
            this.border.Controls.Add(this.hellolb);
            this.border.Controls.Add(this.progressBar);
            this.border.Controls.Add(this.minButton);
            this.border.Controls.Add(this.exitButton);
            this.border.Controls.Add(this.maxButton);
            this.border.Controls.Add(this.logoMain);
            this.border.Controls.Add(this.ctrLB);
            this.bunifuTransition1.SetDecoration(this.border, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Margin = new System.Windows.Forms.Padding(2);
            this.border.Name = "border";
            this.border.ShowBorders = true;
            this.border.Size = new System.Drawing.Size(1000, 37);
            this.border.TabIndex = 2;
            // 
            // bunifuToggleSwitch1
            // 
            this.bunifuToggleSwitch1.Animation = 5;
            this.bunifuToggleSwitch1.AnimationSpeed = 5;
            this.bunifuToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuToggleSwitch1.BackgroundImage")));
            this.bunifuToggleSwitch1.Checked = true;
            this.bunifuToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuToggleSwitch1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuToggleSwitch1.InnerCirclePadding = 3;
            this.bunifuToggleSwitch1.Location = new System.Drawing.Point(846, 10);
            this.bunifuToggleSwitch1.Name = "bunifuToggleSwitch1";
            this.bunifuToggleSwitch1.Size = new System.Drawing.Size(30, 16);
            this.bunifuToggleSwitch1.TabIndex = 6;
            this.bunifuToggleSwitch1.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Empty;
            toggleState2.BackColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState2.BorderColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderRadius = 1;
            toggleState2.BorderRadiusInner = 1;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 15;
            toggleState3.BorderRadiusInner = 9;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOn = toggleState3;
            this.bunifuToggleSwitch1.Value = true;
            this.bunifuToggleSwitch1.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.bunifuToggleSwitch1_CheckedChanged);
            // 
            // hellolb
            // 
            this.hellolb.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.hellolb, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.hellolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellolb.ForeColor = System.Drawing.Color.White;
            this.hellolb.Location = new System.Drawing.Point(63, 9);
            this.hellolb.Name = "hellolb";
            this.hellolb.Size = new System.Drawing.Size(51, 16);
            this.hellolb.TabIndex = 6;
            this.hellolb.Text = "label1";
            // 
            // progressBar
            // 
            this.progressBar.AllowAnimations = false;
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Animation = 0;
            this.progressBar.AnimationSpeed = 220;
            this.progressBar.AnimationStep = 10;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar.BorderRadius = 9;
            this.progressBar.BorderThickness = 1;
            this.bunifuTransition1.SetDecoration(this.progressBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.progressBar.Location = new System.Drawing.Point(378, 9);
            this.progressBar.Maximum = 100;
            this.progressBar.MaximumValue = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.MinimumValue = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.progressBar.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.progressBar.ProgressColorRight = System.Drawing.Color.Indigo;
            this.progressBar.Size = new System.Drawing.Size(292, 13);
            this.progressBar.TabIndex = 4;
            this.progressBar.Value = 50;
            this.progressBar.ValueByTransition = 50;
            // 
            // minButton
            // 
            this.minButton.ActiveImage = null;
            this.minButton.AllowAnimations = true;
            this.minButton.AllowBuffering = false;
            this.minButton.AllowToggling = false;
            this.minButton.AllowZooming = true;
            this.minButton.AllowZoomingOnFocus = false;
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.AutoSize = true;
            this.minButton.BackColor = System.Drawing.Color.Indigo;
            this.minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.minButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.minButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("minButton.ErrorImage")));
            this.minButton.FadeWhenInactive = false;
            this.minButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.minButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.ImageActive = null;
            this.minButton.ImageLocation = null;
            this.minButton.ImageMargin = 20;
            this.minButton.ImageSize = new System.Drawing.Size(15, 13);
            this.minButton.ImageZoomSize = new System.Drawing.Size(35, 33);
            this.minButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("minButton.InitialImage")));
            this.minButton.Location = new System.Drawing.Point(884, 2);
            this.minButton.Margin = new System.Windows.Forms.Padding(2);
            this.minButton.Name = "minButton";
            this.minButton.Rotation = 0;
            this.minButton.ShowActiveImage = true;
            this.minButton.ShowCursorChanges = true;
            this.minButton.ShowImageBorders = true;
            this.minButton.ShowSizeMarkers = false;
            this.minButton.Size = new System.Drawing.Size(35, 33);
            this.minButton.TabIndex = 3;
            this.minButton.ToolTipText = "";
            this.minButton.WaitOnLoad = false;
            this.minButton.Zoom = 20;
            this.minButton.ZoomSpeed = 10;
            this.minButton.Click += new System.EventHandler(this.Minimize);
            // 
            // exitButton
            // 
            this.exitButton.ActiveImage = null;
            this.exitButton.AllowAnimations = true;
            this.exitButton.AllowBuffering = true;
            this.exitButton.AllowToggling = false;
            this.exitButton.AllowZooming = true;
            this.exitButton.AllowZoomingOnFocus = false;
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = true;
            this.exitButton.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.exitButton.BackColor = System.Drawing.Color.Indigo;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.exitButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("exitButton.ErrorImage")));
            this.exitButton.FadeWhenInactive = false;
            this.exitButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.exitButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.ImageLocation = null;
            this.exitButton.ImageMargin = 20;
            this.exitButton.ImageSize = new System.Drawing.Size(15, 13);
            this.exitButton.ImageZoomSize = new System.Drawing.Size(35, 33);
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.exitButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("exitButton.InitialImage")));
            this.exitButton.Location = new System.Drawing.Point(962, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Rotation = 0;
            this.exitButton.ShowActiveImage = true;
            this.exitButton.ShowCursorChanges = true;
            this.exitButton.ShowImageBorders = true;
            this.exitButton.ShowSizeMarkers = false;
            this.exitButton.Size = new System.Drawing.Size(35, 33);
            this.exitButton.TabIndex = 1;
            this.exitButton.ToolTipText = "";
            this.exitButton.WaitOnLoad = false;
            this.exitButton.Zoom = 20;
            this.exitButton.ZoomSpeed = 10;
            this.exitButton.Click += new System.EventHandler(this.Exit);
            // 
            // maxButton
            // 
            this.maxButton.ActiveImage = null;
            this.maxButton.AllowAnimations = true;
            this.maxButton.AllowBuffering = false;
            this.maxButton.AllowToggling = false;
            this.maxButton.AllowZooming = true;
            this.maxButton.AllowZoomingOnFocus = false;
            this.maxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxButton.AutoSize = true;
            this.maxButton.BackColor = System.Drawing.Color.Indigo;
            this.maxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.maxButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.maxButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.maxButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("maxButton.ErrorImage")));
            this.maxButton.FadeWhenInactive = false;
            this.maxButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.maxButton.Image = ((System.Drawing.Image)(resources.GetObject("maxButton.Image")));
            this.maxButton.ImageActive = null;
            this.maxButton.ImageLocation = null;
            this.maxButton.ImageMargin = 20;
            this.maxButton.ImageSize = new System.Drawing.Size(15, 13);
            this.maxButton.ImageZoomSize = new System.Drawing.Size(35, 33);
            this.maxButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("maxButton.InitialImage")));
            this.maxButton.Location = new System.Drawing.Point(923, 2);
            this.maxButton.Margin = new System.Windows.Forms.Padding(2);
            this.maxButton.Name = "maxButton";
            this.maxButton.Rotation = 0;
            this.maxButton.ShowActiveImage = true;
            this.maxButton.ShowCursorChanges = true;
            this.maxButton.ShowImageBorders = true;
            this.maxButton.ShowSizeMarkers = false;
            this.maxButton.Size = new System.Drawing.Size(35, 33);
            this.maxButton.TabIndex = 2;
            this.maxButton.ToolTipText = "";
            this.maxButton.WaitOnLoad = false;
            this.maxButton.Zoom = 20;
            this.maxButton.ZoomSpeed = 10;
            this.maxButton.Click += new System.EventHandler(this.Maximize);
            // 
            // logoMain
            // 
            this.bunifuTransition1.SetDecoration(this.logoMain, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logoMain.Image = ((System.Drawing.Image)(resources.GetObject("logoMain.Image")));
            this.logoMain.Location = new System.Drawing.Point(-19, 0);
            this.logoMain.Name = "logoMain";
            this.logoMain.Size = new System.Drawing.Size(95, 38);
            this.logoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoMain.TabIndex = 4;
            this.logoMain.TabStop = false;
            // 
            // ctrLB
            // 
            this.ctrLB.BackColor = System.Drawing.Color.DarkOrchid;
            this.bunifuTransition1.SetDecoration(this.ctrLB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ctrLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrLB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ctrLB.Location = new System.Drawing.Point(0, 0);
            this.ctrLB.Name = "ctrLB";
            this.ctrLB.Size = new System.Drawing.Size(57, 37);
            this.ctrLB.TabIndex = 5;
            this.ctrLB.Text = "MIU";
            this.ctrLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.border;
            this.bunifuDragControl1.Vertical = true;
            // 
            // fMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.border);
            this.Controls.Add(this.bunifuPanel2);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.Shown += new System.EventHandler(this.fMain_Shown);
            this.SizeChanged += new System.EventHandler(this.fMain_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.fMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.fMain_DragEnter);
            this.mainPanel.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuPanel border;
        private Bunifu.UI.WinForms.BunifuProgressBar progressBar;
        private Bunifu.UI.WinForms.BunifuImageButton minButton;
        public Bunifu.UI.WinForms.BunifuImageButton exitButton;
        private Bunifu.UI.WinForms.BunifuImageButton maxButton;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 settingButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuImageButton returnButton;
        private Bunifu.UI.WinForms.BunifuImageButton pictureButton;
        private Bunifu.UI.WinForms.BunifuImageButton videoButton;
        private Bunifu.UI.WinForms.BunifuImageButton homeButton;
        private System.Windows.Forms.Label ctrLB;
        private System.Windows.Forms.PictureBox logoMain;
        private Bunifu.UI.WinForms.BunifuImageButton musicButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label hellolb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 logoutButton;
        private ucVideo ucVideo1;
        private ucMusic ucMusic1;
        private ucHome ucHome1;
        private ucDefault ucDefault1;
        private Bunifu.UI.WinForms.BunifuImageButton YoutubeButton;
        private Bunifu.UI.WinForms.BunifuImageButton historyButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 quitButton;
        private ucPicture ucPicture1;
        private Bunifu.UI.WinForms.BunifuToggleSwitch bunifuToggleSwitch1;
    }
}