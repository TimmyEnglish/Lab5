namespace Ex1_Calculator_MVC
{
    public partial class MainForm : Form
    {
        public event EventHandler AddButtonClicked;
        public event EventHandler SubtractButtonClicked;
        public event EventHandler MultiplyButtonClicked;
        public event EventHandler DivideButtonClicked;

        public MainForm()
        {
            InitializeComponent();
        }
        public double Number1
        {
            get
            {
                if (double.TryParse(txtNumber1.Text, out double num1))
                    return num1;
                else
                    throw new FormatException("Invalid input for Number1");
            }
        }
        public double Number2
        {
            get
            {
                if (double.TryParse(txtNumber2.Text, out double num2))
                    return num2;
                else
                    throw new FormatException("Invalid input for Number2");
            }
        }
        public void DisplayResult(double result)
        {
            txtResult.Text = $"{result}";
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            SubtractButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            MultiplyButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            DivideButtonClicked?.Invoke(this, EventArgs.Empty);
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
            if (txtResult.Text == "Результат")
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

