using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxima_2
{
    public abstract class Coffee
    {
        public int CountOfBeans { get; set; }
        public abstract Coffee Make(int countOfBeans);
    }
}
