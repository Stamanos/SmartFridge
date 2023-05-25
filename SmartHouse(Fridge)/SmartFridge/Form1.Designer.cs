namespace SmartFridge
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barcode = new System.Windows.Forms.PictureBox();
            this.calendar = new System.Windows.Forms.PictureBox();
            this.notes = new System.Windows.Forms.PictureBox();
            this.pc_shopping = new System.Windows.Forms.PictureBox();
            this.discound = new System.Windows.Forms.PictureBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.weather = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_RQ = new System.Windows.Forms.Label();
            this.pl_results = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pl_buttons = new System.Windows.Forms.Panel();
            this.pc_Settings = new System.Windows.Forms.PictureBox();
            this.recipe = new System.Windows.Forms.PictureBox();
            this.pc_inside = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_temprature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_shopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).BeginInit();
            this.pl_results.SuspendLayout();
            this.pl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_inside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // barcode
            // 
            this.barcode.BackColor = System.Drawing.Color.Gray;
            this.barcode.Image = ((System.Drawing.Image)(resources.GetObject("barcode.Image")));
            this.barcode.Location = new System.Drawing.Point(19, 10);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(60, 52);
            this.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcode.TabIndex = 0;
            this.barcode.TabStop = false;
            this.barcode.Click += new System.EventHandler(this.barcode_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Gray;
            this.calendar.Image = ((System.Drawing.Image)(resources.GetObject("calendar.Image")));
            this.calendar.Location = new System.Drawing.Point(106, 10);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(60, 52);
            this.calendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calendar.TabIndex = 1;
            this.calendar.TabStop = false;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.Color.Gray;
            this.notes.Image = ((System.Drawing.Image)(resources.GetObject("notes.Image")));
            this.notes.Location = new System.Drawing.Point(193, 10);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(60, 52);
            this.notes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notes.TabIndex = 2;
            this.notes.TabStop = false;
            this.notes.Click += new System.EventHandler(this.notes_Click);
            // 
            // pc_shopping
            // 
            this.pc_shopping.BackColor = System.Drawing.Color.Gray;
            this.pc_shopping.Image = ((System.Drawing.Image)(resources.GetObject("pc_shopping.Image")));
            this.pc_shopping.Location = new System.Drawing.Point(19, 76);
            this.pc_shopping.Name = "pc_shopping";
            this.pc_shopping.Size = new System.Drawing.Size(60, 52);
            this.pc_shopping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_shopping.TabIndex = 3;
            this.pc_shopping.TabStop = false;
            this.pc_shopping.Click += new System.EventHandler(this.shopping_Click);
            // 
            // discound
            // 
            this.discound.BackColor = System.Drawing.Color.Gray;
            this.discound.Image = ((System.Drawing.Image)(resources.GetObject("discound.Image")));
            this.discound.Location = new System.Drawing.Point(106, 76);
            this.discound.Name = "discound";
            this.discound.Size = new System.Drawing.Size(60, 52);
            this.discound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.discound.TabIndex = 4;
            this.discound.TabStop = false;
            this.discound.Click += new System.EventHandler(this.discound_Click);
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.Gold;
            this.note.Location = new System.Drawing.Point(563, 184);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(181, 169);
            this.note.TabIndex = 5;
            this.note.Text = "";
            this.note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.note_KeyDown);
            // 
            // weather
            // 
            this.weather.BackColor = System.Drawing.Color.Gray;
            this.weather.Image = ((System.Drawing.Image)(resources.GetObject("weather.Image")));
            this.weather.Location = new System.Drawing.Point(193, 76);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(60, 52);
            this.weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weather.TabIndex = 8;
            this.weather.TabStop = false;
            this.weather.Click += new System.EventHandler(this.weather_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 44);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // lbl_RQ
            // 
            this.lbl_RQ.AutoSize = true;
            this.lbl_RQ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_RQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_RQ.Location = new System.Drawing.Point(145, 326);
            this.lbl_RQ.Name = "lbl_RQ";
            this.lbl_RQ.Size = new System.Drawing.Size(186, 25);
            this.lbl_RQ.TabIndex = 11;
            this.lbl_RQ.Text = "Please incert here";
            this.lbl_RQ.UseWaitCursor = true;
            // 
            // pl_results
            // 
            this.pl_results.AutoScroll = true;
            this.pl_results.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pl_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pl_results.Controls.Add(this.webBrowser);
            this.pl_results.Controls.Add(this.monthCalendar1);
            this.pl_results.Location = new System.Drawing.Point(13, 13);
            this.pl_results.Name = "pl_results";
            this.pl_results.Size = new System.Drawing.Size(426, 300);
            this.pl_results.TabIndex = 14;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(416, 290);
            this.webBrowser.TabIndex = 10;
            // 
            // pl_buttons
            // 
            this.pl_buttons.AutoScroll = true;
            this.pl_buttons.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pl_buttons.Controls.Add(this.pc_Settings);
            this.pl_buttons.Controls.Add(this.recipe);
            this.pl_buttons.Controls.Add(this.pc_inside);
            this.pl_buttons.Controls.Add(this.barcode);
            this.pl_buttons.Controls.Add(this.calendar);
            this.pl_buttons.Controls.Add(this.notes);
            this.pl_buttons.Controls.Add(this.pc_shopping);
            this.pl_buttons.Controls.Add(this.discound);
            this.pl_buttons.Controls.Add(this.weather);
            this.pl_buttons.Location = new System.Drawing.Point(544, 447);
            this.pl_buttons.Name = "pl_buttons";
            this.pl_buttons.Size = new System.Drawing.Size(274, 212);
            this.pl_buttons.TabIndex = 15;
            // 
            // pc_Settings
            // 
            this.pc_Settings.BackColor = System.Drawing.Color.Gray;
            this.pc_Settings.Image = ((System.Drawing.Image)(resources.GetObject("pc_Settings.Image")));
            this.pc_Settings.Location = new System.Drawing.Point(193, 144);
            this.pc_Settings.Name = "pc_Settings";
            this.pc_Settings.Size = new System.Drawing.Size(60, 52);
            this.pc_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Settings.TabIndex = 11;
            this.pc_Settings.TabStop = false;
            this.pc_Settings.Click += new System.EventHandler(this.pc_Settings_Click);
            // 
            // recipe
            // 
            this.recipe.BackColor = System.Drawing.Color.Gray;
            this.recipe.Image = ((System.Drawing.Image)(resources.GetObject("recipe.Image")));
            this.recipe.Location = new System.Drawing.Point(106, 144);
            this.recipe.Name = "recipe";
            this.recipe.Size = new System.Drawing.Size(60, 52);
            this.recipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipe.TabIndex = 10;
            this.recipe.TabStop = false;
            this.recipe.Click += new System.EventHandler(this.recipe_Click);
            // 
            // pc_inside
            // 
            this.pc_inside.BackColor = System.Drawing.Color.Gray;
            this.pc_inside.Image = ((System.Drawing.Image)(resources.GetObject("pc_inside.Image")));
            this.pc_inside.Location = new System.Drawing.Point(19, 144);
            this.pc_inside.Name = "pc_inside";
            this.pc_inside.Size = new System.Drawing.Size(60, 52);
            this.pc_inside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_inside.TabIndex = 9;
            this.pc_inside.TabStop = false;
            this.pc_inside.Click += new System.EventHandler(this.inside_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(748, 88);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(61, 50);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info.TabIndex = 16;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_time.Location = new System.Drawing.Point(544, 33);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(79, 20);
            this.lbl_time.TabIndex = 17;
            this.lbl_time.Text = "12:23:31";
            // 
            // lbl_temprature
            // 
            this.lbl_temprature.AutoSize = true;
            this.lbl_temprature.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_temprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbl_temprature.Location = new System.Drawing.Point(809, 9);
            this.lbl_temprature.Name = "lbl_temprature";
            this.lbl_temprature.Size = new System.Drawing.Size(36, 20);
            this.lbl_temprature.TabIndex = 18;
            this.lbl_temprature.Text = "4 C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 741);
            this.Controls.Add(this.lbl_temprature);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pl_buttons);
            this.Controls.Add(this.pl_results);
            this.Controls.Add(this.note);
            this.Controls.Add(this.lbl_RQ);
            this.MaximumSize = new System.Drawing.Size(922, 780);
            this.MinimumSize = new System.Drawing.Size(922, 766);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_shopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).EndInit();
            this.pl_results.ResumeLayout(false);
            this.pl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_inside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox barcode;
        private System.Windows.Forms.PictureBox calendar;
        private System.Windows.Forms.PictureBox notes;
        private System.Windows.Forms.PictureBox pc_shopping;
        private System.Windows.Forms.PictureBox discound;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.PictureBox weather;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_RQ;
        private System.Windows.Forms.Panel pl_results;
        private System.Windows.Forms.Panel pl_buttons;
        private System.Windows.Forms.PictureBox pc_inside;
        private System.Windows.Forms.PictureBox recipe;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.PictureBox pc_Settings;
        private System.Windows.Forms.Label lbl_temprature;
    }
}

