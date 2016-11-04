namespace Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend Coffee";
        }

        public override double GetCost()
        {
            return 0.89;
        }
    }
}
