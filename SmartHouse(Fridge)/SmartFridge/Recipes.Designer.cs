namespace SmartFridge
{
    partial class Recipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipes));
            this.lbl_Recipes = new System.Windows.Forms.Label();
            this.btn_recipe1 = new System.Windows.Forms.Button();
            this.btn_recipe2 = new System.Windows.Forms.Button();
            this.btn_recipe3 = new System.Windows.Forms.Button();
            this.btn_recipe4 = new System.Windows.Forms.Button();
            this.btn_recipe5 = new System.Windows.Forms.Button();
            this.rtb_ingediens = new System.Windows.Forms.RichTextBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.btn_GoForShopping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Recipes
            // 
            this.lbl_Recipes.AutoSize = true;
            this.lbl_Recipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Recipes.Location = new System.Drawing.Point(12, 9);
            this.lbl_Recipes.Name = "lbl_Recipes";
            this.lbl_Recipes.Size = new System.Drawing.Size(227, 36);
            this.lbl_Recipes.TabIndex = 0;
            this.lbl_Recipes.Text = "Select your Recipe you want \r\nto make below";
            // 
            // btn_recipe1
            // 
            this.btn_recipe1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recipe1.Location = new System.Drawing.Point(12, 84);
            this.btn_recipe1.Name = "btn_recipe1";
            this.btn_recipe1.Size = new System.Drawing.Size(179, 47);
            this.btn_recipe1.TabIndex = 1;
            this.btn_recipe1.Text = "Κρύα σαλάτα με ζυμαρικά";
            this.btn_recipe1.UseVisualStyleBackColor = true;
            this.btn_recipe1.Click += new System.EventHandler(this.btn_recipe1_Click);
            // 
            // btn_recipe2
            // 
            this.btn_recipe2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recipe2.Location = new System.Drawing.Point(12, 172);
            this.btn_recipe2.Name = "btn_recipe2";
            this.btn_recipe2.Size = new System.Drawing.Size(179, 47);
            this.btn_recipe2.TabIndex = 2;
            this.btn_recipe2.Text = "Χωριάτικη μακαρονάδα";
            this.btn_recipe2.UseVisualStyleBackColor = true;
            this.btn_recipe2.Click += new System.EventHandler(this.btn_recipe2_Click);
            // 
            // btn_recipe3
            // 
            this.btn_recipe3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recipe3.Location = new System.Drawing.Point(12, 265);
            this.btn_recipe3.Name = "btn_recipe3";
            this.btn_recipe3.Size = new System.Drawing.Size(179, 47);
            this.btn_recipe3.TabIndex = 3;
            this.btn_recipe3.Text = "Παγωτό κορμός με βύσσινο";
            this.btn_recipe3.UseVisualStyleBackColor = true;
            this.btn_recipe3.Click += new System.EventHandler(this.btn_recipe3_Click);
            // 
            // btn_recipe4
            // 
            this.btn_recipe4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recipe4.Location = new System.Drawing.Point(12, 366);
            this.btn_recipe4.Name = "btn_recipe4";
            this.btn_recipe4.Size = new System.Drawing.Size(179, 47);
            this.btn_recipe4.TabIndex = 4;
            this.btn_recipe4.Text = "Μούς φυστικοβούτυρο";
            this.btn_recipe4.UseVisualStyleBackColor = true;
            this.btn_recipe4.Click += new System.EventHandler(this.btn_recipe4_Click);
            // 
            // btn_recipe5
            // 
            this.btn_recipe5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recipe5.Location = new System.Drawing.Point(12, 464);
            this.btn_recipe5.Name = "btn_recipe5";
            this.btn_recipe5.Size = new System.Drawing.Size(179, 47);
            this.btn_recipe5.TabIndex = 5;
            this.btn_recipe5.Text = "Κοτόπουλο με μανιτάρια και φασολάκια";
            this.btn_recipe5.UseVisualStyleBackColor = true;
            this.btn_recipe5.Click += new System.EventHandler(this.btn_recipe5_Click);
            // 
            // rtb_ingediens
            // 
            this.rtb_ingediens.Location = new System.Drawing.Point(291, 123);
            this.rtb_ingediens.Name = "rtb_ingediens";
            this.rtb_ingediens.Size = new System.Drawing.Size(267, 275);
            this.rtb_ingediens.TabIndex = 6;
            this.rtb_ingediens.Text = "";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.PeachPuff;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(497, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(61, 50);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 17;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // btn_GoForShopping
            // 
            this.btn_GoForShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_GoForShopping.Location = new System.Drawing.Point(291, 420);
            this.btn_GoForShopping.Name = "btn_GoForShopping";
            this.btn_GoForShopping.Size = new System.Drawing.Size(267, 53);
            this.btn_GoForShopping.TabIndex = 18;
            this.btn_GoForShopping.Text = "Shop the missing ingrediens";
            this.btn_GoForShopping.UseVisualStyleBackColor = true;
            this.btn_GoForShopping.Click += new System.EventHandler(this.btn_GoForShopping_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(597, 535);
            this.Controls.Add(this.btn_GoForShopping);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rtb_ingediens);
            this.Controls.Add(this.btn_recipe5);
            this.Controls.Add(this.btn_recipe4);
            this.Controls.Add(this.btn_recipe3);
            this.Controls.Add(this.btn_recipe2);
            this.Controls.Add(this.btn_recipe1);
            this.Controls.Add(this.lbl_Recipes);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Recipes;
        private System.Windows.Forms.Button btn_recipe1;
        private System.Windows.Forms.Button btn_recipe2;
        private System.Windows.Forms.Button btn_recipe3;
        private System.Windows.Forms.Button btn_recipe4;
        private System.Windows.Forms.Button btn_recipe5;
        private System.Windows.Forms.RichTextBox rtb_ingediens;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Button btn_GoForShopping;
    }
}