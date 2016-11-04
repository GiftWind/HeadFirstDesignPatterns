namespace Decorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }
}
