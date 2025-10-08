# LeetCode JavaScript Practice

A structured Node.js project for practicing LeetCode problems with Jest tests.

## Folder Structure

```
leetcode-javascript/
├── package.json
├── src/                    # Problem solutions
│   ├── easy/              # Easy difficulty problems
│   ├── medium/            # Medium difficulty problems
│   └── hard/              # Hard difficulty problems
└── tests/                 # Jest tests
    ├── easy/              # Tests for easy problems
    ├── medium/            # Tests for medium problems
    └── hard/              # Tests for hard problems
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
npm test twoSum
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

1. **Create the solution file** in the appropriate difficulty folder under `src/`:
   ```bash
   # For example, for an easy problem called "validParentheses"
   # Create: src/easy/validParentheses.js
   ```

2. **Create the test file** in the corresponding folder under `tests/`:
   ```bash
   # Create: tests/easy/validParentheses.test.js
   ```

3. **Follow the naming convention**:
   - Solution file: Use camelCase for the problem name (e.g., `twoSum.js`, `validParentheses.js`)
   - Test file: Same name with `.test.js` suffix (e.g., `twoSum.test.js`)

4. **Example solution structure**:
   ```javascript
   /**
    * Problem description
    * @param {Type} parameter
    * @return {Type}
    */
   function problemName(parameter) {
       // Your solution here
   }

   module.exports = problemName;
   ```

5. **Example test structure**:
   ```javascript
   const problemName = require('../../src/easy/problemName');

   describe('Problem Name', () => {
       test('description of test case', () => {
           const input = /* ... */;
           const expected = /* ... */;

           const result = problemName(input);

           expect(result).toEqual(expected);
       });
   });
   ```

## Sample Problem

The repository includes a sample implementation of **Two Sum** (LeetCode #1) to demonstrate the structure.
- Solution: `src/easy/twoSum.js`
- Tests: `tests/easy/twoSum.test.js`
