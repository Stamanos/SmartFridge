namespace SmartFridge
{
    partial class House
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(House));
            this.btn_Fridge = new System.Windows.Forms.Button();
            this.pc_light_off_salon = new System.Windows.Forms.PictureBox();
            this.pc_light_on_salon = new System.Windows.Forms.PictureBox();
            this.pc_light_off_kichen = new System.Windows.Forms.PictureBox();
            this.pc_light_on_kichen = new System.Windows.Forms.PictureBox();
            this.btn_television = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_off_salon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_on_salon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_off_kichen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_on_kichen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fridge
            // 
            this.btn_Fridge.Location = new System.Drawing.Point(719, 352);
            this.btn_Fridge.Name = "btn_Fridge";
            this.btn_Fridge.Size = new System.Drawing.Size(75, 23);
            this.btn_Fridge.TabIndex = 1;
            this.btn_Fridge.Text = "Fridge";
            this.btn_Fridge.UseVisualStyleBackColor = true;
            this.btn_Fridge.Click += new System.EventHandler(this.btn_Fridge_Click);
            // 
            // pc_light_off_salon
            // 
            this.pc_light_off_salon.Image = ((System.Drawing.Image)(resources.GetObject("pc_light_off_salon.Image")));
            this.pc_light_off_salon.Location = new System.Drawing.Point(532, 152);
            this.pc_light_off_salon.Name = "pc_light_off_salon";
            this.pc_light_off_salon.Size = new System.Drawing.Size(49, 58);
            this.pc_light_off_salon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_light_off_salon.TabIndex = 2;
            this.pc_light_off_salon.TabStop = false;
            this.pc_light_off_salon.Click += new System.EventHandler(this.pc_light_off_salon_Click);
            // 
            // pc_light_on_salon
            // 
            this.pc_light_on_salon.Image = ((System.Drawing.Image)(resources.GetObject("pc_light_on_salon.Image")));
            this.pc_light_on_salon.Location = new System.Drawing.Point(532, 152);
            this.pc_light_on_salon.Name = "pc_light_on_salon";
            this.pc_light_on_salon.Size = new System.Drawing.Size(58, 58);
            this.pc_light_on_salon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_light_on_salon.TabIndex = 3;
            this.pc_light_on_salon.TabStop = false;
            this.pc_light_on_salon.Click += new System.EventHandler(this.pc_light_on_salon_Click);
            // 
            // pc_light_off_kichen
            // 
            this.pc_light_off_kichen.Image = ((System.Drawing.Image)(resources.GetObject("pc_light_off_kichen.Image")));
            this.pc_light_off_kichen.Location = new System.Drawing.Point(756, 152);
            this.pc_light_off_kichen.Name = "pc_light_off_kichen";
            this.pc_light_off_kichen.Size = new System.Drawing.Size(48, 58);
            this.pc_light_off_kichen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_light_off_kichen.TabIndex = 4;
            this.pc_light_off_kichen.TabStop = false;
            this.pc_light_off_kichen.Click += new System.EventHandler(this.pc_light_off_kichen_Click);
            // 
            // pc_light_on_kichen
            // 
            this.pc_light_on_kichen.Image = ((System.Drawing.Image)(resources.GetObject("pc_light_on_kichen.Image")));
            this.pc_light_on_kichen.Location = new System.Drawing.Point(756, 152);
            this.pc_light_on_kichen.Name = "pc_light_on_kichen";
            this.pc_light_on_kichen.Size = new System.Drawing.Size(59, 58);
            this.pc_light_on_kichen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_light_on_kichen.TabIndex = 5;
            this.pc_light_on_kichen.TabStop = false;
            this.pc_light_on_kichen.Click += new System.EventHandler(this.pc_light_on_kichen_Click);
            // 
            // btn_television
            // 
            this.btn_television.Location = new System.Drawing.Point(168, 393);
            this.btn_television.Name = "btn_television";
            this.btn_television.Size = new System.Drawing.Size(75, 23);
            this.btn_television.TabIndex = 7;
            this.btn_television.Text = "Television";
            this.btn_television.UseVisualStyleBackColor = true;
            this.btn_television.Click += new System.EventHandler(this.btn_television_Click);
            // 
            // House
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 607);
            this.Controls.Add(this.btn_television);
            this.Controls.Add(this.pc_light_on_kichen);
            this.Controls.Add(this.pc_light_off_kichen);
            this.Controls.Add(this.pc_light_on_salon);
            this.Controls.Add(this.pc_light_off_salon);
            this.Controls.Add(this.btn_Fridge);
            this.MaximumSize = new System.Drawing.Size(916, 646);
            this.MinimumSize = new System.Drawing.Size(916, 646);
            this.Name = "House";
            this.Text = "House";
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_off_salon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_on_salon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_off_kichen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_light_on_kichen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fridge;
        private System.Windows.Forms.PictureBox pc_light_off_salon;
        private System.Windows.Forms.PictureBox pc_light_on_salon;
        private System.Windows.Forms.PictureBox pc_light_off_kichen;
        private System.Windows.Forms.PictureBox pc_light_on_kichen;
        private System.Windows.Forms.Button btn_television;
    }
}