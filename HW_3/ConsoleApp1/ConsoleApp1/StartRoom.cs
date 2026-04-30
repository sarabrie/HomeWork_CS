namespace ConsoleApp1
{
    internal class SmartRoom
    {
        private List<IControllable> _devices = new List<IControllable>();
        public IControllable this[string name]
        {
            get
            {
                return _devices.FirstOrDefault(d => d is product p && p.Name == name);
            }
        }
    }
}
