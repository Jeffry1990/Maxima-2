using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2
{
    public class CoffeeMashine
    {
        public Coffee MakeCoffee(Coffee coffee, int countOfBeans)
        {
        return coffee.Make(countOfBeans);
        }
    }
}
