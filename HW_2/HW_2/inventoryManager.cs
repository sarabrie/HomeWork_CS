using System;
using System.Collections.Generic;
using System.Linq;
namespace HW_2
{
    public class InventoryManager
    {
        private List<Medicin> inventory;
        public InventoryManager()
        {
            inventory = new List<Medicin>(50);
        }
        public (bool found, float price, TipeMedicine tipe) searchMedicin(string name)
        {
            foreach (Medicin item in inventory)
            {
                if (item.Name == name)
                {
                    Console.WriteLine($"Medicin found: {item.Name}, Price: {item.Price}, Type: {item.Type}");
                    return (true, item.Price, item.Type);
                }
            }
            Console.WriteLine("Medicin not found.");
            return (false, 0, 0);
        }
        public void DisplayReport()
        {
            foreach (Medicin item in inventory)
            {
                ReadOnlySpan<char> nameSpan = item.Name.AsSpan();
                ReadOnlySpan<char> sliceName = nameSpan.Length >= 3 ? nameSpan.Slice(0, 3) : nameSpan;

                Console.WriteLine(sliceName.ToString());
            }
        }
        public void AddMedicin(Medicin item)
        {
            if (inventory.Count < 50)
            {
                inventory.Add(item);
            }
            else
            {
                Console.WriteLine("המחסן מלא!");
            }
        }
    }

}
