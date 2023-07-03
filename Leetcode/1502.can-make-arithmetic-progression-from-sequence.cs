/*
 * @lc app=leetcode id=1502 lang=csharp
 *
 * [1502] Can Make Arithmetic Progression From Sequence
 */

// @lc code=start
public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        var diff = arr[1] - arr[0];

        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != diff)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

