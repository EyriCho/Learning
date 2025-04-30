/*
 * @lc app=leetcode id=2999 lang=csharp
 *
 * [2999] Count the Number of Powerful Integers
 */

// @lc code=start
public class Solution {
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s) {
        
        long Count(string max)
        {
            if (max.Length < s.Length)
            {
                return 0L;
            }

            if (max.Length == s.Length)
            {
                return string.Compare(max, s) >= 0 ? 1L : 0L;
            }

            int l = max.Length - s.Length,
                d = 0;

            long count = 0L;
            for (int i = 0; i < l; i++)
            {
                d = max[i] - '0';
                if (d > limit)
                {
                    count += (long)Math.Pow(limit + 1, l - i);
                    return count;
                }

                count += (long)d * (long)Math.Pow(limit + 1, l - i - 1);
            }

            string suffix = max.Substring(l);
            if (string.Compare(suffix, s) >= 0)
            {
                count++;
            }

            return count;
        }

        return Count(finish.ToString()) - Count((start - 1).ToString());
    }
}
// @lc code=end

