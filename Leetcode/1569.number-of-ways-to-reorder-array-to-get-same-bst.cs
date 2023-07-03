/*
 * @lc app=leetcode id=1569 lang=csharp
 *
 * [1569] Number of Ways to Reorder Array to Get Same BST
 */

// @lc code=start
public class Solution {
    public int NumOfWays(int[] nums) {
        const int mod = 1_000_000_007;
        var ways = new int[nums.Length + 1, nums.Length + 1];

        for (int j = 0; j < nums.Length; j++)
        {
            ways[0, j] = 1;
        }
        for (int i = 1; i < nums.Length; i++)
        {
            ways[i, 0] = 1;
            for (int j = 1; j < i; j++)
            {
                ways[i, j] = (ways[i - 1, j] + ways[i - 1, j - 1]) % mod;
            }
            ways[i, i] = 1;
        }

        long Dfs(IList<int> list)
        {
            if (list.Count < 3)
            {
                return 1;
            }

            List<int> left = new List<int>(),
                right = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[0])
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            long l = Dfs(left),
                r = Dfs(right);

            return (ways[list.Count - 1, left.Count] * l % mod) * r % mod;
        }

        return (int)(Dfs(nums) - 1);
    }
}
// @lc code=end

