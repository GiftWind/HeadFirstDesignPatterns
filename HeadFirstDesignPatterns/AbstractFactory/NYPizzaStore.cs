﻿namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
            this.ingredientFactory = new NYPizzaIngredientFactory();
        }
        internal override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
            }
            return pizza;
        }
        
    }
}
