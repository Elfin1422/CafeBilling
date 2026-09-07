using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBilling
{
    public partial class Form1 : Form
    {
      
        private readonly Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>
        {
            { "burger", 85m },
            { "chickensandwich", 75m },
            { "spaghetti", 95m },
            { "fries", 50m },
            { "frenchfries", 50m }
        };

        private readonly Dictionary<string, decimal> drinkPrices = new Dictionary<string, decimal>
        {
            { "softdrink", 35m },
            { "icedtea", 40m },
            { "coffee", 45m },
            { "bottledwater", 25m }
        };

        private const decimal BulkDiscountThreshold = 500m;
        private const decimal BulkDiscountRate = 0.10m;
        private const decimal SeniorDiscountRate = 0.20m;
        private const decimal TakeoutCharge = 20m;
        private const decimal DeliveryCharge = 50m;
        private const decimal FreeDeliveryThreshold = 1000m;

        public Form1()
        {
            InitializeComponent();
        }

       
        private static string Normalize(string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return new string(text.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLowerInvariant();
        }

        private void FoodBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrinksBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiptMultiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrinksQuantiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodQuantiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSenior_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitOrderbtn_Click(object sender, EventArgs e)
        {
           
            string foodInput = FoodBox.Text.Trim();
            string drinkInput = DrinksBox.Text.Trim();

            if (string.IsNullOrEmpty(foodInput))
            {
                MessageBox.Show("Please select/enter a food item from the menu.", "No Food Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FoodBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(drinkInput))
            {
                MessageBox.Show("Please select/enter a drink item from the menu.", "No Drink Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DrinksBox.Focus();
                return;
            }

            
            if (!foodPrices.TryGetValue(Normalize(foodInput), out decimal foodPrice))
            {
                MessageBox.Show("\"" + foodInput + "\" is not on the food menu. Please check the spelling.",
                    "Invalid Food Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FoodBox.Focus();
                return;
            }

            if (!drinkPrices.TryGetValue(Normalize(drinkInput), out decimal drinkPrice))
            {
                MessageBox.Show("\"" + drinkInput + "\" is not on the drinks menu. Please check the spelling.",
                    "Invalid Drink Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DrinksBox.Focus();
                return;
            }

           
            if (!int.TryParse(FoodQuantiBox.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int foodQty)
                || foodQty <= 0)
            {
                MessageBox.Show("Food quantity must be a whole number greater than zero.", "Invalid Food Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FoodQuantiBox.Focus();
                return;
            }

            if (!int.TryParse(DrinksQuantiBox.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int drinkQty)
                || drinkQty <= 0)
            {
                MessageBox.Show("Drink quantity must be a whole number greater than zero.", "Invalid Drink Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DrinksQuantiBox.Focus();
                return;
            }

            if (comboBoxOrdertype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order type (Dine - In, Take - Out, or Delivery).",
                    "No Order Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxOrdertype.Focus();
                return;
            }

           
            decimal foodTotal = foodPrice * foodQty;
            decimal drinkTotal = drinkPrice * drinkQty;

           
            decimal subtotal = foodTotal + drinkTotal;

          
            decimal bulkDiscount = subtotal >= BulkDiscountThreshold ? subtotal * BulkDiscountRate : 0m;
            decimal afterBulkDiscount = subtotal - bulkDiscount;

         
            decimal seniorDiscount = checkBoxSenior.Checked ? afterBulkDiscount * SeniorDiscountRate : 0m;

            decimal totalDiscount = bulkDiscount + seniorDiscount;
            decimal amountAfterDiscounts = subtotal - totalDiscount;

            string orderType = comboBoxOrdertype.SelectedItem.ToString();
            decimal surcharge = 0m;
            string surchargeLabel = "";

            switch (orderType)
            {
                case "Take - Out":
                    surcharge = TakeoutCharge;
                    surchargeLabel = "Takeout Charge";
                    break;

                case "Delivery":
                   
                    if (amountAfterDiscounts >= FreeDeliveryThreshold)
                    {
                        surcharge = 0m;
                        surchargeLabel = "Delivery Fee (FREE)";
                    }
                    else
                    {
                        surcharge = DeliveryCharge;
                        surchargeLabel = "Delivery Fee";
                    }
                    break;

                case "Dine - In":
                default:
                    surcharge = 0m;
                    surchargeLabel = "";
                    break;
            }

            
            decimal finalTotal = amountAfterDiscounts + surcharge;

            
            if (!decimal.TryParse(PaymentBox.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal payment)
                || payment < 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Invalid Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PaymentBox.Focus();
                return;
            }

            if (payment < finalTotal)
            {
                MessageBox.Show(
                    "Insufficient payment.\nTotal due: P" + finalTotal.ToString("0.00") +
                    "\nAmount received: P" + payment.ToString("0.00"),
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PaymentBox.Focus();
                return;
            }

           
            decimal change = payment - finalTotal;

          
            ReceiptMultiBox.Text = BuildReceipt(
                foodInput, foodQty, foodPrice, foodTotal,
                drinkInput, drinkQty, drinkPrice, drinkTotal,
                subtotal, totalDiscount, surcharge, surchargeLabel,
                finalTotal, payment, change);
        }

        
        private string BuildReceipt(
            string foodName, int foodQty, decimal foodPrice, decimal foodTotal,
            string drinkName, int drinkQty, decimal drinkPrice, decimal drinkTotal,
            decimal subtotal, decimal discount, decimal surcharge, string surchargeLabel,
            decimal total, decimal payment, decimal change)
        {
            const int width = 32;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(new string('=', width));
            sb.AppendLine(CenterText("ABC CAFE", width));
            sb.AppendLine(new string('=', width));
            sb.AppendLine();

            sb.AppendLine(FormatLine(
                foodName + " " + foodQty + " x P" + foodPrice.ToString("0"),
                "P" + foodTotal.ToString("0.00"), width));
            sb.AppendLine(FormatLine(
                drinkName + " " + drinkQty + " x P" + drinkPrice.ToString("0"),
                "P" + drinkTotal.ToString("0.00"), width));

            sb.AppendLine(new string('-', width));
            sb.AppendLine(FormatLine("Subtotal", "P" + subtotal.ToString("0.00"), width));
            sb.AppendLine(FormatLine("Discount", "P" + discount.ToString("0.00"), width));

            if (!string.IsNullOrEmpty(surchargeLabel))
            {
                sb.AppendLine(FormatLine(surchargeLabel, "P" + surcharge.ToString("0.00"), width));
            }

            sb.AppendLine(new string('-', width));
            sb.AppendLine(FormatLine("TOTAL", "P" + total.ToString("0.00"), width));
            sb.AppendLine();
            sb.AppendLine(FormatLine("Payment", "P" + payment.ToString("0.00"), width));
            sb.AppendLine(FormatLine("Change", "P" + change.ToString("0.00"), width));
            sb.AppendLine(new string('=', width));
            sb.AppendLine(CenterText("THANK YOU!", width));
            sb.AppendLine(new string('=', width));

            return sb.ToString();
        }

        private static string FormatLine(string label, string value, int width)
        {
            if (label.Length + value.Length >= width)
            {
                return label + " " + value;
            }
            return label + new string(' ', width - label.Length - value.Length) + value;
        }

        private static string CenterText(string text, int width)
        {
            if (text.Length >= width) return text;
            int leftPad = (width - text.Length) / 2;
            return new string(' ', leftPad) + text;
        }
    }
}