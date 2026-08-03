const rotate = require('../../src/medium/RotateArray');

describe('RotateArray', () => {
  test('Example1_RotatesRightByThree', () => {
    // Arrange
    const nums = [1, 2, 3, 4, 5, 6, 7];
    const k = 3;
    const expected = [5, 6, 7, 1, 2, 3, 4];

    // Act
    rotate(nums, k);

    // Assert
    expect(nums).toEqual(expected);
  });

  test('Example2_RotatesRightByTwo', () => {
    // Arrange
    const nums = [-1, -100, 3, 99];
    const k = 2;
    const expected = [3, 99, -1, -100];

    // Act
    rotate(nums, k);

    // Assert
    expect(nums).toEqual(expected);
  });

  test('KEqualsZero_LeavesArrayUnchanged', () => {
    // Arrange
    const nums = [1, 2, 3];
    const k = 0;
    const expected = [1, 2, 3];

    // Act
    rotate(nums, k);

    // Assert
    expect(nums).toEqual(expected);
  });

  test('KGreaterThanLength_UsesModulo', () => {
    // Arrange
    const nums = [1, 2, 3];
    const k = 4;
    const expected = [3, 1, 2];

    // Act
    rotate(nums, k);

    // Assert
    expect(nums).toEqual(expected);
  });

  test('SingleElement_LeavesArrayUnchanged', () => {
    // Arrange
    const nums = [1];
    const k = 1;
    const expected = [1];

    // Act
    rotate(nums, k);

    // Assert
    expect(nums).toEqual(expected);
  });
});
