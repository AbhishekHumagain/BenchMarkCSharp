```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.0 (24A5289g) [Darwin 24.0.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.401
  [Host]     : .NET 8.0.8 (8.0.824.36612), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.8 (8.0.824.36612), Arm64 RyuJIT AdvSIMD


```
| Method                    | Mean      | Error    | StdDev   |
|-------------------------- |----------:|---------:|---------:|
| AddOrUpdateData_Benchmark | 146.37 ns | 1.468 ns | 1.301 ns |
| GetData_Benchmark         |  33.86 ns | 0.207 ns | 0.162 ns |
