namespace ConsoleApp1 { 



    internal public interface IControllable
    {
        void TurnOn();
        void TurnOff();
        bool IsOn { get; }
    }
}