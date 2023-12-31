/*
 * @lc app=leetcode id=1287 lang=csharp
 *
 * [1287] Element Appearing More Than 25% In Sorted Array
 */

// @lc code=start
public class Solution {
    public int FindSpecialInteger(int[] arr) {
        int max = arr.Length / 4,
            top = arr.Length - 1 - max;

        for (int i = 0; i < top; i++)
        {
            if (arr[i] == arr[i + max])
            {
                return arr[i];
            }
            if (arr[top - i] == arr[top + max])
            {
                return arr[top + max];
            }
        }

        return arr[arr.Length - 1];
    }
}
// @lc code=end

