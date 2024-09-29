namespace Ex1_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation('/');
        }

        private void PerformOperation(char operation)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Ділення на нуль неможливе");
                        break;
                }

                txtResult.Text = $"{result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.");
            }
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            if (txtNumber1.Text == "Перше число")
            {
                txtNumber1.Text = "";

                txtNumber1.ForeColor = Color.Black;
            }
        }

        private void txtNumber1_Leave(object sender, EventArgs e)
        {
            if (txtNumber1.Text == "")
            {
                txtNumber1.Text = "Перше число";

                txtNumber1.ForeColor = Color.Silver;
            }
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            if (txtNumber2.Text == "Друге число")
            {
                txtNumber2.Text = "";

                txtNumber2.ForeColor = Color.Black;
            }
        }

        private void txtNumber2_Leave(object sender, EventArgs e)
        {
            if (txtNumber2.Text == "")
            {
                txtNumber2.Text = "Друге число";

                txtNumber2.ForeColor = Color.Silver;
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            txtResult.ForeColor = Color.Black;
        }

        private void txtResult_Enter(object sender, EventArgs e)
        {
            if(txtResult.Text == "Результат")
            {
                txtResult.Text = "";

                txtResult.ForeColor = Color.Black;
            }
        }

        private void txtResult_Leave(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "Результат";

                txtResult.ForeColor = Color.Silver;
            }
        }
    }
}
