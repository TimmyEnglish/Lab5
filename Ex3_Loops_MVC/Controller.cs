using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Loops_MVC
{
    public class MultiplicationController
    {
        private MultiplicationModel _model;

        // Ініціалізація моделі через конструктор
        public MultiplicationController(MultiplicationModel model)
        {
            _model = model;
        }

        // Метод для генерації таблиці множення
        public List<string> GenerateTable(int number)
        {
            _model.Number = number;
            return _model.GetMultiplicationTable();
        }
    }
}
