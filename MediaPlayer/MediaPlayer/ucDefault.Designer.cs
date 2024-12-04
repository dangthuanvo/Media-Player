
namespace MediaPlayer
{
    partial class ucDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDefault));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1Default = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2Default = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1Default = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1Default.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.tumblr_6d09f1e78e33fe992ecee45d0b95183a_d99c79c0_6401;
            this.pictureBox1.Location = new System.Drawing.Point(0, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(940, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1Default
            // 
            this.panel1Default.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.panel1Default.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1Default.BackgroundImage")));
            this.panel1Default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1Default.BorderColor = System.Drawing.Color.Transparent;
            this.panel1Default.BorderRadius = 3;
            this.panel1Default.BorderThickness = 1;
            this.panel1Default.Controls.Add(this.label2Default);
            this.panel1Default.Controls.Add(this.label1Default);
            this.panel1Default.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1Default.Location = new System.Drawing.Point(0, 0);
            this.panel1Default.Name = "panel1Default";
            this.panel1Default.ShowBorders = true;
            this.panel1Default.Size = new System.Drawing.Size(940, 126);
            this.panel1Default.TabIndex = 1;
            // 
            // label2Default
            // 
            this.label2Default.AllowParentOverrides = false;
            this.label2Default.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2Default.AutoEllipsis = false;
            this.label2Default.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2Default.CursorType = System.Windows.Forms.Cursors.Default;
            this.label2Default.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Default.Location = new System.Drawing.Point(275, 59);
            this.label2Default.Name = "label2Default";
            this.label2Default.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2Default.Size = new System.Drawing.Size(376, 21);
            this.label2Default.TabIndex = 1;
            this.label2Default.Text = "A hundred thousand worlds to explore from anywhere";
            this.label2Default.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.label2Default.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1Default
            // 
            this.label1Default.AllowParentOverrides = false;
            this.label1Default.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1Default.AutoEllipsis = false;
            this.label1Default.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1Default.CursorType = System.Windows.Forms.Cursors.Default;
            this.label1Default.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Default.Location = new System.Drawing.Point(350, 23);
            this.label1Default.Name = "label1Default";
            this.label1Default.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1Default.Size = new System.Drawing.Size(205, 30);
            this.label1Default.TabIndex = 0;
            this.label1Default.Text = "Welcome to MIU";
            this.label1Default.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.label1Default.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ucDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1Default);
            this.Name = "ucDefault";
            this.Size = new System.Drawing.Size(940, 520);
            this.Load += new System.EventHandler(this.ucDefault_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1Default.ResumeLayout(false);
            this.panel1Default.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panel1Default;
        private Bunifu.UI.WinForms.BunifuLabel label2Default;
        private Bunifu.UI.WinForms.BunifuLabel label1Default;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
