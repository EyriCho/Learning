/*
 * @lc app=leetcode id=3445 lang=csharp
 *
 * [3445] Maximum Difference Between Even and Odd Frequency II
 */

// @lc code=start
public class Solution {
    public int MaxDifference(string s, int k) {
        int GetMask(int a, int b)
        {
            return ((a & 1) << 1) | (b & 1);
        }

        int prevA = 0, prevB = 0,
            countA = 0, countB = 0,
            maskPrev = 0,
            requiredMask = 0,
            l = 0, r = 0,
            result = int.MinValue;
            
        int[] best = new int[4];
        for (char a = '0'; a < '5'; a++)
        {
            for (char b = '0'; b < '5'; b++)
            {
                if (a == b)
                {
                    continue;
                }

                Array.Fill(best, s.Length);
                prevA = prevB = countA = countB = r = 0;
                l = -1;

                while (r < s.Length)
                {
                    countA += s[r] == a ? 1 : 0;
                    countB += s[r] == b ? 1 : 0;


                    while (r - l >= k && countB - prevB >= 2)
                    {
                        maskPrev = GetMask(prevA, prevB);

                        best[maskPrev] = Math.Min(best[maskPrev], prevA - prevB);
                        l++;
                        prevA += s[l] == a ? 1 : 0;
                        prevB += s[l] == b ? 1 : 0;
                    }

                    requiredMask = GetMask(countA, countB) ^ 2;

                    if (best[requiredMask] != s.Length)
                    {
                        result = Math.Max(result,
                            countA - countB - best[requiredMask]);
                    }
                    r++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

