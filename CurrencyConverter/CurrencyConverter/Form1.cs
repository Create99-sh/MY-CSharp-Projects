using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.获取输入金额
            double amount;
            if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("请输入有效数字！");
            }

            //2.根据选择币种确定汇率
            double rate = 0;
            string currency = cmbCurrency.Text;

            if (currency.Contains("USD")) rate = 6.88; //1美元=6.88人民币
            else if (currency.Contains("EUR")) rate = 7.92; //1欧元=7.92人民币
            else if (currency.Contains("JPY")) rate = 0.049; //1日元=0.049人民币

            //3.计算并显示结果
            double reasult = amount * rate;
            txtResult.Text = reasult.ToString("0.00");//保留两位小数
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
