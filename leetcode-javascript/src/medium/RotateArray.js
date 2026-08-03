/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function(nums, k) {
   k = k % nums.length;

    reverseArray(nums, 0, nums.length - 1);
    reverseArray(nums, 0, k-1);
    reverseArray(nums, k, nums.length -1);

}

function reverseArray(arr, start, end){
    while (start < end) {
        const temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        start++;
        end--;
    }
}

module.exports = rotate;
