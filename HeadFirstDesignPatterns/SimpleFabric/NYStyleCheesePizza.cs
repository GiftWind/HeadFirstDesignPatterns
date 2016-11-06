namespace SimpleFabric
{
    internal class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this.Name = "NY style Sauce and Cheese pizza";
            this.Dough = "Thin crust dough";
            this.Sauce = "Marinara sauce";

            Toppings.Add("Grated Reggiano Cheese");
            
        }
    }
}