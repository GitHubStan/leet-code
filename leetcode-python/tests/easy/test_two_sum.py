import pytest
from src.easy.two_sum import two_sum


class TestTwoSum:
    def test_example_1(self):
        """Test case: [2,7,11,15], target 9 returns [0,1]"""
        nums = [2, 7, 11, 15]
        target = 9
        expected = [0, 1]

        result = two_sum(nums, target)

        assert result == expected

    def test_example_2(self):
        """Test case: [3,2,4], target 6 returns [1,2]"""
        nums = [3, 2, 4]
        target = 6
        expected = [1, 2]

        result = two_sum(nums, target)

        assert result == expected

    def test_example_3(self):
        """Test case: [3,3], target 6 returns [0,1]"""
        nums = [3, 3]
        target = 6
        expected = [0, 1]

        result = two_sum(nums, target)

        assert result == expected

    def test_negative_numbers(self):
        """Test case with negative numbers"""
        nums = [-1, -2, -3, -4, -5]
        target = -8
        expected = [2, 4]

        result = two_sum(nums, target)

        assert result == expected

    def test_no_solution(self):
        """Test case where no solution exists"""
        nums = [1, 2, 3]
        target = 10

        with pytest.raises(ValueError, match="No solution found"):
            two_sum(nums, target)
