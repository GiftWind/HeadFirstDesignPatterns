namespace Decorator
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            this.Description = "Decaf";
        }
        public override double GetCost()
        {
            return 1.05;
        }
    }
}
