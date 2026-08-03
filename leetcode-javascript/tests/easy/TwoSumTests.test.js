const TwoSum = require('../../src/easy/TwoSum');

describe('TwoSumTests', () => {
  const solution = new TwoSum();

  test('Example1_ReturnsCorrectIndices', () => {
    // Arrange
    const nums = [2, 7, 11, 15];
    const target = 9;
    const expected = [0, 1];

    // Act
    const result = solution.solution(nums, target);

    // Assert
    expect(result).toEqual(expected);
  });

  test('Example2_ReturnsCorrectIndices', () => {
    // Arrange
    const nums = [3, 2, 4];
    const target = 6;
    const expected = [1, 2];

    // Act
    const result = solution.solution(nums, target);

    // Assert
    expect(result).toEqual(expected);
  });

  test('Example3_ReturnsCorrectIndices', () => {
    // Arrange
    const nums = [3, 3];
    const target = 6;
    const expected = [0, 1];

    // Act
    const result = solution.solution(nums, target);

    // Assert
    expect(result).toEqual(expected);
  });
});
