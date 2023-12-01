/*
 * @lc app=leetcode id=1814 lang=csharp
 *
 * [1814] Count Nice Pairs in an Array
 */

// @lc code=start
public class Solution {
    public int CountNicePairs(int[] nums) {
        int Reverse(int num)
        {
            int rst = 0;
            while (num > 0)
            {
                rst = rst * 10 + num % 10;
                num /= 10;
            }
            return rst;
        }

        int result = 0;
        Dictionary<int, int> dict = new ();

        foreach (int num in nums)
        {
            int r = Reverse(num);
            int diff = num - r;

            if (!dict.TryGetValue(diff, out int c))
            {
                dict[diff] = c = 0;
            }

            result = (result + c) % 1_000_000_007;
            dict[diff] = c + 1;
        }

        return result;
    }
}
// @lc code=end

