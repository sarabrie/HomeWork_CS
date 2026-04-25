public readonly struct PackagingDimensions
{
    public float Length { get; }
    public float Width { get; }
    public float Height { get; }

    public PackagingDimensions(float l, float w, float h)
    {
        this.Length = l;
        this.Width = w;
        this.Height = h;
    }
}