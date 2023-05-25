namespace SmartFridge
{
    partial class TV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TV));
            this.pl_TV = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pc_securityCamera = new System.Windows.Forms.PictureBox();
            this.pc_NetFlix = new System.Windows.Forms.PictureBox();
            this.pc_YouTube = new System.Windows.Forms.PictureBox();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_Off = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.PictureBox();
            this.pl_TV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_securityCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_NetFlix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_YouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_TV
            // 
            this.pl_TV.AutoScroll = true;
            this.pl_TV.BackColor = System.Drawing.Color.Black;
            this.pl_TV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_TV.Controls.Add(this.webBrowser1);
            this.pl_TV.Controls.Add(this.pc_securityCamera);
            this.pl_TV.Controls.Add(this.pc_NetFlix);
            this.pl_TV.Controls.Add(this.pc_YouTube);
            this.pl_TV.Location = new System.Drawing.Point(61, 43);
            this.pl_TV.MaximumSize = new System.Drawing.Size(872, 355);
            this.pl_TV.MinimumSize = new System.Drawing.Size(872, 355);
            this.pl_TV.Name = "pl_TV";
            this.pl_TV.Size = new System.Drawing.Size(872, 355);
            this.pl_TV.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(862, 345);
            this.webBrowser1.TabIndex = 3;
            // 
            // pc_securityCamera
            // 
            this.pc_securityCamera.Image = ((System.Drawing.Image)(resources.GetObject("pc_securityCamera.Image")));
            this.pc_securityCamera.Location = new System.Drawing.Point(701, 38);
            this.pc_securityCamera.Name = "pc_securityCamera";
            this.pc_securityCamera.Size = new System.Drawing.Size(142, 92);
            this.pc_securityCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_securityCamera.TabIndex = 2;
            this.pc_securityCamera.TabStop = false;
            this.pc_securityCamera.Click += new System.EventHandler(this.pc_securityCamera_Click);
            // 
            // pc_NetFlix
            // 
            this.pc_NetFlix.Image = ((System.Drawing.Image)(resources.GetObject("pc_NetFlix.Image")));
            this.pc_NetFlix.Location = new System.Drawing.Point(373, 38);
            this.pc_NetFlix.Name = "pc_NetFlix";
            this.pc_NetFlix.Size = new System.Drawing.Size(142, 92);
            this.pc_NetFlix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_NetFlix.TabIndex = 1;
            this.pc_NetFlix.TabStop = false;
            this.pc_NetFlix.Click += new System.EventHandler(this.pc_NetFlix_Click);
            // 
            // pc_YouTube
            // 
            this.pc_YouTube.Image = ((System.Drawing.Image)(resources.GetObject("pc_YouTube.Image")));
            this.pc_YouTube.Location = new System.Drawing.Point(37, 38);
            this.pc_YouTube.Name = "pc_YouTube";
            this.pc_YouTube.Size = new System.Drawing.Size(142, 92);
            this.pc_YouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_YouTube.TabIndex = 0;
            this.pc_YouTube.TabStop = false;
            this.pc_YouTube.Click += new System.EventHandler(this.pc_YouTube_Click);
            // 
            // btn_on
            // 
            this.btn_on.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_on.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_on.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_on.Location = new System.Drawing.Point(437, 425);
            this.btn_on.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_on.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(75, 23);
            this.btn_on.TabIndex = 1;
            this.btn_on.Text = "On";
            this.btn_on.UseVisualStyleBackColor = false;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_Off
            // 
            this.btn_Off.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Off.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Off.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Off.Location = new System.Drawing.Point(532, 425);
            this.btn_Off.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_Off.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_Off.Name = "btn_Off";
            this.btn_Off.Size = new System.Drawing.Size(75, 23);
            this.btn_Off.TabIndex = 2;
            this.btn_Off.Text = "Off";
            this.btn_Off.UseVisualStyleBackColor = false;
            this.btn_Off.Click += new System.EventHandler(this.btn_Off_Click);
            // 
            // btn_
            // 
            this.btn_.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_.Location = new System.Drawing.Point(341, 425);
            this.btn_.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(75, 23);
            this.btn_.TabIndex = 3;
            this.btn_.Text = "Back";
            this.btn_.UseVisualStyleBackColor = false;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(693, 428);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(43, 37);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 17;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 477);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_Off);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.pl_TV);
            this.Name = "TV";
            this.Text = "TV";
            this.Load += new System.EventHandler(this.TV_Load);
            this.pl_TV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_securityCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_NetFlix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_YouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_TV;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_Off;
        private System.Windows.Forms.PictureBox pc_securityCamera;
        private System.Windows.Forms.PictureBox pc_NetFlix;
        private System.Windows.Forms.PictureBox pc_YouTube;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.PictureBox info;
    }
}