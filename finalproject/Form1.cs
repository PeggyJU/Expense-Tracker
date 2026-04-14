using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static finalproject.Form1;

namespace finalproject
{
    public partial class Form1 : Form
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Total { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 將共享數據绑定到DataGridView
            dgvRecords.DataSource = SharedData.Records;
        }

        private void RefreshDataGrid()
        {
            // 重新绑定數據
            dgvRecords.DataSource = null; // 清空原來綁定的數據，確保控件的刷新
            dgvRecords.DataSource = SharedData.Records;

            // 計算收入和支出
            TotalIncome = SharedData.Records.Where(record => record.類型 == "收入").Sum(record => record.金額);
            TotalExpense = SharedData.Records.Where(record => record.類型 == "支出").Sum(record => record.金額);

            // 計算總額
            Total = TotalIncome - TotalExpense;

            // 更新顯示
            lblincometotal.Text = "收入總額 : " + TotalIncome.ToString("C");
            lblexpensetotal.Text = "支出總額 : " + TotalExpense.ToString("C");
            lbltotal.Text = "總計 : " + Total.ToString("C");
        }

        private void btnincome_Click(object sender, EventArgs e)
        {
            Form2 incomeForm = new Form2();
            this.Hide(); // 隱藏主視窗
            incomeForm.ShowDialog(); // 顯示收入視窗
            RefreshDataGrid();
            this.Show(); // 關閉收入視窗並顯示主視窗
        }

        private void btnexpense_Click(object sender, EventArgs e)
        {
            Form3 expenseForm = new Form3();
            this.Hide(); // 隱藏主視窗
            expenseForm.ShowDialog(); // 顯示支出視窗
            RefreshDataGrid();
            this.Show(); // 關閉支出視窗並顯示主視窗
        }

        // 某個單元格需要格式化顯示時，會觸發該事件
        private void dgvRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 確認列名與 "類型" 對應
            if (dgvRecords.Columns[e.ColumnIndex].Name == "類型") // "類型" 是列名
            {
                string cellValue = e.Value?.ToString(); // 獲取單元格的值
                if (cellValue == "收入")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else if (cellValue == "支出")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }

    public class Record
    {
        public string 類型 { get; set; }
        public DateTime 日期 { get; set; }
        public string 類別 { get; set; }
        public decimal 金額 { get; set; }
        public string 備註 { get; set; }
    }

    // 共享數據
    public static class SharedData
    {
        // 儲存所有紀錄
        public static List<Record> Records = new List<Record>();
    }
}
