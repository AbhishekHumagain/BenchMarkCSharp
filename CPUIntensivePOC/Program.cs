// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Running;
using CPUIntensivePOC;

Console.WriteLine("Cpu intensive POC!!");
var cpuSummary = BenchmarkRunner.Run<MonitorCpuUsageDuringExecution>();

Console.ReadLine();