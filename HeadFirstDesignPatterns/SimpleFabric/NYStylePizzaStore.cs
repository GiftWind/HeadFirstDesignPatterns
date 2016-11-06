namespace FabricMethod
{
    class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                return new NYStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                return new NYStyleClamPizza();
            }
            else if (type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            else return null;
        }
    }
}
