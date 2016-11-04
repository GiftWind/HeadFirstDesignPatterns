namespace Decorator
{
    class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription() => $"{this._beverage.GetDescription()}, Soy";

        public override double GetCost()
        {
            return 0.15 + this._beverage.GetCost();
        }
    }
}
