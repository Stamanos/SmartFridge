namespace SmartFridge
{
    partial class InsideTheFridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsideTheFridge));
            this.pl_inside = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.PictureBox();
            this.btn_GoToRecipes = new System.Windows.Forms.Button();
            this.btn_GoForShopping = new System.Windows.Forms.Button();
            this.lbl_temprature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_inside
            // 
            this.pl_inside.AutoScroll = true;
            this.pl_inside.Location = new System.Drawing.Point(12, 40);
            this.pl_inside.Name = "pl_inside";
            this.pl_inside.Size = new System.Drawing.Size(394, 268);
            this.pl_inside.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(12, 320);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(287, 23);
            this.progressBar.Step = 100;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 19;
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_percentage.Location = new System.Drawing.Point(316, 325);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(90, 18);
            this.lbl_percentage.TabIndex = 20;
            this.lbl_percentage.Text = "lbl_percent";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(371, 352);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 31);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 21;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // btn_GoToRecipes
            // 
            this.btn_GoToRecipes.Location = new System.Drawing.Point(12, 349);
            this.btn_GoToRecipes.Name = "btn_GoToRecipes";
            this.btn_GoToRecipes.Size = new System.Drawing.Size(137, 34);
            this.btn_GoToRecipes.TabIndex = 22;
            this.btn_GoToRecipes.Text = "View recipes";
            this.btn_GoToRecipes.UseVisualStyleBackColor = true;
            this.btn_GoToRecipes.Click += new System.EventHandler(this.btn_GoToRecipes_Click);
            // 
            // btn_GoForShopping
            // 
            this.btn_GoForShopping.Location = new System.Drawing.Point(162, 349);
            this.btn_GoForShopping.Name = "btn_GoForShopping";
            this.btn_GoForShopping.Size = new System.Drawing.Size(137, 34);
            this.btn_GoForShopping.TabIndex = 23;
            this.btn_GoForShopping.Text = "Go for shopping";
            this.btn_GoForShopping.UseVisualStyleBackColor = true;
            this.btn_GoForShopping.Click += new System.EventHandler(this.btn_GoForShopping_Click);
            // 
            // lbl_temprature
            // 
            this.lbl_temprature.AutoSize = true;
            this.lbl_temprature.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_temprature.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temprature.ForeColor = System.Drawing.Color.Green;
            this.lbl_temprature.Location = new System.Drawing.Point(57, 12);
            this.lbl_temprature.Name = "lbl_temprature";
            this.lbl_temprature.Size = new System.Drawing.Size(327, 25);
            this.lbl_temprature.TabIndex = 24;
            this.lbl_temprature.Text = "Temprature:          4 C          ";
            // 
            // InsideTheFridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 384);
            this.Controls.Add(this.lbl_temprature);
            this.Controls.Add(this.btn_GoForShopping);
            this.Controls.Add(this.btn_GoToRecipes);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pl_inside);
            this.MaximumSize = new System.Drawing.Size(434, 423);
            this.MinimumSize = new System.Drawing.Size(434, 423);
            this.Name = "InsideTheFridge";
            this.Text = "InsideTheFridge";
            this.Load += new System.EventHandler(this.InsideTheFridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_inside;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_percentage;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Button btn_GoToRecipes;
        private System.Windows.Forms.Button btn_GoForShopping;
        private System.Windows.Forms.Label lbl_temprature;
    }
}