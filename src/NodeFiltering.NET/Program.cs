
public record class Node
{
    public int Value { get; init; }
    public Node[] Children { get; init; } = default!;

    public int SumChildren => Children.Sum(c => c.Value);
}

public class Program
{
    public static void Main()
    {
        var nodes = new[]
        {
            new Node { Value = 1,
                Children = new[] {
                    new Node { Value = 0 },
                    new Node { Value = 0 },
                }
            },
            new Node { Value = 2,
                Children = new[] {
                    new Node { Value = 1 },
                    new Node { Value = -1 },
                }
            },new Node { Value = 3,
                Children = new[] {
                    new Node { Value = 1 },
                    new Node { Value = 1 },
                }
            },
        };

        var result = nodes
            .Where(n => n.SumChildren > 0)
            .ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}
