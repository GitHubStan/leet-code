# LeetCode JavaScript Practice

A structured Node.js project for practicing LeetCode problems with Vitest tests.

## Folder Structure

```
leetcode-javascript/
├── package.json
├── vitest.config.js
├── src/                     # Problem solutions
│   ├── easy/                # Easy difficulty problems
│   ├── medium/              # Medium difficulty problems
│   └── hard/                # Hard difficulty problems
└── tests/                   # Vitest tests
    ├── easy/                # Tests for easy problems
    ├── medium/              # Tests for medium problems
    └── hard/                # Tests for hard problems
```

## Setup

Install dependencies:
```bash
npm install
```

## Running Tests

### Run all tests
```bash
npm test
```

### Run tests for a specific file
```bash
npm test -- TwoSumTests
```

### Run tests for a specific difficulty level
```bash
# Easy problems
npm test -- tests/easy

# Medium problems
npm test -- tests/medium

# Hard problems
npm test -- tests/hard
```

### Run tests in watch mode
```bash
npm run test:watch
```

### Run tests with coverage
```bash
npm run test:coverage
```

## Adding New Problems

1. **Create the problem class** in the appropriate difficulty folder under `src/`:
   ```bash
   # For example, for an easy problem called "ValidParentheses"
   # Create: src/easy/ValidParentheses.js
   ```

2. **Create the test file** in the corresponding folder under `tests/`:
   ```bash
   # Create: tests/easy/ValidParenthesesTests.test.js
   ```

3. **Follow the naming convention**:
   - Problem class: Use the actual LeetCode problem name (e.g., `TwoSum`, `ValidParentheses`)
   - Test file: Problem name + `Tests` suffix (e.g., `TwoSumTests.test.js`)

4. **Example problem structure**:
   ```javascript
   class ProblemName {
     /**
      * @param {Type} parameter
      * @return {Type}
      */
     solution(parameter) {
       // Your solution here
     }
   }

   module.exports = ProblemName;
   ```

5. **Example test structure**:
   ```javascript
   const ProblemName = require('../../src/easy/ProblemName');

   describe('ProblemNameTests', () => {
     const solution = new ProblemName();

     test('TestCase1_Description', () => {
       // Arrange
       const input = /* ... */;
       const expected = /* ... */;

       // Act
       const result = solution.solution(input);

       // Assert
       expect(result).toEqual(expected);
     });
   });
   ```

## Sample Problem

The repository includes a sample implementation of **Two Sum** (LeetCode #1) to demonstrate the structure.
- Solution: `src/easy/TwoSum.js`
- Tests: `tests/easy/TwoSumTests.test.js`
