/*
 * @lc app=leetcode id=1460 lang=csharp
 *
 * [1460] Make Two Arrays Equal by Reversing Subarrays
 */

// @lc code=start
public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        int[] counts = new int[1_001];
        for (int i = 0; i < target.Length; i++)
        {
            counts[target[i]]++;
            counts[arr[i]]--;
        }
        for (int i = 1; i < 1_001; i++)
        {
            if (counts[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

