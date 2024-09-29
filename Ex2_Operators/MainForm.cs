namespace Ex2_Operators
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAge.Text, out int age))
            {
                string category = (age >= 0 && age <= 12) ? "Дитина" :
                                  (age >= 13 && age <= 17) ? "Підліток" :
                                  (age >= 18) ? "Дорослий" : "Некоректний вік";
                lblResult.Text = $"Ви належите до категорії: {category}";
            }
            else
            {
                lblResult.Text = "Будь ласка, введіть коректний вік.";
            }
        }
        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "Введіть ваш вік")
            {
                txtAge.Text = "";

                txtAge.ForeColor = Color.Black;
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                txtAge.Text = "Введіть ваш вік";

                txtAge.ForeColor = Color.Silver;
            }
        }
    }
}
