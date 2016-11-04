namespace Decorator
{
    class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription() => $"{this._beverage.GetDescription()}, Whip";

        public override double GetCost()
        {
            return 0.10 + this._beverage.GetCost();
        }
    }
}
