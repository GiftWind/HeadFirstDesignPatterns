namespace AbstractFactory
{
    public abstract class PizzaStore
    {
        public IPizzaIngredientFactory ingredientFactory;
        
        public Pizza OrderPizza(string item)
        {
            Pizza pizza = CreatePizza(item);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        internal abstract Pizza CreatePizza(string item);
    }
}
