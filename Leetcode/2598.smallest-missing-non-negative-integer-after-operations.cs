/*
 * @lc app=leetcode id=2598 lang=csharp
 *
 * [2598] Smallest Missing Non-negative Integer After Operations
 */

// @lc code=start
public class Solution {
    public int FindSmallestInteger(int[] nums, int value) {
        int[] lefts = new int[value];
        int left = 0;
        foreach (int num in nums)
        {
            left = (num % value + value) % value;
            lefts[left]++;
        }

        int min = int.MaxValue,
            minLeft = 0;

        for (int i = 0; i < value; i++)
        {
            if (lefts[i] == 0)
            {
                return i;
            }

            if (lefts[i] < min)
            {
                min = lefts[i];
                minLeft = i;
            }
        }

        return min * value + minLeft;
    }
}
// @lc code=end

