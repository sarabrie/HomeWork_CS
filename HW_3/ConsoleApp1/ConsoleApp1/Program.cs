namespace ConsoleApp1 { 

    class program
    {
        static void Main()
        {
            SmartRoom livingRoom = new SmartRoom();
            var acId = new DeviceIdentity("AC-123", 2024, "01/01/2026", "BestBuy");
            var lampId = new DeviceIdentity("L-999", 2025, "15/02/2026", "IKEA");
            livingRoom["MainAC"]?.TurnOn();
            livingRoom["BedsideLamp"]?.TurnOn();
            // acId.SerialNumber = "New-Serial"; 
            // livingRoom["MainAC"].IsOn = true;

        }
    }
}