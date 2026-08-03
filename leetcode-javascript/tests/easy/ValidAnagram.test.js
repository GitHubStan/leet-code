const isAnagram = require('../../src/easy/ValidAnagram');

describe('ValidAnagram', () => {
  test('Example1_ReturnsTrueForAnagrams', () => {
    // Arrange
    const s = 'anagram';
    const t = 'nagaram';

    // Act
    const result = isAnagram(s, t);

    // Assert
    expect(result).toBe(true);
  });

  test('Example2_ReturnsFalseForNonAnagrams', () => {
    // Arrange
    const s = 'rat';
    const t = 'car';

    // Act
    const result = isAnagram(s, t);

    // Assert
    expect(result).toBe(false);
  });

  test('DifferentLengths_ReturnsFalse', () => {
    // Arrange
    const s = 'a';
    const t = 'ab';

    // Act
    const result = isAnagram(s, t);

    // Assert
    expect(result).toBe(false);
  });

  test('EmptyStrings_ReturnsTrue', () => {
    // Arrange
    const s = '';
    const t = '';

    // Act
    const result = isAnagram(s, t);

    // Assert
    expect(result).toBe(true);
  });

  test('SameCharactersDifferentCounts_ReturnsFalse', () => {
    // Arrange
    const s = 'aacc';
    const t = 'ccac';

    // Act
    const result = isAnagram(s, t);

    // Assert
    expect(result).toBe(false);
  });
});
