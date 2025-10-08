# LeetCode C# Practice

A structured .NET solution for practicing LeetCode problems with xUnit tests.

## Folder Structure

```
leetcode-csharp/
├── LeetCode.sln                 # Solution file
├── LeetCode.Problems/           # Class library with problem solutions
│   ├── Easy/                    # Easy difficulty problems
│   ├── Medium/                  # Medium difficulty problems
│   └── Hard/                    # Hard difficulty problems
└── LeetCode.Tests/              # xUnit test project
    ├── Easy/                    # Tests for easy problems
    ├── Medium/                  # Tests for medium problems
    └── Hard/                    # Tests for hard problems
```

## Running Tests

### Run all tests
```bash
dotnet test
```

### Run tests for a specific file
```bash
dotnet test --filter "FullyQualifiedName~TwoSumTests"
```

### Run tests for a specific difficulty level
```bash
# Easy problems
dotnet test --filter "FullyQualifiedName~LeetCode.Tests.Easy"

# Medium problems
dotnet test --filter "FullyQualifiedName~LeetCode.Tests.Medium"

# Hard problems
dotnet test --filter "FullyQualifiedName~LeetCode.Tests.Hard"
```

## Adding New Problems

1. **Create the problem class** in the appropriate difficulty folder under `LeetCode.Problems/`:
   ```bash
   # For example, for an easy problem called "ValidParentheses"
   # Create: LeetCode.Problems/Easy/ValidParentheses.cs
   ```

2. **Create the test class** in the corresponding folder under `LeetCode.Tests/`:
   ```bash
   # Create: LeetCode.Tests/Easy/ValidParenthesesTests.cs
   ```

3. **Follow the naming convention**:
   - Problem class: Use the actual LeetCode problem name (e.g., `TwoSum`, `ValidParentheses`)
   - Test class: Problem name + "Tests" suffix (e.g., `TwoSumTests`)

4. **Example problem structure**:
   ```csharp
   namespace LeetCode.Problems.Easy;

   public class ProblemName
   {
       public ReturnType Solution(ParameterType parameter)
       {
           // Your solution here
       }
   }
   ```

5. **Example test structure**:
   ```csharp
   using LeetCode.Problems.Easy;

   namespace LeetCode.Tests.Easy;

   public class ProblemNameTests
   {
       private readonly ProblemName _solution;

       public ProblemNameTests()
       {
           _solution = new ProblemName();
       }

       [Fact]
       public void TestCase1_Description()
       {
           // Arrange, Act, Assert
       }
   }
   ```

## Sample Problem

The repository includes a sample implementation of **Two Sum** (LeetCode #1) to demonstrate the structure.
- Solution: `LeetCode.Problems/Easy/TwoSum.cs`
- Tests: `LeetCode.Tests/Easy/TwoSumTests.cs`
