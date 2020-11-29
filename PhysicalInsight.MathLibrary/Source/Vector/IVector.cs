namespace PhysicalInsight.MathLibrary
{
    public interface IVector<T>
    {
        int NumberOfElements { get; }
        T[] Data { get; set; }
    }
}