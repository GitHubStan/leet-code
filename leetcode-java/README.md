# LeetCode Java Solutions

Java implementations of LeetCode problems using plain Java with JUnit 5 for testing.

## Project Structure

```
leetcode-java/
├── src/
│   ├── main/java/com/leetcode/
│   │   ├── easy/          # Easy difficulty problems
│   │   ├── medium/        # Medium difficulty problems
│   │   └── hard/          # Hard difficulty problems
│   └── test/java/com/leetcode/
│       ├── easy/          # Tests for easy problems
│       ├── medium/        # Tests for medium problems
│       └── hard/          # Tests for hard problems
├── pom.xml                # Maven configuration
└── README.md
```

## Requirements

- Java 17 or higher
- Maven 3.6 or higher

## Setup

1. Ensure Java and Maven are installed:
   ```bash
   java -version
   mvn -version
   ```

2. Install dependencies:
   ```bash
   cd leetcode-java
   mvn clean install
   ```

## Running Tests

Run all tests:
```bash
mvn test
```

Run tests for a specific difficulty:
```bash
mvn test -Dtest="com.leetcode.easy.*Test"
mvn test -Dtest="com.leetcode.medium.*Test"
mvn test -Dtest="com.leetcode.hard.*Test"
```

Run a specific test class:
```bash
mvn test -Dtest=TwoSumTest
```

## Adding New Problems

1. Create a new class in the appropriate difficulty package:
   - `src/main/java/com/leetcode/easy/ProblemName.java`
   - `src/main/java/com/leetcode/medium/ProblemName.java`
   - `src/main/java/com/leetcode/hard/ProblemName.java`

2. Create corresponding test class:
   - `src/test/java/com/leetcode/easy/ProblemNameTest.java`

3. Follow the naming convention: Use PascalCase for class names based on the problem title.

## Example Solutions

- [TwoSum.java](src/main/java/com/leetcode/easy/TwoSum.java) - Problem #1: Two Sum

## Tech Stack

- **Java 17** - Programming language
- **JUnit 5** - Testing framework
- **Maven** - Build and dependency management
