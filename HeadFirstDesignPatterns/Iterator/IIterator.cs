using System;

namespace Iterator
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
