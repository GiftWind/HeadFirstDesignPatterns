using System;

namespace Iterator
{
    class DinerMenu
    {
        static readonly int _maxItems = 6;
        int numberOfItems = 0;
        MenuItem[] MenuItems;
        

        public DinerMenu()
        {
            MenuItems = new MenuItem[_maxItems];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hotdog with saurkraut, relish, onions, topped with cheese", false, 3.05);

        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= _maxItems)
            {
                Console.Error.WriteLine("Sorry, menu is full. Can't add item to menu.");
            }
            else
            {
                MenuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IIterator CreateIterator() 
        {
            return new DinerMenuIterator(MenuItems);
        }

    }
}
