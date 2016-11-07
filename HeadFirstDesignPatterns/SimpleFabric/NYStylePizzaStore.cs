namespace FactoryMethod
{
    class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                case "clam":
                    return new NYStyleClamPizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
