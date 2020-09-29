using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPizza.Component
{
    public abstract class Pizza
    {
        public abstract double Cost();
        public abstract String GetName();
    }
}
