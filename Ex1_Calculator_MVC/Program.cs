namespace Ex1_Calculator_MVC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize Model, View, and Controller
            CalculatorModel model = new CalculatorModel();
            MainForm view = new MainForm();
            CalculatorController controller = new CalculatorController(model, view);

            Application.Run(view);
        }
    }
}