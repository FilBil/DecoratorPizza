using DecoratorPizza.Component;


namespace DecoratorPizza.ComponentElements
{
    public class SmallPizza : Pizza
    {
        public override double Cost()
        {
            return 20.00;
        }

        public override string GetName()
        {
            return "Small Pizza";
        }
    }
}
