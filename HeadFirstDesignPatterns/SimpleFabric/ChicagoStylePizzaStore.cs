namespace FabricMethod
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type == "veggie")
            {
                return new ChicagoVeggiePizza();
            }
            else return null;
        }
    }
}
