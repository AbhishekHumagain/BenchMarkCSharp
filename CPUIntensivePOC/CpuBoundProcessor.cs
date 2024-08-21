namespace CPUIntensivePOC;

public class CpuBoundProcessor
{
    public void ProcessDataInParallel(IEnumerable<int> data)
    {
        // Parallelize the processing of data using PLINQ
        var results = data.AsParallel().Select(x => ComplexComputation(x)).ToList();
        
        // Handle the results
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    private int ComplexComputation(int value)
    {
        // Simulate a CPU-intensive operation
        int result = 0;
        for (int i = 0; i < 1000000; i++)
        {
            result += (value * i) % 1000;
        }
        return result;
    }

    public void ProcessDataUsingThreads(IEnumerable<int> data)
    {
        // Process data using manual threading
        List<Thread> threads = new List<Thread>();

        foreach (var item in data)
        {
            Thread thread = new Thread(() => ComplexComputation(item));
            threads.Add(thread);
            thread.Start();
        }

        // Wait for all threads to complete
        foreach (var thread in threads)
        {
            thread.Join();
        }
    }
}
