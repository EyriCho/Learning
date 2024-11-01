/*
 * @lc app=leetcode id=2501 lang=csharp
 *
 * [2501] Longest Square Streak in an Array
 */

// @lc code=start
public class Solution {
    public int LongestSquareStreak(int[] nums) {
        HashSet<int> set= new (nums);

        int count = 0,
            current = 0,
            max = 0;
        Array.Sort(nums);
        foreach (int num in nums)
        {
            current = num;
            count = 0;
            while (set.Contains(current))
            {
                set.Remove(current);
                count++;
                current = current * current;
            }
            max = Math.Max(max, count);
        }

        return max < 2 ? -1 : max;
    }
}
// @lc code=end

