namespace AbstractFactory
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Spinach(), new BlackOlives(), new EggPlant() };
            return veggies; 
        }
    }
}
