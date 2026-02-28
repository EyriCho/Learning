/*
 * @lc app=leetcode id=3713 lang=csharp
 *
 * [3713] Longest Balanced Substring I
 */

// @lc code=start
public class Solution {
    public int LongestBalanced(string s) {
        int[] counts = new int[26];
        int result = 0;

        bool IsValid()
        {
            int max = 0;
            foreach (int c in counts)
            {
                if (c == 0)
                {
                    continue;
                }

                if (max == 0)
                {
                    max = c;
                }
                else if (max != c)
                {
                    return false;
                }
            }

            return true;
        }

        for (int l = 0; l < s.Length; l++)
        {
            Array.Fill(counts, 0);
            for (int r = l; r < s.Length; r++)
            {
                counts[s[r] - 'a']++;

                if (IsValid())
                {
                    result = Math.Max(result, r - l + 1);
                }
            }
        }

        return result;
    }
}
// @lc code=end

