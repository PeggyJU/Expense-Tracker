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
    public partial class Form3 : Form
    {
        public Form3()
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
                if (rbteat.Checked)
                    return "飲食";
                else if (rbtdaily.Checked)
                    return "日用";
                else if (rbttraffic.Checked)
                    return "交通";
                else if (rbtsocial.Checked)
                    return "社交";
                else if (rbtshopping.Checked)
                    return "購物";
                else if (rbteducation.Checked)
                    return "教育";
                else if (rbtplay.Checked)
                    return "娛樂";
                else if (rbtphone.Checked)
                    return "通信";
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
                類型 = "支出",
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
