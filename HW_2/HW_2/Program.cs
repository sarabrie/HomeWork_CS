using System;
using HW_2;

class Program
{
    static void Main(string[] args)
    {
        InventoryManager manager = new InventoryManager();

        var dim1 = new PackagingDimensions(10.5f, 5.0f, 2.0f);
        var dim2 = new PackagingDimensions(15.0f, 10.0f, 5.5f);
        var dim3 = new PackagingDimensions(3.0f, 3.0f, 8.0f);

        manager.AddMedicin(new Medicin(25.90f, "Aspirin-Plus", dim1, TipeMedicine.aspirin));
        manager.AddMedicin(new Medicin(12.50f, "Paracetamol-Kids", dim2, TipeMedicine.paracetamol));
        manager.AddMedicin(new Medicin(55.00f, "Ibuprofen-Max", dim3, TipeMedicine.ibuprofen));

        Console.WriteLine("--- הנתונים הוזנו בהצלחה למערכת ---");

        Console.WriteLine("\nבדיקת חיפוש:");
        string searchName = "Aspirin-Plus";
        var (found, price, type) = manager.searchMedicin(searchName);

        if (found)
        {
            Console.WriteLine($"תוצאה: התרופה {searchName} נמצאה. מחיר: {price}, קטגוריה: {type}");
            Log.WriteLog($"חיפוש בוצע בהצלחה עבור: {searchName}"); // [cite: 21]
        }

        // 4. בדיקת תצוגת דוח (3 אותיות ראשונות) [cite: 18]
        Console.WriteLine("\n--- דוח מלאי (3 אותיות ראשונות) ---");
        manager.DisplayReport();

        // 5. בדיקת קובץ ה-LOG 
        Log.WriteLog("סיום הרצת בדיקות מערכת.");
        Console.WriteLine("\nהפעולות נרשמו בקובץ system_log.txt");

        Console.WriteLine("\nלחץ על מקש כלשהו ליציאה...");
        Console.ReadKey();
    }
}