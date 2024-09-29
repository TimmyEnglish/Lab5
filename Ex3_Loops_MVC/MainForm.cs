namespace Ex3_Loops_MVC
{
    public partial class MainForm : Form
    {
        private MultiplicationController _controller;

        public MainForm()
        {
            InitializeComponent();
            // Ініціалізація моделі та контролера
            var model = new MultiplicationModel();
            _controller = new MultiplicationController(model);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtInput.Text, out number))
            {
                lbTable.Items.Clear();

                // Використання контролера для отримання результату
                List<string> table = _controller.GenerateTable(number);

                // Відображення таблиці множення
                foreach (var line in table)
                {
                    lbTable.Items.Add(line);
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
