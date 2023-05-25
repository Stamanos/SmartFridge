namespace SmartFridge
{
    partial class Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.pl_Shopping = new System.Windows.Forms.Panel();
            this.btn_cornfirmed = new System.Windows.Forms.Button();
            this.lbl_Chart = new System.Windows.Forms.Label();
            this.lbl_productChart = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_Shopping
            // 
            this.pl_Shopping.AutoScroll = true;
            this.pl_Shopping.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pl_Shopping.Location = new System.Drawing.Point(0, 0);
            this.pl_Shopping.Name = "pl_Shopping";
            this.pl_Shopping.Size = new System.Drawing.Size(392, 283);
            this.pl_Shopping.TabIndex = 0;
            // 
            // btn_cornfirmed
            // 
            this.btn_cornfirmed.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cornfirmed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cornfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_cornfirmed.Location = new System.Drawing.Point(293, 289);
            this.btn_cornfirmed.Name = "btn_cornfirmed";
            this.btn_cornfirmed.Size = new System.Drawing.Size(99, 25);
            this.btn_cornfirmed.TabIndex = 0;
            this.btn_cornfirmed.Text = "Confirmed";
            this.btn_cornfirmed.UseVisualStyleBackColor = false;
            this.btn_cornfirmed.Click += new System.EventHandler(this.btn_cornfirmed_Click);
            // 
            // lbl_Chart
            // 
            this.lbl_Chart.AutoSize = true;
            this.lbl_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_Chart.ForeColor = System.Drawing.Color.Red;
            this.lbl_Chart.Location = new System.Drawing.Point(209, 286);
            this.lbl_Chart.Name = "lbl_Chart";
            this.lbl_Chart.Size = new System.Drawing.Size(25, 25);
            this.lbl_Chart.TabIndex = 12;
            this.lbl_Chart.Text = "0";
            // 
            // lbl_productChart
            // 
            this.lbl_productChart.AutoSize = true;
            this.lbl_productChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_productChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_productChart.Location = new System.Drawing.Point(12, 289);
            this.lbl_productChart.Name = "lbl_productChart";
            this.lbl_productChart.Size = new System.Drawing.Size(191, 20);
            this.lbl_productChart.TabIndex = 13;
            this.lbl_productChart.Text = "Προϊόντα στο καλάθι :";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Control;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(257, 285);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(30, 29);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 17;
            this.info.TabStop = false;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 314);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lbl_productChart);
            this.Controls.Add(this.lbl_Chart);
            this.Controls.Add(this.btn_cornfirmed);
            this.Controls.Add(this.pl_Shopping);
            this.MaximumSize = new System.Drawing.Size(408, 353);
            this.MinimumSize = new System.Drawing.Size(408, 353);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_Shopping;
        private System.Windows.Forms.Button btn_cornfirmed;
        private System.Windows.Forms.Label lbl_Chart;
        private System.Windows.Forms.Label lbl_productChart;
        private System.Windows.Forms.PictureBox info;
    }
}