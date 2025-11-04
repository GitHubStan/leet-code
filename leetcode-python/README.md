# LeetCode Python Practice

A structured Python project for practicing LeetCode problems with pytest.

## Folder Structure

```
leetcode-python/
├── requirements.txt        # Python dependencies
├── pytest.ini             # Pytest configuration
├── src/                   # Problem solutions
│   ├── easy/             # Easy difficulty problems
│   ├── medium/           # Medium difficulty problems
│   └── hard/             # Hard difficulty problems
└── tests/                # Pytest tests
    ├── easy/             # Tests for easy problems
    ├── medium/           # Tests for medium problems
    └── hard/             # Tests for hard problems
```

## Setup

### Prerequisites
- Python 3.8 or higher
- pip (Python package installer)

### Install Dependencies

```bash
# Create a virtual environment (recommended)
python -m venv venv

# Activate the virtual environment
# On Windows:
venv\Scripts\activate
# On macOS/Linux:
source venv/bin/activate

# Install dependencies
pip install -r requirements.txt
```

## Running Tests

### Run all tests
```bash
pytest
```

### Run tests with verbose output
```bash
pytest -v
```

### Run tests for a specific file
```bash
pytest tests/easy/test_two_sum.py
```

### Run tests for a specific difficulty level
```bash
# Easy problems
pytest tests/easy/

# Medium problems
pytest tests/medium/

# Hard problems
pytest tests/hard/
```

### Run tests in watch mode (re-run on file changes)
```bash
pytest-watch
```

### Run tests with coverage
```bash
pytest --cov=src --cov-report=html
```

### Run a specific test by name
```bash
pytest -k "test_example_1"
```

## Adding New Problems

1. **Create the solution file** in the appropriate difficulty folder under `src/`:
   ```bash
   # For example, for an easy problem called "valid_parentheses"
   # Create: src/easy/valid_parentheses.py
   ```

2. **Create the test file** in the corresponding folder under `tests/`:
   ```bash
   # Create: tests/easy/test_valid_parentheses.py
   ```

3. **Follow the naming convention**:
   - Solution file: Use snake_case for the problem name (e.g., `two_sum.py`, `valid_parentheses.py`)
   - Test file: Same name with `test_` prefix (e.g., `test_two_sum.py`)

4. **Example solution structure**:
   ```python
   """
   LeetCode Problem #X: Problem Name
   Problem description here
   """

   from typing import List

   def problem_name(parameter: Type) -> ReturnType:
       """
       Approach: Brief description
       - Explanation of the approach
       Time Complexity: O(?)
       Space Complexity: O(?)

       Args:
           parameter: Description

       Returns:
           Description of return value
       """
       # Your solution here
       pass
   ```

5. **Example test structure**:
   ```python
   import pytest
   from src.easy.problem_name import problem_name

   class TestProblemName:
       def test_example_1(self):
           """Description of test case"""
           input_data = # ...
           expected = # ...

           result = problem_name(input_data)

           assert result == expected

       def test_example_2(self):
           """Description of test case"""
           input_data = # ...
           expected = # ...

           result = problem_name(input_data)

           assert result == expected
   ```

## Sample Problem

The repository includes a sample implementation of **Two Sum** (LeetCode #1) to demonstrate the structure.
- Solution: [src/easy/two_sum.py](src/easy/two_sum.py)
- Tests: [tests/easy/test_two_sum.py](tests/easy/test_two_sum.py)

## Tips

- Use type hints for better code clarity and IDE support
- Write descriptive test names that explain what is being tested
- Include docstrings to explain your approach and complexity
- Run tests frequently to catch issues early
- Use `pytest -v` for more detailed test output
- Consider using `pytest.mark.parametrize` for testing multiple cases efficiently
