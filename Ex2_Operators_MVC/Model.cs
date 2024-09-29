using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Operators_MVC
{
    public class AgeModel
    {
        public int Age { get; set; }
        public string GetAgeCategory()
        {
            if (Age >= 0 && Age <= 12)
                return "Дитина";
            else if (Age >= 13 && Age <= 17)
                return "Підліток";
            else if (Age >= 18)
                return "Дорослий";
            else
                return "Некоректний вік";
        }
    }

}
