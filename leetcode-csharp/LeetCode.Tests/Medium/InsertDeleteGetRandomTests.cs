namespace LeetCode.Tests.Medium;

using LeetCode.Problems.Medium;
using System.Text.Json;

public class RandomizedSetTests
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void ExecuteOperations_ReturnsExpectedResults(string operationsJson, string argumentsJson)
    {
        // Parse input
        var operations = JsonSerializer.Deserialize<string[]>(operationsJson)!;
        var arguments = JsonSerializer.Deserialize<JsonElement[][]>(argumentsJson)!;

        // Arrange
        RandomizedSet? randomizedSet = null;

        // Act & Assert
        for (int i = 0; i < operations.Length; i++)
        {
            var operation = operations[i];
            var args = arguments[i];

            switch (operation)
            {
                case "RandomizedSet":
                    randomizedSet = new RandomizedSet();
                    break;

                case "insert":
                    var insertValue = args[0].GetInt32();
                    randomizedSet!.Insert(insertValue);
                    break;

                case "remove":
                    var removeValue = args[0].GetInt32();
                    randomizedSet!.Remove(removeValue);
                    break;

                case "getRandom":
                    var result = randomizedSet!.GetRandom();
                    Assert.IsType<int>(result);
                    break;

                default:
                    throw new InvalidOperationException($"Unknown operation: {operation}");
            }
        }
    }

    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[]
        {
            @"[""RandomizedSet"",""insert"",""remove"",""insert"",""getRandom"",""remove"",""insert"",""getRandom""]",
            @"[[],[1],[2],[2],[],[1],[2],[]]"
        };

        yield return new object[]
        {
            @"[""RandomizedSet"",""insert"",""insert"",""remove"",""insert"",""getRandom""]",
            @"[[],[0],[1],[0],[2],[]]"
        };

        yield return new object[]
        {
            @"[""RandomizedSet"",""insert"",""insert"",""insert"",""insert"",""insert"",""remove"",""getRandom"",""getRandom""]",
            @"[[],[3],[3],[1],[2],[1],[1],[],[]]"
        };
    }
}
