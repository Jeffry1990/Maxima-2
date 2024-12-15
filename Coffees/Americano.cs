using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2.Coffees
{
    public class Americano : Coffee
    {
        public override Americano Make(int countOfBeans)
        {
            CountOfBeans = countOfBeans;
            Console.WriteLine($"\nНапиток Американо. Количетсво кофейных зерен: {countOfBeans}гр.");
            return new Americano();
        }
    }
}
    