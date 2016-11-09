namespace Singleton
{
    public sealed class ChocolateBoiler
    {
        public bool IsEmpty { get; private set; }
        public bool IsBoiled { get; private set; }
        static volatile ChocolateBoiler _boiler;
        static readonly object _syncRoot = new object();

        ChocolateBoiler()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        public static ChocolateBoiler GetBoiler()
        {
            if (_boiler == null)
            {
                lock(_syncRoot)
                {
                    if (_boiler == null)
                    {
                        _boiler = new ChocolateBoiler();
                    }
                }
            }
            return _boiler;
        }

        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
                IsBoiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty && IsBoiled)
            {
                IsEmpty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !IsBoiled)
            {
                IsBoiled = true;
            }
        }
    }
}
