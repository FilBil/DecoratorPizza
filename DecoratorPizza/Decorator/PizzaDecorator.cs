using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPizza.Component;

namespace DecoratorPizza.Decorator
{
    public class PizzaDecorator : Pizza
    {

        //obiekt który będzie dekorowany
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override double Cost()
        {
            return _pizza.Cost();
        }

        public override string GetName()
        {
            return _pizza.GetName();
        }
    }
}