namespace SmartFridge
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_Temprature = new System.Windows.Forms.Label();
            this.lbl_WiFi = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_network = new System.Windows.Forms.Label();
            this.btn_OnOff = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_time.Location = new System.Drawing.Point(12, 47);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(131, 24);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Change Date";
            // 
            // lbl_Temprature
            // 
            this.lbl_Temprature.AutoSize = true;
            this.lbl_Temprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Temprature.Location = new System.Drawing.Point(12, 104);
            this.lbl_Temprature.Name = "lbl_Temprature";
            this.lbl_Temprature.Size = new System.Drawing.Size(185, 24);
            this.lbl_Temprature.TabIndex = 1;
            this.lbl_Temprature.Text = "Change Temrature";
            // 
            // lbl_WiFi
            // 
            this.lbl_WiFi.AutoSize = true;
            this.lbl_WiFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_WiFi.Location = new System.Drawing.Point(12, 153);
            this.lbl_WiFi.Name = "lbl_WiFi";
            this.lbl_WiFi.Size = new System.Drawing.Size(121, 24);
            this.lbl_WiFi.TabIndex = 2;
            this.lbl_WiFi.Text = "Wifi settings";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(200, 111);
            this.hScrollBar1.Maximum = 20;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(149, 17);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_temp.Location = new System.Drawing.Point(272, 86);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(30, 16);
            this.lbl_temp.TabIndex = 5;
            this.lbl_temp.Text = "0 C";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(274, 348);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_network
            // 
            this.lbl_network.AutoSize = true;
            this.lbl_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_network.Location = new System.Drawing.Point(235, 161);
            this.lbl_network.Name = "lbl_network";
            this.lbl_network.Size = new System.Drawing.Size(73, 16);
            this.lbl_network.TabIndex = 10;
            this.lbl_network.Text = "Wifi is Off";
            // 
            // btn_OnOff
            // 
            this.btn_OnOff.Location = new System.Drawing.Point(233, 180);
            this.btn_OnOff.Name = "btn_OnOff";
            this.btn_OnOff.Size = new System.Drawing.Size(75, 23);
            this.btn_OnOff.TabIndex = 11;
            this.btn_OnOff.Text = "Set On";
            this.btn_OnOff.UseVisualStyleBackColor = true;
            this.btn_OnOff.Click += new System.EventHandler(this.btn_OnOff_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(12, 357);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 30);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 17;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 399);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btn_OnOff);
            this.Controls.Add(this.lbl_network);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_WiFi);
            this.Controls.Add(this.lbl_Temprature);
            this.Controls.Add(this.lbl_time);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_Temprature;
        private System.Windows.Forms.Label lbl_WiFi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_network;
        private System.Windows.Forms.Button btn_OnOff;
        private System.Windows.Forms.PictureBox info;
    }
}