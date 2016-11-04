namespace Decorator
{
    abstract class Beverage
    {
        public string Description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return this.Description;
        }


        public abstract double GetCost();

    }
}
