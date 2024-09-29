using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Operators_MVC
{
    public class AgeController
    {
        private AgeModel model;
        public AgeController(AgeModel model)
        {
            this.model = model;
        }
        public string DetermineAgeCategory(int age)
        {
            model.Age = age;
            return model.GetAgeCategory();
        }
    }
}
