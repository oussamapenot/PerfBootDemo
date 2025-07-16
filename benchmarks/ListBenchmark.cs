using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class ListBenchmark
{
    private readonly OrderService _service = new();

    [Benchmark(Baseline = true)]
    public List<Order> Original() => _service.GetActiveOrders();

    [Benchmark]
    public IReadOnlyList<Order> Optimized() => _service.GetActiveOrders().AsReadOnly();
}

public class Program
{
    public static void Main() => BenchmarkRunner.Run<ListBenchmark>();
}
