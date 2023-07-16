namespace Tugas_3_Dede
{
    public partial class Form1 : Form
    {
        double number1 = 0.0;
        double number2 = 0.0;
        double result = 0.0;
        string operators = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains(","))
            {
                label1.Text += ",";
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                if (label1.Text.Contains('-'))
                {
                    label1.Text = label1.Text.Trim('-');
                }
                else
                {
                    label1.Text = "-" + label1.Text;
                }
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            if (label1.Text == "")
            {
                label1.Text = "0";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            label2.Text = number1 + " x ";
            label1.ResetText();
            operators = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            label2.Text = label1.Text + " ÷ ";
            label1.ResetText();
            operators = "÷";
        }

        private void add_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            label2.Text = label1.Text + " + ";
            label1.ResetText();
            operators = "+";
        }

        private void substract_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(label1.Text);
            label2.Text = number1 + " - ";
            label1.ResetText();
            operators = "-";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            label2.Text += number2 + " = ";
            number2 = Convert.ToDouble(label1.Text);
            switch (operators)
            {
                case "*":
                    result = number1 * number2;
                    if(label2.Text.Contains('='))
                    {
                        label2.Text = number1 + " x " + number2 + " = ";
                    }
                    break;

                case "÷":
                    result = number1 / number2;
                    if (label2.Text.Contains('='))
                    {
                        label2.Text = number1 + " ÷ " + number2 + " = ";
                    }
                    break;

                case "+":
                    result = number1 + number2;
                    if (label2.Text.Contains('='))
                    {
                        label2.Text = number1 + " + " + number2 + " = ";
                    }
                    break;

                case "-":
                    result = number1 - number2;
                    if (label2.Text.Contains('='))
                    {
                        label2.Text = number1 + " - " + number2 + " = ";
                    }
                    break;
            }
            label1.Text = result.ToString();
        }

        private void ce_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void c_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
    }
}