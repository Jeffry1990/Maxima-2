using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2.Coffees
{
    public class Latte : Coffee
    {
        public override Latte Make(int countOfBeans)
        {
            CountOfBeans = countOfBeans;
            Console.WriteLine($"\nНапиток Латте. Количетсво кофейных зерен: {countOfBeans}гр.");
            return new Latte();
        }
    }
}
