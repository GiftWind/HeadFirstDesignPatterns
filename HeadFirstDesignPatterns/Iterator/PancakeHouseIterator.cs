using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class PancakeHouseIterator : IIterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
