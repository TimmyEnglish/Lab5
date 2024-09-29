using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Loops_MVC
{
    public class MultiplicationModel
    {
        // Поле для числа
        private int _number;

        // Властивість для доступу до числа
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Метод для отримання таблиці множення
        public List<string> GetMultiplicationTable()
        {
            List<string> table = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                table.Add($"{_number} x {i} = {_number * i}");
            }
            return table;
        }
    }
}
