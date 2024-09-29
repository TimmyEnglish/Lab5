using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Calculator_MVC
{
    public class CalculatorController
    {
        private readonly CalculatorModel _model;
        private readonly MainForm _view;

        public CalculatorController(CalculatorModel model, MainForm view)
        {
            _model = model;
            _view = view;

            _view.AddButtonClicked += OnAddButtonClicked;
            _view.SubtractButtonClicked += OnSubtractButtonClicked;
            _view.MultiplyButtonClicked += OnMultiplyButtonClicked;
            _view.DivideButtonClicked += OnDivideButtonClicked;
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            double num1 = _view.Number1;
            double num2 = _view.Number2;
            double result = _model.Add(num1, num2);
            _view.DisplayResult(result);
        }

        private void OnSubtractButtonClicked(object sender, EventArgs e)
        {
            double num1 = _view.Number1;
            double num2 = _view.Number2;
            double result = _model.Subtract(num1, num2);
            _view.DisplayResult(result);
        }

        private void OnMultiplyButtonClicked(object sender, EventArgs e)
        {
            double num1 = _view.Number1;
            double num2 = _view.Number2;
            double result = _model.Multiply(num1, num2);
            _view.DisplayResult(result);
        }

        private void OnDivideButtonClicked(object sender, EventArgs e)
        {
            double num1 = _view.Number1;
            double num2 = _view.Number2;
            try
            {
                double result = _model.Divide(num1, num2);
                _view.DisplayResult(result);
            }
            catch (DivideByZeroException ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
