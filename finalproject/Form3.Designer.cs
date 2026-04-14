namespace finalproject
{
    partial class Form3
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.rtbnote = new System.Windows.Forms.RichTextBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.tbxacount = new System.Windows.Forms.TextBox();
            this.lblacount = new System.Windows.Forms.Label();
            this.gbxcategory = new System.Windows.Forms.GroupBox();
            this.rbtother = new System.Windows.Forms.RadioButton();
            this.rbtphone = new System.Windows.Forms.RadioButton();
            this.rbtplay = new System.Windows.Forms.RadioButton();
            this.rbteducation = new System.Windows.Forms.RadioButton();
            this.rbttraffic = new System.Windows.Forms.RadioButton();
            this.rbtshopping = new System.Windows.Forms.RadioButton();
            this.rbtsocial = new System.Windows.Forms.RadioButton();
            this.rbtdaily = new System.Windows.Forms.RadioButton();
            this.rbteat = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.gbxcategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(276, 553);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 35);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(99, 553);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 35);
            this.btnok.TabIndex = 18;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // rtbnote
            // 
            this.rtbnote.Location = new System.Drawing.Point(128, 343);
            this.rtbnote.Name = "rtbnote";
            this.rtbnote.Size = new System.Drawing.Size(265, 187);
            this.rtbnote.TabIndex = 17;
            this.rtbnote.Text = "";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblnote.Location = new System.Drawing.Point(62, 338);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(52, 25);
            this.lblnote.TabIndex = 16;
            this.lblnote.Text = "備註";
            // 
            // tbxacount
            // 
            this.tbxacount.Location = new System.Drawing.Point(215, 270);
            this.tbxacount.Name = "tbxacount";
            this.tbxacount.Size = new System.Drawing.Size(91, 27);
            this.tbxacount.TabIndex = 15;
            this.tbxacount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxacount_KeyPress);
            // 
            // lblacount
            // 
            this.lblacount.AutoSize = true;
            this.lblacount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblacount.Location = new System.Drawing.Point(138, 271);
            this.lblacount.Name = "lblacount";
            this.lblacount.Size = new System.Drawing.Size(74, 25);
            this.lblacount.TabIndex = 14;
            this.lblacount.Text = "金額  $";
            // 
            // gbxcategory
            // 
            this.gbxcategory.Controls.Add(this.rbtother);
            this.gbxcategory.Controls.Add(this.rbtphone);
            this.gbxcategory.Controls.Add(this.rbtplay);
            this.gbxcategory.Controls.Add(this.rbteducation);
            this.gbxcategory.Controls.Add(this.rbttraffic);
            this.gbxcategory.Controls.Add(this.rbtshopping);
            this.gbxcategory.Controls.Add(this.rbtsocial);
            this.gbxcategory.Controls.Add(this.rbtdaily);
            this.gbxcategory.Controls.Add(this.rbteat);
            this.gbxcategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxcategory.Location = new System.Drawing.Point(67, 88);
            this.gbxcategory.Name = "gbxcategory";
            this.gbxcategory.Size = new System.Drawing.Size(327, 153);
            this.gbxcategory.TabIndex = 13;
            this.gbxcategory.TabStop = false;
            this.gbxcategory.Text = "類別";
            // 
            // rbtother
            // 
            this.rbtother.AutoSize = true;
            this.rbtother.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtother.Location = new System.Drawing.Point(239, 107);
            this.rbtother.Name = "rbtother";
            this.rbtother.Size = new System.Drawing.Size(60, 23);
            this.rbtother.TabIndex = 11;
            this.rbtother.TabStop = true;
            this.rbtother.Text = "其他";
            this.rbtother.UseVisualStyleBackColor = true;
            // 
            // rbtphone
            // 
            this.rbtphone.AutoSize = true;
            this.rbtphone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtphone.Location = new System.Drawing.Point(239, 73);
            this.rbtphone.Name = "rbtphone";
            this.rbtphone.Size = new System.Drawing.Size(60, 23);
            this.rbtphone.TabIndex = 10;
            this.rbtphone.TabStop = true;
            this.rbtphone.Text = "通信";
            this.rbtphone.UseVisualStyleBackColor = true;
            // 
            // rbtplay
            // 
            this.rbtplay.AutoSize = true;
            this.rbtplay.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtplay.Location = new System.Drawing.Point(239, 38);
            this.rbtplay.Name = "rbtplay";
            this.rbtplay.Size = new System.Drawing.Size(60, 23);
            this.rbtplay.TabIndex = 9;
            this.rbtplay.TabStop = true;
            this.rbtplay.Text = "娛樂";
            this.rbtplay.UseVisualStyleBackColor = true;
            // 
            // rbteducation
            // 
            this.rbteducation.AutoSize = true;
            this.rbteducation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbteducation.Location = new System.Drawing.Point(137, 107);
            this.rbteducation.Name = "rbteducation";
            this.rbteducation.Size = new System.Drawing.Size(60, 23);
            this.rbteducation.TabIndex = 8;
            this.rbteducation.TabStop = true;
            this.rbteducation.Text = "教育";
            this.rbteducation.UseVisualStyleBackColor = true;
            // 
            // rbttraffic
            // 
            this.rbttraffic.AutoSize = true;
            this.rbttraffic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbttraffic.Location = new System.Drawing.Point(34, 107);
            this.rbttraffic.Name = "rbttraffic";
            this.rbttraffic.Size = new System.Drawing.Size(60, 23);
            this.rbttraffic.TabIndex = 5;
            this.rbttraffic.TabStop = true;
            this.rbttraffic.Text = "交通";
            this.rbttraffic.UseVisualStyleBackColor = true;
            // 
            // rbtshopping
            // 
            this.rbtshopping.AutoSize = true;
            this.rbtshopping.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtshopping.Location = new System.Drawing.Point(137, 73);
            this.rbtshopping.Name = "rbtshopping";
            this.rbtshopping.Size = new System.Drawing.Size(60, 23);
            this.rbtshopping.TabIndex = 7;
            this.rbtshopping.TabStop = true;
            this.rbtshopping.Text = "購物";
            this.rbtshopping.UseVisualStyleBackColor = true;
            // 
            // rbtsocial
            // 
            this.rbtsocial.AutoSize = true;
            this.rbtsocial.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtsocial.Location = new System.Drawing.Point(137, 38);
            this.rbtsocial.Name = "rbtsocial";
            this.rbtsocial.Size = new System.Drawing.Size(60, 23);
            this.rbtsocial.TabIndex = 6;
            this.rbtsocial.TabStop = true;
            this.rbtsocial.Text = "社交";
            this.rbtsocial.UseVisualStyleBackColor = true;
            // 
            // rbtdaily
            // 
            this.rbtdaily.AutoSize = true;
            this.rbtdaily.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtdaily.Location = new System.Drawing.Point(34, 73);
            this.rbtdaily.Name = "rbtdaily";
            this.rbtdaily.Size = new System.Drawing.Size(60, 23);
            this.rbtdaily.TabIndex = 4;
            this.rbtdaily.TabStop = true;
            this.rbtdaily.Text = "日用";
            this.rbtdaily.UseVisualStyleBackColor = true;
            // 
            // rbteat
            // 
            this.rbteat.AutoSize = true;
            this.rbteat.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbteat.Location = new System.Drawing.Point(34, 38);
            this.rbteat.Name = "rbteat";
            this.rbteat.Size = new System.Drawing.Size(60, 23);
            this.rbteat.TabIndex = 3;
            this.rbteat.TabStop = true;
            this.rbteat.Text = "飲食";
            this.rbteat.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(157, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2025, 1, 10, 0, 0, 0, 0);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldate.Location = new System.Drawing.Point(93, 35);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 25);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "日期";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 618);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.rtbnote);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.tbxacount);
            this.Controls.Add(this.lblacount);
            this.Controls.Add(this.gbxcategory);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lbldate);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "支出記錄";
            this.gbxcategory.ResumeLayout(false);
            this.gbxcategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.RichTextBox rtbnote;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.TextBox tbxacount;
        private System.Windows.Forms.Label lblacount;
        private System.Windows.Forms.GroupBox gbxcategory;
        private System.Windows.Forms.RadioButton rbtother;
        private System.Windows.Forms.RadioButton rbtphone;
        private System.Windows.Forms.RadioButton rbtplay;
        private System.Windows.Forms.RadioButton rbteducation;
        private System.Windows.Forms.RadioButton rbttraffic;
        private System.Windows.Forms.RadioButton rbtshopping;
        private System.Windows.Forms.RadioButton rbtsocial;
        private System.Windows.Forms.RadioButton rbtdaily;
        private System.Windows.Forms.RadioButton rbteat;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbldate;
    }
}