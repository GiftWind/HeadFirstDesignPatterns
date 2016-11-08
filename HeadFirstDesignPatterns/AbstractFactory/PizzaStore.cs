namespace AbstractFactory
{
    public abstract class PizzaStore
    {
        IPizzaIngredientFactory _ingredientFactory;
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        internal abstract Pizza CreatePizza(string type);
    }
}
