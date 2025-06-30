/*
 * @lc app=leetcode id=2311 lang=csharp
 *
 * [2311] Longest Binary Subsequence Less Than or Equal to K
 */

// @lc code=start
public class Solution {
    public int LongestSubsequence(string s, int k) {
        int zeros = 0;
        for (int i = 0; i < s.Length; i++)
        {
            zeros += s[i] == '0' ? 1 : 0;
        }

        int ones = 0,
            pow = 1,
            val = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '1')
            {
                if (val + pow > k)
                {
                    continue;
                }

                val += pow;
                ones++;
            }
            pow <<= 1;
            if (pow > k)
            {
                break;
            }
        }

        return zeros + ones;
    }
}
// @lc code=end

