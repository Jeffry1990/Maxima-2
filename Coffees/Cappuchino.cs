using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2.Coffees
{
    public class Cappuchino : Coffee
    {
        public override Cappuchino Make(int countOfBeans)
        {
            CountOfBeans = countOfBeans;
            Console.WriteLine($"\nНапиток Каппучино. Количетсво кофейных зерен: {countOfBeans}гр.");
            return new Cappuchino();
        }
    }
}
