// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Running;
using MemoryIntensivePoc;

Console.WriteLine("Memory intensive POC!!");
var memorySummary = BenchmarkRunner.Run<InMemoryDataProcessorBenchmark>();

Console.ReadLine();