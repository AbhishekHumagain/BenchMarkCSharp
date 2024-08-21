namespace MemoryIntensivePoc;

public class LargeObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte[] Data { get; set; }

    public LargeObject(int id, string name, byte[] data)
    {
        Id = id;
        Name = name;
        Data = data;
    }

    public int CalculateSize()
    {
        return Data.Length;
    }
}
