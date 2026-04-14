namespace finalproject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblincometotal = new System.Windows.Forms.Label();
            this.lblexpensetotal = new System.Windows.Forms.Label();
            this.btnincome = new System.Windows.Forms.Button();
            this.btnexpense = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(182, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "記帳應用";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblincometotal
            // 
            this.lblincometotal.AutoSize = true;
            this.lblincometotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblincometotal.ForeColor = System.Drawing.Color.Green;
            this.lblincometotal.Location = new System.Drawing.Point(46, 104);
            this.lblincometotal.Name = "lblincometotal";
            this.lblincometotal.Size = new System.Drawing.Size(124, 25);
            this.lblincometotal.TabIndex = 1;
            this.lblincometotal.Text = "收入總額  : 0";
            this.lblincometotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexpensetotal
            // 
            this.lblexpensetotal.AutoSize = true;
            this.lblexpensetotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblexpensetotal.ForeColor = System.Drawing.Color.Red;
            this.lblexpensetotal.Location = new System.Drawing.Point(259, 104);
            this.lblexpensetotal.Name = "lblexpensetotal";
            this.lblexpensetotal.Size = new System.Drawing.Size(129, 25);
            this.lblexpensetotal.TabIndex = 2;
            this.lblexpensetotal.Text = "支出總額  :  0";
            this.lblexpensetotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnincome
            // 
            this.btnincome.Location = new System.Drawing.Point(89, 495);
            this.btnincome.Name = "btnincome";
            this.btnincome.Size = new System.Drawing.Size(109, 30);
            this.btnincome.TabIndex = 3;
            this.btnincome.Text = "新增收入";
            this.btnincome.UseVisualStyleBackColor = true;
            this.btnincome.Click += new System.EventHandler(this.btnincome_Click);
            // 
            // btnexpense
            // 
            this.btnexpense.Location = new System.Drawing.Point(270, 495);
            this.btnexpense.Name = "btnexpense";
            this.btnexpense.Size = new System.Drawing.Size(109, 30);
            this.btnexpense.TabIndex = 4;
            this.btnexpense.Text = "新增支出";
            this.btnexpense.UseVisualStyleBackColor = true;
            this.btnexpense.Click += new System.EventHandler(this.btnexpense_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToOrderColumns = true;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecords.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(45, 184);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 27;
            this.dgvRecords.Size = new System.Drawing.Size(377, 281);
            this.dgvRecords.TabIndex = 5;
            this.dgvRecords.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecords_CellFormatting);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotal.Location = new System.Drawing.Point(158, 143);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(89, 25);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "總計  :  0";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 555);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.btnexpense);
            this.Controls.Add(this.btnincome);
            this.Controls.Add(this.lblexpensetotal);
            this.Controls.Add(this.lblincometotal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "個人記帳";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblincometotal;
        private System.Windows.Forms.Label lblexpensetotal;
        private System.Windows.Forms.Button btnincome;
        private System.Windows.Forms.Button btnexpense;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label lbltotal;
    }
}

