using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CPUIntensivePOC;

public class CpuBoundProcessorBenchmark
{
    private CpuBoundProcessor _processor;
    private List<int> _data;

    [GlobalSetup]
    public void Setup()
    {
        _processor = new CpuBoundProcessor();
        _data = Enumerable.Range(1, 10000).ToList();
    }

    [Benchmark]
    public void TestProcessDataInParallel()
    {
        _processor.ProcessDataInParallel(_data);
    }

    [Benchmark]
    public void TestProcessDataUsingThreads()
    {
        _processor.ProcessDataUsingThreads(_data);
    }
}

