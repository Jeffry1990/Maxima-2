using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2.Coffees
{
    public class FlatWhite : Coffee
    {
        public override FlatWhite Make(int countOfBeans)
        {
            CountOfBeans = countOfBeans;
            Console.WriteLine($"\nНапиток Флэт Уайт. Количетсво кофейных зерен: {countOfBeans}гр.");
            return new FlatWhite();
        }
    }
}
