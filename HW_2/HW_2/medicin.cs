
namespace HW_2
{
    public enum TipeMedicine : byte
    {
        aspirin,
        paracetamol,
        ibuprofen
    }
    public class Medicin
    {
        public float Price { get; set; }
        public string Name { get; set; }
        public PackagingDimensions Package { get; }
        public TipeMedicine Type { get; set; }
        public Medicin(float price, string name, PackagingDimensions package, TipeMedicine type)
        {
            this.Price = price;
            this.Name = name;
            this.Package = package;
            this.Type = type;
        }
    }
}
