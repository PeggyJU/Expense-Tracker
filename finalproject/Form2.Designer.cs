namespace finalproject
{
    partial class Form2
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
            this.lbldate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rbtsalary = new System.Windows.Forms.RadioButton();
            this.gbxcategory = new System.Windows.Forms.GroupBox();
            this.rbtother = new System.Windows.Forms.RadioButton();
            this.rbtinvest = new System.Windows.Forms.RadioButton();
            this.rbtbonus = new System.Windows.Forms.RadioButton();
            this.lblacount = new System.Windows.Forms.Label();
            this.tbxacount = new System.Windows.Forms.TextBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.rtbnote = new System.Windows.Forms.RichTextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.gbxcategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldate.Location = new System.Drawing.Point(94, 43);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(52, 25);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "日期";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(158, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2025, 1, 10, 0, 0, 0, 0);
            // 
            // rbtsalary
            // 
            this.rbtsalary.AutoSize = true;
            this.rbtsalary.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtsalary.Location = new System.Drawing.Point(75, 55);
            this.rbtsalary.Name = "rbtsalary";
            this.rbtsalary.Size = new System.Drawing.Size(60, 23);
            this.rbtsalary.TabIndex = 3;
            this.rbtsalary.TabStop = true;
            this.rbtsalary.Text = "薪水";
            this.rbtsalary.UseVisualStyleBackColor = true;
            // 
            // gbxcategory
            // 
            this.gbxcategory.Controls.Add(this.rbtother);
            this.gbxcategory.Controls.Add(this.rbtinvest);
            this.gbxcategory.Controls.Add(this.rbtbonus);
            this.gbxcategory.Controls.Add(this.rbtsalary);
            this.gbxcategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxcategory.Location = new System.Drawing.Point(68, 96);
            this.gbxcategory.Name = "gbxcategory";
            this.gbxcategory.Size = new System.Drawing.Size(327, 153);
            this.gbxcategory.TabIndex = 4;
            this.gbxcategory.TabStop = false;
            this.gbxcategory.Text = "類別";
            // 
            // rbtother
            // 
            this.rbtother.AutoSize = true;
            this.rbtother.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtother.Location = new System.Drawing.Point(198, 101);
            this.rbtother.Name = "rbtother";
            this.rbtother.Size = new System.Drawing.Size(60, 23);
            this.rbtother.TabIndex = 11;
            this.rbtother.TabStop = true;
            this.rbtother.Text = "其他";
            this.rbtother.UseVisualStyleBackColor = true;
            // 
            // rbtinvest
            // 
            this.rbtinvest.AutoSize = true;
            this.rbtinvest.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtinvest.Location = new System.Drawing.Point(198, 55);
            this.rbtinvest.Name = "rbtinvest";
            this.rbtinvest.Size = new System.Drawing.Size(60, 23);
            this.rbtinvest.TabIndex = 6;
            this.rbtinvest.TabStop = true;
            this.rbtinvest.Text = "投資";
            this.rbtinvest.UseVisualStyleBackColor = true;
            // 
            // rbtbonus
            // 
            this.rbtbonus.AutoSize = true;
            this.rbtbonus.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtbonus.Location = new System.Drawing.Point(75, 101);
            this.rbtbonus.Name = "rbtbonus";
            this.rbtbonus.Size = new System.Drawing.Size(60, 23);
            this.rbtbonus.TabIndex = 4;
            this.rbtbonus.TabStop = true;
            this.rbtbonus.Text = "獎金";
            this.rbtbonus.UseVisualStyleBackColor = true;
            // 
            // lblacount
            // 
            this.lblacount.AutoSize = true;
            this.lblacount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblacount.Location = new System.Drawing.Point(139, 279);
            this.lblacount.Name = "lblacount";
            this.lblacount.Size = new System.Drawing.Size(74, 25);
            this.lblacount.TabIndex = 5;
            this.lblacount.Text = "金額  $";
            // 
            // tbxacount
            // 
            this.tbxacount.Location = new System.Drawing.Point(216, 278);
            this.tbxacount.Name = "tbxacount";
            this.tbxacount.Size = new System.Drawing.Size(91, 27);
            this.tbxacount.TabIndex = 6;
            this.tbxacount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxacount_KeyPress);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblnote.Location = new System.Drawing.Point(63, 346);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(52, 25);
            this.lblnote.TabIndex = 7;
            this.lblnote.Text = "備註";
            // 
            // rtbnote
            // 
            this.rtbnote.Location = new System.Drawing.Point(129, 351);
            this.rtbnote.Name = "rtbnote";
            this.rtbnote.Size = new System.Drawing.Size(265, 187);
            this.rtbnote.TabIndex = 8;
            this.rtbnote.Text = "";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(100, 561);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 35);
            this.btnok.TabIndex = 9;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(277, 561);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(81, 35);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "收入記錄";
            this.gbxcategory.ResumeLayout(false);
            this.gbxcategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton rbtsalary;
        private System.Windows.Forms.GroupBox gbxcategory;
        private System.Windows.Forms.RadioButton rbtother;
        private System.Windows.Forms.RadioButton rbtinvest;
        private System.Windows.Forms.RadioButton rbtbonus;
        private System.Windows.Forms.Label lblacount;
        private System.Windows.Forms.TextBox tbxacount;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.RichTextBox rtbnote;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}