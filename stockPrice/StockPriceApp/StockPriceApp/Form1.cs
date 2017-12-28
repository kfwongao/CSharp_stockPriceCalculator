using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPriceApp
{
    public partial class Form1 : Form
    {
        double Net_buy;
        double Net_sell;
        double sale_bonus_buy;
        double sale_bonus_sell;
        double exchange_buy;
        double exchange_sell;
        double jutisfied_buy;
        double jutisfied_sell;
        double cuponloan_buy;
        double cuponloan_sell;
        double purchase_req;
        double sold_req;
        double actual_buy;
        double actual_sell;
        double exchange_balance;
        double net_profit;
        double net_profit_percentage;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            double buy_price1_1_value;
            double buy_amount1_1_value;
            double buy_price2_1_value;
            double buy_amount2_1_value;
            double buy_price3_1_value;
            double buy_amount3_1_value;
            double buy_price4_1_value;
            double buy_amount4_1_value;
            double buy_price5_1_value;
            double buy_amount5_1_value;

            double sell_price1_1_value;
            double sell_amount1_1_value;
            double sell_price2_1_value;
            double sell_amount2_1_value;
            double sell_price3_1_value;
            double sell_amount3_1_value;
            double sell_price4_1_value;
            double sell_amount4_1_value;
            double sell_price5_1_value;
            double sell_amount5_1_value;

            Double.TryParse(buy_price1_1.Text, out buy_price1_1_value);
            Double.TryParse(buy_amount1_1.Text, out buy_amount1_1_value);
            Double.TryParse(buy_price2_1.Text, out buy_price2_1_value);
            Double.TryParse(buy_amount2_1.Text, out buy_amount2_1_value);
            Double.TryParse(buy_price3_1.Text, out buy_price3_1_value);
            Double.TryParse(buy_amount3_1.Text, out buy_amount3_1_value);
            Double.TryParse(buy_price4_1.Text, out buy_price4_1_value);
            Double.TryParse(buy_amount4_1.Text, out buy_amount4_1_value);
            Double.TryParse(buy_price5_1.Text, out buy_price5_1_value);
            Double.TryParse(buy_amount5_1.Text, out buy_amount5_1_value);

            Double.TryParse(sell_price1_1.Text, out sell_price1_1_value);
            Double.TryParse(sell_amount1_1.Text, out sell_amount1_1_value);
            Double.TryParse(sell_price2_1.Text, out sell_price2_1_value);
            Double.TryParse(sell_amount2_1.Text, out sell_amount2_1_value);
            Double.TryParse(sell_price3_1.Text, out sell_price3_1_value);
            Double.TryParse(sell_amount3_1.Text, out sell_amount3_1_value);
            Double.TryParse(sell_price4_1.Text, out sell_price4_1_value);
            Double.TryParse(sell_amount4_1.Text, out sell_amount4_1_value);
            Double.TryParse(sell_price5_1.Text, out sell_price5_1_value);
            Double.TryParse(sell_amount5_1.Text, out sell_amount5_1_value);

            double buy_amount_total = buy_amount1_1_value + buy_amount2_1_value + buy_amount3_1_value + buy_amount4_1_value + buy_amount5_1_value;
            double buy_price_total = buy_price1_1_value*buy_amount1_1_value + buy_price2_1_value*buy_amount2_1_value + buy_price3_1_value*buy_amount3_1_value + buy_price4_1_value*buy_amount4_1_value + buy_price5_1_value*buy_amount5_1_value;
            double buy_average = buy_price_total / buy_amount_total;

            double sell_amount_total = sell_amount1_1_value + sell_amount2_1_value + sell_amount3_1_value + sell_amount4_1_value + sell_amount5_1_value;
            double sell_price_total = sell_price1_1_value*sell_amount1_1_value + sell_price2_1_value*sell_amount2_1_value + sell_price3_1_value*sell_amount3_1_value + sell_price4_1_value*sell_amount4_1_value + sell_price5_1_value*sell_amount5_1_value;
            double sell_average = sell_price_total / sell_amount_total;

            AVG_2_1.Text = buy_amount_total.ToString();
            AVG_1_1.Text = buy_average.ToString();

            AVG_4_1.Text = sell_amount_total.ToString();
            AVG_3_1.Text = sell_average.ToString();

            double high1_1_value;
            double low1_1_value;

            Double.TryParse(high1_1.Text, out high1_1_value);
            Double.TryParse(low1_1.Text, out low1_1_value);

            HLprice1.Text = (((high1_1_value - low1_1_value) * 0.764)+low1_1_value).ToString();
            HLprice2.Text = (((high1_1_value - low1_1_value) * 0.618)+low1_1_value).ToString();
            HLprice3.Text = (((high1_1_value - low1_1_value) * 0.5)+low1_1_value).ToString();
            HLprice4.Text = (((high1_1_value - low1_1_value) * 0.382)+low1_1_value).ToString();
            HLprice5.Text = (((high1_1_value - low1_1_value) * 0.236)+low1_1_value).ToString();

            double open_value;
            Double.TryParse(open.Text, out open_value);

            openResult1.Text = (open_value * 1.03).ToString();
            openResult2.Text = (open_value * 1.06).ToString();
            openResult3.Text = (open_value * 1.07).ToString();
            openResult4.Text = (open_value * 1.1).ToString();
            openResult5.Text = (open_value * 1.11).ToString();
            openResult6.Text = (open_value * 1.13).ToString();
            openResult7.Text = (open_value * 1.15).ToString();

            Net_buy = buy_price_total;
            Net_sell = sell_price_total;

            buy1.Text = Net_buy.ToString();
            sell1.Text = Net_sell.ToString();

            sale_bonus_buy = Net_buy * 0.002;
            sale_bonus_sell = Net_sell * 0.002;
            buy2.Text = sale_bonus_buy.ToString();
            sell2.Text = sale_bonus_sell.ToString();

            exchange_buy = Net_buy * 0.000027;
            exchange_sell = Net_sell * 0.000027;
            buy3.Text = exchange_buy.ToString();
            sell3.Text = exchange_sell.ToString();

            jutisfied_buy = Net_buy * 0.00005;
            jutisfied_sell = Net_sell * 0.00005;
            buy4.Text = jutisfied_buy.ToString();
            sell4.Text = jutisfied_sell.ToString();

            cuponloan_buy = Net_buy * 0.001;
            cuponloan_sell = 1 + Net_sell * 0.001;
            buy5.Text = cuponloan_buy.ToString();
            sell5.Text = cuponloan_sell.ToString();

            purchase_req = sale_bonus_buy + exchange_buy + jutisfied_buy + cuponloan_buy + 2;
            sold_req = sale_bonus_sell + exchange_sell + jutisfied_sell + cuponloan_sell + 2;
            buy7.Text = purchase_req.ToString();
            sell7.Text = sold_req.ToString();

            actual_buy = Net_buy + purchase_req;
            actual_sell = Net_sell - sold_req;
            buy8.Text = actual_buy.ToString();
            sell8.Text = actual_sell.ToString();

            exchange_balance = purchase_req + sold_req;
            total.Text = "買賣總費 =     " + exchange_balance.ToString() + "   (買入費用 + 賣出費用) ";

            net_profit = actual_sell - actual_buy;
            net_profit_percentage = 100 * net_profit / actual_buy;

            ActualProfit_1.Text = "實際收益      " + net_profit.ToString() + "      ( " + net_profit_percentage.ToString() + " % )";
            ActualProfit_2.Text = "實際收益      " + net_profit.ToString() + "      ( " + net_profit_percentage.ToString() + " % )";

        }
    }
}
