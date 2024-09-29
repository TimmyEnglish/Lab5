namespace Ex3_Loops
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtInput.Text, out number))
            {
                lbTable.Items.Clear(); // Очищення списку перед новою таблицею

                // Створення таблиці множення за допомогою циклу for
                for (int i = 1; i <= 10; i++)
                {
                    lbTable.Items.Add($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректне число");
            }
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text == "Введіть число")
            {
                txtInput.Text = "";

                txtInput.ForeColor = Color.Black;
            }
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text = "Введіть число";

                txtInput.ForeColor = Color.Silver;
            }
        }
    }
}
