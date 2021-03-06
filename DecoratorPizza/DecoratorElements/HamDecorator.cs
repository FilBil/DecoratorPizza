﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPizza.Component;
using DecoratorPizza.Decorator;

namespace DecoratorPizza.DecoratorElements
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 4.25;
        }

        public override string GetName()
        {
            return base.GetName() + ", Ham";
        }
    }
}
