namespace Decorator
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark roast";
        }
        public override double GetCost()
        {
            return 0.99;
        }
    }
}
