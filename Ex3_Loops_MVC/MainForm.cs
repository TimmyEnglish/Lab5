namespace Ex3_Loops_MVC
{
    public partial class MainForm : Form
    {
        private MultiplicationController _controller;

        public MainForm()
        {
            InitializeComponent();
            // ����������� ����� �� ����������
            var model = new MultiplicationModel();
            _controller = new MultiplicationController(model);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtInput.Text, out number))
            {
                lbTable.Items.Clear();

                // ������������ ���������� ��� ��������� ����������
                List<string> table = _controller.GenerateTable(number);

                // ³���������� ������� ��������
                foreach (var line in table)
                {
                    lbTable.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("������ �������� �����");
            }
        }
        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text == "������ �����")
            {
                txtInput.Text = "";

                txtInput.ForeColor = Color.Black;
            }
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text = "������ �����";

                txtInput.ForeColor = Color.Silver;
            }
        }
    }
}
