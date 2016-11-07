namespace FactoryMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "veggie":
                    return new ChicagoVeggiePizza();
                default:
                    return null;
            }
        }
    }
}
