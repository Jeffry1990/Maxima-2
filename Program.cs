using Maxima_2.Coffees;

namespace Maxima_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region

            var coffeMashine = new CoffeeMashine();
            var espresso = coffeMashine.MakeCoffee(new Espresso(), 30);
            var americano = coffeMashine.MakeCoffee(new Americano(), 20);
            var flatwhite = coffeMashine.MakeCoffee(new FlatWhite(), 25);
            var cappuchino = coffeMashine.MakeCoffee(new Cappuchino(), 20);
            var latte = coffeMashine.MakeCoffee(new Latte(), 10);
 
            #endregion
        }
    }
}

