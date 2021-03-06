﻿using System;

namespace AbstractFactory
{
    class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            this.Dough = _ingredientFactory.CreateDough();
            this.Sauce = _ingredientFactory.CreateSauce();
            this.Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
