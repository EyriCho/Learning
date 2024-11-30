/*
 * @lc app=leetcode id=1574 lang=csharp
 *
 * [1574] Shortest Subarray to be Removed to Make Array Sorted
 */

// @lc code=start
public class Solution {
    public int FindLengthOfShortestSubarray(int[] arr) {
        int left = 0,
            right = arr.Length - 1;
        while (left + 1 < arr.Length &&
            arr[left] <= arr[left + 1])
        {
            left++;
        }

        if (left == arr.Length - 1)
        {
            return 0;
        }

        while (arr[right] >= arr[right - 1])
        {
            right--;
        }
        
        int result = arr.Length - 1 - left,
            l = 0,
            r = right;
        
        while (r < arr.Length)
        {
            while (l <= left && arr[l] <= arr[r])
            {
                l++;
            }

            result = Math.Min(result, r - l);
            r++;
        }

        return result;
    }
}
// @lc code=end

