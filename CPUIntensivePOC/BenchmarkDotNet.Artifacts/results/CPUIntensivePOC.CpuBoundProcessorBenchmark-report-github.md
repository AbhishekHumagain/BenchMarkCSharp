```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.0 (24A5289g) [Darwin 24.0.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.401
  [Host]     : .NET 8.0.8 (8.0.824.36612), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.8 (8.0.824.36612), Arm64 RyuJIT AdvSIMD


```
| Method                      | Mean     | Error    | StdDev   | Median   |
|---------------------------- |---------:|---------:|---------:|---------:|
| TestProcessDataInParallel   | 362.9 ms | 17.70 ms | 50.22 ms | 356.7 ms |
| TestProcessDataUsingThreads | 335.8 ms |  8.53 ms | 24.20 ms | 328.5 ms |
