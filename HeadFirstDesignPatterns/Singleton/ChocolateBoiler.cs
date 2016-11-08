namespace Singleton
{
    class ChocolateBoiler
    {
        private bool _isEmpty;
        private bool _isBoiled;
        private static ChocolateBoiler _boiler;

        private ChocolateBoiler()
        {
            _isEmpty = true;
            _isBoiled = false;
        }

        public static ChocolateBoiler GetBoiler()
        {
            if (_boiler == null)
            {
                _boiler = new ChocolateBoiler();
            }
            return _boiler;
        }

        public void Fill()
        {
            if (_isEmpty)
            {
                _isEmpty = false;
                _isBoiled = false;
            }
        }

        public void Drain()
        {
            if (!_isEmpty && _isBoiled)
            {
                _isEmpty = true;
            }
        }

        public void Boil()
        {
            if (!_isEmpty && !_isBoiled)
            {
                _isBoiled = true;
            }
        }
    }
}
