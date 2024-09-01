/*
 * @lc app=leetcode id=564 lang=csharp
 *
 * [564] Find the Closest Palindrome
 */

// @lc code=start
public class Solution {
    public string NearestPalindromic(string n) {
        long origin = long.Parse(n),
            pre = long.Parse(n[0..((n.Length + 1) >> 1)]);

        long CreatePalindrome(string prefix, int len)
        {
            char[] suffix = prefix.ToCharArray();
            Array.Reverse(suffix);
            return long.Parse(prefix + (new string(suffix)).Substring(len % 2));
        }
        long[] candidates = new long[5];

        for (int i = -1; i <= 1; i++)
        {
            candidates[i + 1] = CreatePalindrome((pre + i).ToString(), n.Length);
        }
        
        candidates[3] = (long)Math.Pow(10L, n.Length) + 1;
        candidates[4] = (long)Math.Pow(10L, n.Length - 1) - 1;

        long minDiff = long.MaxValue,
            diff = 0L,
            result = 0L;
        foreach (long can in candidates)
        {
            if (can == origin)
            {
                continue;
            }

            diff = Math.Abs(can - origin);
            if (diff < minDiff)
            {
                minDiff = diff;
                result = can;
            }
            else if (diff == minDiff)
            {
                result = Math.Min(result, can);
            }
        }

        return result.ToString();
    }
}
// @lc code=end

