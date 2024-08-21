using System.Diagnostics;

namespace CPUIntensivePOC;

public class MonitorCpuUsageDuringExecution
{
    public void MonitorCpuUsageDuringExecutionMethod()
    {
        var processor = new CpuBoundProcessor();
        var dataSet = Enumerable.Range(1, 10000).ToList(); // Test data set

        var cpuUsageBefore = Process.GetCurrentProcess().TotalProcessorTime;
        processor.ProcessDataInParallel(dataSet);
        var cpuUsageAfter = Process.GetCurrentProcess().TotalProcessorTime;

        var cpuUsage = cpuUsageAfter - cpuUsageBefore;
        Console.WriteLine($"CPU time used: {cpuUsage.TotalMilliseconds} ms");
    }
}

