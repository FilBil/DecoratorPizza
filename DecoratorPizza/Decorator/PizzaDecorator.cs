using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPizza.Component;

namespace DecoratorPizza.Decorator
{
    public class PizzaDecorator : Pizza
    {

        // this object will be decorated
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