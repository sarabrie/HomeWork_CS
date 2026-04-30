namespace ConsoleApp1
{
    internal class WashingMachine:product
    {
        public void turnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }
        public void turnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }
        
    }
}
