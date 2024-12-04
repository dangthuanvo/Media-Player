
namespace MediaPlayer
{
    partial class ucYoutube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucYoutube));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.tabGlobal = new System.Windows.Forms.TabControl();
            this.tabdfVideo = new System.Windows.Forms.TabPage();
            this.tabGG = new System.Windows.Forms.TabPage();
            this.googleButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.backButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.forwardButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.youtubeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.searchTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.backtodefaultButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.downloadmp3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.downloadmp4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.tabGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPlay
            // 
            this.tabPlay.Location = new System.Drawing.Point(4, 22);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlay.Size = new System.Drawing.Size(932, 441);
            this.tabPlay.TabIndex = 1;
            this.tabPlay.Text = "tabPlay";
            this.tabPlay.UseVisualStyleBackColor = true;
            // 
            // tabGlobal
            // 
            this.tabGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGlobal.Controls.Add(this.tabdfVideo);
            this.tabGlobal.Controls.Add(this.tabPlay);
            this.tabGlobal.Controls.Add(this.tabGG);
            this.tabGlobal.Location = new System.Drawing.Point(0, 53);
            this.tabGlobal.Name = "tabGlobal";
            this.tabGlobal.SelectedIndex = 0;
            this.tabGlobal.Size = new System.Drawing.Size(940, 467);
            this.tabGlobal.TabIndex = 0;
            // 
            // tabdfVideo
            // 
            this.tabdfVideo.BackgroundImage = global::MediaPlayer.Properties.Resources.bgYtb;
            this.tabdfVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabdfVideo.Location = new System.Drawing.Point(4, 22);
            this.tabdfVideo.Name = "tabdfVideo";
            this.tabdfVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabdfVideo.Size = new System.Drawing.Size(932, 441);
            this.tabdfVideo.TabIndex = 0;
            this.tabdfVideo.Text = "tabdfVideo";
            this.tabdfVideo.UseVisualStyleBackColor = true;
            // 
            // tabGG
            // 
            this.tabGG.Location = new System.Drawing.Point(4, 22);
            this.tabGG.Name = "tabGG";
            this.tabGG.Padding = new System.Windows.Forms.Padding(3);
            this.tabGG.Size = new System.Drawing.Size(932, 441);
            this.tabGG.TabIndex = 2;
            this.tabGG.Text = "tabGG";
            this.tabGG.UseVisualStyleBackColor = true;
            // 
            // googleButton
            // 
            this.googleButton.ActiveImage = null;
            this.googleButton.AllowAnimations = true;
            this.googleButton.AllowBuffering = false;
            this.googleButton.AllowToggling = false;
            this.googleButton.AllowZooming = false;
            this.googleButton.AllowZoomingOnFocus = false;
            this.googleButton.BackColor = System.Drawing.Color.Transparent;
            this.googleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.googleButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("googleButton.ErrorImage")));
            this.googleButton.FadeWhenInactive = false;
            this.googleButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.googleButton.Image = global::MediaPlayer.Properties.Resources.google_24px;
            this.googleButton.ImageActive = null;
            this.googleButton.ImageLocation = null;
            this.googleButton.ImageMargin = 20;
            this.googleButton.ImageSize = new System.Drawing.Size(30, 30);
            this.googleButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.googleButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("googleButton.InitialImage")));
            this.googleButton.Location = new System.Drawing.Point(63, 3);
            this.googleButton.Name = "googleButton";
            this.googleButton.Rotation = 0;
            this.googleButton.ShowActiveImage = true;
            this.googleButton.ShowCursorChanges = true;
            this.googleButton.ShowImageBorders = true;
            this.googleButton.ShowSizeMarkers = false;
            this.googleButton.Size = new System.Drawing.Size(50, 50);
            this.googleButton.TabIndex = 9;
            this.googleButton.ToolTipText = "";
            this.googleButton.WaitOnLoad = false;
            this.googleButton.Zoom = 20;
            this.googleButton.ZoomSpeed = 10;
            this.googleButton.Click += new System.EventHandler(this.googleButton_Click);
            // 
            // backButton
            // 
            this.backButton.ActiveImage = null;
            this.backButton.AllowAnimations = true;
            this.backButton.AllowBuffering = false;
            this.backButton.AllowToggling = false;
            this.backButton.AllowZooming = false;
            this.backButton.AllowZoomingOnFocus = false;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backButton.ErrorImage")));
            this.backButton.FadeWhenInactive = false;
            this.backButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.backButton.Image = global::MediaPlayer.Properties.Resources.left_32px;
            this.backButton.ImageActive = null;
            this.backButton.ImageLocation = null;
            this.backButton.ImageMargin = 20;
            this.backButton.ImageSize = new System.Drawing.Size(30, 30);
            this.backButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.backButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("backButton.InitialImage")));
            this.backButton.Location = new System.Drawing.Point(175, 3);
            this.backButton.Name = "backButton";
            this.backButton.Rotation = 0;
            this.backButton.ShowActiveImage = true;
            this.backButton.ShowCursorChanges = true;
            this.backButton.ShowImageBorders = true;
            this.backButton.ShowSizeMarkers = false;
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 10;
            this.backButton.ToolTipText = "";
            this.backButton.WaitOnLoad = false;
            this.backButton.Zoom = 20;
            this.backButton.ZoomSpeed = 10;
            this.backButton.Click += new System.EventHandler(this.back_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.ActiveImage = null;
            this.forwardButton.AllowAnimations = true;
            this.forwardButton.AllowBuffering = false;
            this.forwardButton.AllowToggling = false;
            this.forwardButton.AllowZooming = false;
            this.forwardButton.AllowZoomingOnFocus = false;
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forwardButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.ErrorImage")));
            this.forwardButton.FadeWhenInactive = false;
            this.forwardButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.forwardButton.Image = global::MediaPlayer.Properties.Resources.right_32px;
            this.forwardButton.ImageActive = null;
            this.forwardButton.ImageLocation = null;
            this.forwardButton.ImageMargin = 20;
            this.forwardButton.ImageSize = new System.Drawing.Size(30, 30);
            this.forwardButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.forwardButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.InitialImage")));
            this.forwardButton.Location = new System.Drawing.Point(231, 3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Rotation = 0;
            this.forwardButton.ShowActiveImage = true;
            this.forwardButton.ShowCursorChanges = true;
            this.forwardButton.ShowImageBorders = true;
            this.forwardButton.ShowSizeMarkers = false;
            this.forwardButton.Size = new System.Drawing.Size(50, 50);
            this.forwardButton.TabIndex = 9;
            this.forwardButton.ToolTipText = "";
            this.forwardButton.WaitOnLoad = false;
            this.forwardButton.Zoom = 20;
            this.forwardButton.ZoomSpeed = 10;
            this.forwardButton.Click += new System.EventHandler(this.forward_Click);
            // 
            // youtubeButton
            // 
            this.youtubeButton.ActiveImage = null;
            this.youtubeButton.AllowAnimations = true;
            this.youtubeButton.AllowBuffering = false;
            this.youtubeButton.AllowToggling = false;
            this.youtubeButton.AllowZooming = false;
            this.youtubeButton.AllowZoomingOnFocus = false;
            this.youtubeButton.BackColor = System.Drawing.Color.Transparent;
            this.youtubeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.youtubeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("youtubeButton.ErrorImage")));
            this.youtubeButton.FadeWhenInactive = false;
            this.youtubeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.youtubeButton.Image = global::MediaPlayer.Properties.Resources.youtube_logo_32px;
            this.youtubeButton.ImageActive = null;
            this.youtubeButton.ImageLocation = null;
            this.youtubeButton.ImageMargin = 20;
            this.youtubeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.youtubeButton.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.youtubeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("youtubeButton.InitialImage")));
            this.youtubeButton.Location = new System.Drawing.Point(7, 3);
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.Rotation = 0;
            this.youtubeButton.ShowActiveImage = true;
            this.youtubeButton.ShowCursorChanges = true;
            this.youtubeButton.ShowImageBorders = true;
            this.youtubeButton.ShowSizeMarkers = false;
            this.youtubeButton.Size = new System.Drawing.Size(50, 50);
            this.youtubeButton.TabIndex = 8;
            this.youtubeButton.ToolTipText = "";
            this.youtubeButton.WaitOnLoad = false;
            this.youtubeButton.Zoom = 20;
            this.youtubeButton.ZoomSpeed = 10;
            this.youtubeButton.Click += new System.EventHandler(this.youtube_Click);
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
            this.btnSearch.TabIndex = 7;
            this.btnSearch.ToolTipText = "";
            this.btnSearch.WaitOnLoad = false;
            this.btnSearch.Zoom = 20;
            this.btnSearch.ZoomSpeed = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AcceptsReturn = false;
            this.searchTextBox.AcceptsTab = false;
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.AnimationSpeed = 200;
            this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchTextBox.AutoSizeHeight = true;
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
            this.searchTextBox.BorderColorActive = System.Drawing.Color.Crimson;
            this.searchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchTextBox.BorderRadius = 1;
            this.searchTextBox.BorderThickness = 1;
            this.searchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.FillColor = System.Drawing.Color.White;
            this.searchTextBox.HideSelection = true;
            this.searchTextBox.IconLeft = null;
            this.searchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.IconPadding = 10;
            this.searchTextBox.IconRight = null;
            this.searchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(717, 8);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchTextBox.Modified = false;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.Crimson;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextBox.OnIdleState = stateProperties8;
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchTextBox.PlaceholderText = "Bạn đang tìm gì?";
            this.searchTextBox.ReadOnly = false;
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(217, 39);
            this.searchTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextBox.TextMarginBottom = 0;
            this.searchTextBox.TextMarginLeft = 3;
            this.searchTextBox.TextMarginTop = 1;
            this.searchTextBox.TextPlaceholder = "Bạn đang tìm gì?";
            this.searchTextBox.UseSystemPasswordChar = false;
            this.searchTextBox.WordWrap = true;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
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
            this.backtodefaultButton.Location = new System.Drawing.Point(119, 3);
            this.backtodefaultButton.Name = "backtodefaultButton";
            this.backtodefaultButton.Rotation = 0;
            this.backtodefaultButton.ShowActiveImage = true;
            this.backtodefaultButton.ShowCursorChanges = true;
            this.backtodefaultButton.ShowImageBorders = true;
            this.backtodefaultButton.ShowSizeMarkers = false;
            this.backtodefaultButton.Size = new System.Drawing.Size(50, 50);
            this.backtodefaultButton.TabIndex = 5;
            this.backtodefaultButton.ToolTipText = "";
            this.backtodefaultButton.WaitOnLoad = false;
            this.backtodefaultButton.Zoom = 20;
            this.backtodefaultButton.ZoomSpeed = 10;
            this.backtodefaultButton.Click += new System.EventHandler(this.backtodefaultButton_Click);
            // 
            // downloadLabel
            // 
            this.downloadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadLabel.Location = new System.Drawing.Point(172, 20);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(85, 16);
            this.downloadLabel.TabIndex = 11;
            this.downloadLabel.Text = "Trạng thái tải";
            // 
            // downloadmp3
            // 
            this.downloadmp3.ActiveImage = null;
            this.downloadmp3.AllowAnimations = true;
            this.downloadmp3.AllowBuffering = false;
            this.downloadmp3.AllowToggling = false;
            this.downloadmp3.AllowZooming = false;
            this.downloadmp3.AllowZoomingOnFocus = false;
            this.downloadmp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadmp3.BackColor = System.Drawing.Color.Transparent;
            this.downloadmp3.BackgroundImage = global::MediaPlayer.Properties.Resources.audio_file_26px;
            this.downloadmp3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.downloadmp3.ErrorImage = null;
            this.downloadmp3.FadeWhenInactive = false;
            this.downloadmp3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.downloadmp3.Image = global::MediaPlayer.Properties.Resources.audio_file_26px;
            this.downloadmp3.ImageActive = null;
            this.downloadmp3.ImageLocation = null;
            this.downloadmp3.ImageMargin = 20;
            this.downloadmp3.ImageSize = new System.Drawing.Size(30, 30);
            this.downloadmp3.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.downloadmp3.InitialImage = null;
            this.downloadmp3.Location = new System.Drawing.Point(605, 3);
            this.downloadmp3.Name = "downloadmp3";
            this.downloadmp3.Rotation = 0;
            this.downloadmp3.ShowActiveImage = true;
            this.downloadmp3.ShowCursorChanges = true;
            this.downloadmp3.ShowImageBorders = true;
            this.downloadmp3.ShowSizeMarkers = false;
            this.downloadmp3.Size = new System.Drawing.Size(50, 50);
            this.downloadmp3.TabIndex = 12;
            this.downloadmp3.ToolTipText = "";
            this.downloadmp3.WaitOnLoad = false;
            this.downloadmp3.Zoom = 20;
            this.downloadmp3.ZoomSpeed = 10;
            this.downloadmp3.Click += new System.EventHandler(this.downloadmp3_Click);
            // 
            // downloadmp4
            // 
            this.downloadmp4.ActiveImage = null;
            this.downloadmp4.AllowAnimations = true;
            this.downloadmp4.AllowBuffering = false;
            this.downloadmp4.AllowToggling = false;
            this.downloadmp4.AllowZooming = false;
            this.downloadmp4.AllowZoomingOnFocus = false;
            this.downloadmp4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadmp4.BackColor = System.Drawing.Color.Transparent;
            this.downloadmp4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.downloadmp4.ErrorImage = null;
            this.downloadmp4.FadeWhenInactive = false;
            this.downloadmp4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.downloadmp4.Image = global::MediaPlayer.Properties.Resources.video_file_26px;
            this.downloadmp4.ImageActive = null;
            this.downloadmp4.ImageLocation = null;
            this.downloadmp4.ImageMargin = 20;
            this.downloadmp4.ImageSize = new System.Drawing.Size(30, 30);
            this.downloadmp4.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.downloadmp4.InitialImage = null;
            this.downloadmp4.Location = new System.Drawing.Point(549, 3);
            this.downloadmp4.Name = "downloadmp4";
            this.downloadmp4.Rotation = 0;
            this.downloadmp4.ShowActiveImage = true;
            this.downloadmp4.ShowCursorChanges = true;
            this.downloadmp4.ShowImageBorders = true;
            this.downloadmp4.ShowSizeMarkers = false;
            this.downloadmp4.Size = new System.Drawing.Size(50, 50);
            this.downloadmp4.TabIndex = 13;
            this.downloadmp4.ToolTipText = "";
            this.downloadmp4.WaitOnLoad = false;
            this.downloadmp4.Zoom = 20;
            this.downloadmp4.ZoomSpeed = 10;
            this.downloadmp4.Click += new System.EventHandler(this.downloadmp4_Click);
            // 
            // ucYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downloadmp4);
            this.Controls.Add(this.downloadmp3);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.googleButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.youtubeButton);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.backtodefaultButton);
            this.Controls.Add(this.tabGlobal);
            this.DoubleBuffered = true;
            this.Name = "ucYoutube";
            this.Size = new System.Drawing.Size(940, 520);
            this.Load += new System.EventHandler(this.ucYoutube_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucYoutube_Paint);
            this.tabGlobal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton backtodefaultButton;
        private Bunifu.UI.WinForms.BunifuTextBox searchTextBox;
        private Bunifu.UI.WinForms.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuImageButton youtubeButton;
        private Bunifu.UI.WinForms.BunifuImageButton forwardButton;
        private Bunifu.UI.WinForms.BunifuImageButton backButton;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TabPage tabdfVideo;
        private System.Windows.Forms.TabControl tabGlobal;
        private Bunifu.UI.WinForms.BunifuImageButton googleButton;
        private System.Windows.Forms.Label downloadLabel;
        private Bunifu.UI.WinForms.BunifuImageButton downloadmp3;
        private Bunifu.UI.WinForms.BunifuImageButton downloadmp4;
        private System.Windows.Forms.TabPage tabGG;
    }
}
