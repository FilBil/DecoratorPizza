using DecoratorPizza.Component;


namespace DecoratorPizza.ComponentElements
{
    public class LargePizza : Pizza
    {
        public override double Cost()
        {
            return 40.00;
        }

        public override string GetName()
        {
            return "Large Pizza";
        }
    }
}
