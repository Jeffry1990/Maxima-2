using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2.Coffees
{
    public class Espresso : Coffee
    {
        public override Espresso Make(int countOfBeans)
        {
            CountOfBeans = countOfBeans;
            Console.WriteLine($"\nНапиток Эспрессо. Количетсво кофейных зерен: {countOfBeans}гр.");
            return new Espresso();
        }
    }
}
