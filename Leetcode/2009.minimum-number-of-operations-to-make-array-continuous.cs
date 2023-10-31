/*
 * @lc app=leetcode id=2009 lang=csharp
 *
 * [2009] Minimum Number of Operations to Make Array Continuous
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        var set = new SortedSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
        }
        var distinctArray = set.ToArray();
        
        int result = 100_000;
        int left = 0, curr = 0;
        while (curr < distinctArray.Length)
        {
            while (left < curr &&
                distinctArray[curr] - distinctArray[left] >= nums.Length)
            {
                left++;
            }

            result = Math.Min(result, nums.Length - curr + left - 1);
            curr++;
        }
        return result;
    }
}
// @lc code=end

