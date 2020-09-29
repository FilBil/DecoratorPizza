using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPizza.Component;
using DecoratorPizza.ComponentElements;
using DecoratorPizza.DecoratorElements;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();

            largePizza = new PineappleDecorator(largePizza);
            largePizza = new HamDecorator(largePizza);
          

            Console.WriteLine("{0:C2}", largePizza.Cost());
            Console.WriteLine(largePizza.GetName());

            Console.ReadKey();
        }
    }
}
