using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉視窗回到主視窗
        }

        private string GetSelectedCategory()
        {
            {
                if (rbtsalary.Checked)
                    return "薪水";
                else if (rbtbonus.Checked)
                    return "獎金";
                else if (rbtinvest.Checked)
                    return "投資";
                else if (rbtother.Checked)
                    return "其他";
                else
                    return "未分類";
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string category = GetSelectedCategory();

            // 添加記錄到datagridview
            SharedData.Records.Add(new Record
            {
                類型 = "收入",
                日期 = dateTimePicker.Value,
                類別 = category,
                金額 = decimal.Parse(tbxacount.Text),
                備註 = rtbnote.Text
            });

            this.Close();
        }

        private void tbxacount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允許數字和控制鍵（如退格）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 阻止非數字輸入
            }
        }
    }
}
