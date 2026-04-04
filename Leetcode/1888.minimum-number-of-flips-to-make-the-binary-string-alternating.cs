/*
 * @lc app=leetcode id=1888 lang=csharp
 *
 * [1888] Minimum Number of Flips to Make the Binary String Alternating
 */

// @lc code=start
public class Solution {
    public int MinFlips(string s) {
        int result = s.Length;
        int[] ops = new int[2];

        for (int i = 0; i < s.Length; i++)
        {
            ops[((s[i] - '0') ^ i) & 1]++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            ops[((s[i] - '0') ^ i) & 1]--;
            ops[((s[i] - '0') ^ (s.Length + i)) & 1]++;
            result = Math.Min(result, Math.Min(ops[0], ops[1]));
        }

        return result;
    }
}
// @lc code=end

