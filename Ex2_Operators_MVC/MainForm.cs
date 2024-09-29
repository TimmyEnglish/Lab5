namespace Ex2_Operators_MVC
{
    public partial class MainForm : Form
    {
        private AgeController controller;

        public MainForm()
        {
            InitializeComponent();
            AgeModel model = new AgeModel();
            controller = new AgeController(model);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAge.Text, out int age))
            {
                string category = controller.DetermineAgeCategory(age);

                lblResult.Text = $"¬и належите до категор≥њ: {category}";
            }
            else
            {
                lblResult.Text = "Ѕудь ласка, введ≥ть коректний в≥к.";
            }
        }
        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "¬вед≥ть ваш в≥к")
            {
                txtAge.Text = "";

                txtAge.ForeColor = Color.Black;
            }
        }
        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                txtAge.Text = "¬вед≥ть ваш в≥к";

                txtAge.ForeColor = Color.Silver;
            }
        }
    }
}
