namespace AbstractFactory
{
    class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        {
            this.ingredientFactory = new ChicagoPizzaIngredientFactory();
        }

        internal override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicag Style Cheese Pizza";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
            }
            return pizza;
        }
    }
}
