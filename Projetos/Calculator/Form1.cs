using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Calculator {
    public partial class Form1 : Form {

        public decimal result {
            get; set;
        }

        public decimal value {
            get; set;
        }

        public Form1() {
            InitializeComponent();
        }

        private Operation SelectedOperation {
            get; set;
        }


        private enum Operation {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Percentage
        }


        private void btn_0_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "0";
            }
            else {
                txt_result.Text += "0";
            }
        }


        private void btn_1_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "1";
            }
            else {
                txt_result.Text += "1";
            }
        }


        private void btn_2_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "2";
            }
            else {
                txt_result.Text += "2";
            }

        }


        private void btn_3_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "3";
            }
            else {
                txt_result.Text += "3";
            }
        }


        private void btn_4_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "4";
            }
            else {
                txt_result.Text += "4";
            }
        }


        private void btn_5_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "5";
            }
            else {
                txt_result.Text += "5";
            }
        }


        private void btn_6_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "6";
            }
            else {
                txt_result.Text += "6";
            }
        }


        private void btn_7_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "7";
            }
            else {
                txt_result.Text += "7";
            }
        }


        private void btn_8_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "8";
            }
            else {
                txt_result.Text += "8";
            }
        }


        private void btn_9_Click(object sender, EventArgs e) {
            if (txt_result.Text == "0") {
                txt_result.Text = "9";
            }
            else {
                txt_result.Text += "9";
            }
        }


        private void btn_addition_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Addition;
            value = Convert.ToDecimal(txt_result.Text);
            txt_result.Text = "";
            lb_current_operation.Text = $"{Convert.ToString(value)} + ";
        }


        private void btn_subtraction_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Subtraction;
            value = Convert.ToDecimal(txt_result.Text);
            txt_result.Text = "";
            lb_current_operation.Text = $"{Convert.ToString(value)} - ";
        }


        private void btn_multiplication_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Multiplication;
            value = Convert.ToDecimal(txt_result.Text);
            txt_result.Text = "";
            lb_current_operation.Text = $"{Convert.ToString(value)} X ";
        }


        private void btn_division_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Division;
            value = Convert.ToDecimal(txt_result.Text);
            txt_result.Text = "";
            lb_current_operation.Text = $"{Convert.ToString(value)} / ";
        }


        private void btn_percentage_Click(object sender, EventArgs e) {
            SelectedOperation = Operation.Percentage;
            value = Convert.ToDecimal(txt_result.Text);
            txt_result.Text = "";
            lb_current_operation.Text = $"{Convert.ToString(value)} % ";
        }


        private void btn_equal_Click(object sender, EventArgs e) {
            switch (SelectedOperation) {
                case Operation.Addition:
                    result = value + Convert.ToDecimal(txt_result.Text);
                    break;

                case Operation.Subtraction:
                    result = value - Convert.ToDecimal(txt_result.Text);
                    break;

                case Operation.Multiplication:
                    result = value * Convert.ToDecimal(txt_result.Text);
                    break;

                case Operation.Division:
                    result = value / Convert.ToDecimal(txt_result.Text);
                    break;

                case Operation.Percentage:
                    result = (value / 100) * Convert.ToDecimal(txt_result.Text);
                    break;

                default:
                    break;
            }

            lb_current_operation.Text += Convert.ToString(txt_result.Text);
            txt_result.Text = Convert.ToString(result);
            //txt_result.Text = result.ToString("F6", CultureInfo.InvariantCulture);
        }


        private void btn_ac_Click(object sender, EventArgs e) {
            txt_result.Text = "";
            lb_current_operation.Text = "";
            //value = 0;
        }


        private void btn_comma_Click(object sender, EventArgs e) {
            if (!txt_result.Text.Contains(",")) {
                txt_result.Text += ",";
            }
        }


        private void btn_delete_Click(object sender, EventArgs e) {
            txt_result.Text = txt_result.Text.Substring(0, txt_result.Text.Length - 1);
        }

    }
}