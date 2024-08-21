using BenchmarkDotNet.Attributes;

namespace MemoryIntensivePoc;

public class InMemoryDataProcessorBenchmark
{
    private InMemoryDataProcessor _processor;
    private LargeObject _largeObject;

    [GlobalSetup]
    public void Setup()
    {
        _processor = new InMemoryDataProcessor();
        _largeObject = new LargeObject(1, "TestObject", new byte[1024 * 1024]); // 1 MB object
    }

    [Benchmark]
    public void AddOrUpdateData_Benchmark()
    {
        _processor.AddOrUpdateData("key-1", _largeObject);
    }

    [Benchmark]
    public void GetData_Benchmark()
    {
        _processor.GetData("key-1");
    }
}