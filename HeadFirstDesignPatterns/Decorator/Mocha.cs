namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

       public override string GetDescription() => $"{this._beverage.GetDescription()}, Mocha";

        public override double GetCost()
        {
            return 0.20 + this._beverage.GetCost();
        }
    }
}
