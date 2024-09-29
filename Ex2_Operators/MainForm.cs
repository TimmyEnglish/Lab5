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
                string category = (age >= 0 && age <= 12) ? "������" :
                                  (age >= 13 && age <= 17) ? "ϳ�����" :
                                  (age >= 18) ? "��������" : "����������� ��";
                lblResult.Text = $"�� �������� �� �������: {category}";
            }
            else
            {
                lblResult.Text = "���� �����, ������ ��������� ��.";
            }
        }
        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text == "������ ��� ��")
            {
                txtAge.Text = "";

                txtAge.ForeColor = Color.Black;
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                txtAge.Text = "������ ��� ��";

                txtAge.ForeColor = Color.Silver;
            }
        }
    }
}
