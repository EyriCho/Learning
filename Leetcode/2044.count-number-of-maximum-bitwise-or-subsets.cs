/*
 * @lc app=leetcode id=2044 lang=csharp
 *
 * [2044] Count Number of Maximum Bitwise-OR Subsets
 */

// @lc code=start
public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        int max = 0,
            result = 0;
        foreach (int num in nums)
        {
            max |= num;
        }

        void Dfs(int index, int current)
        {
            if (current == max)
            {
                result += 1 << (nums.Length - index);
                return;
            }
            else if (index == nums.Length)
            {
                return;
            }

            Dfs(index + 1, current | nums[index]);
            Dfs(index + 1, current);
        }

        Dfs(0, 0);
        return result;
    }
}
// @lc code=end

