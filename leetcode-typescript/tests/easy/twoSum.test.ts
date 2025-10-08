import { twoSum } from '../../src/easy/twoSum';

describe('Two Sum', () => {
    test('Example 1: [2,7,11,15], target 9 returns [0,1]', () => {
        const nums = [2, 7, 11, 15];
        const target = 9;
        const expected = [0, 1];

        const result = twoSum(nums, target);

        expect(result).toEqual(expected);
    });

    test('Example 2: [3,2,4], target 6 returns [1,2]', () => {
        const nums = [3, 2, 4];
        const target = 6;
        const expected = [1, 2];

        const result = twoSum(nums, target);

        expect(result).toEqual(expected);
    });

    test('Example 3: [3,3], target 6 returns [0,1]', () => {
        const nums = [3, 3];
        const target = 6;
        const expected = [0, 1];

        const result = twoSum(nums, target);

        expect(result).toEqual(expected);
    });
});
