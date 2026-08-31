/*
 * @lc app=leetcode id=3518 lang=csharp
 *
 * [3518] Smallest Palindromic Rearrangement II
 */

// @lc code=start
public class Solution {
    public string SmallestPalindrome(string s, int k) {
        int half = s.Length >> 1;
        int[] counts = new int[26];
        for (int i = 0; i < half; i++)
        {
            counts[s[i] - 'a']++;
        }

        long C(int n, int m)
        {
            long rst = 1L;
            m = Math.Min(m, n - m);

            for (int i = 1; i <= m; i++)
            {
                rst = rst * (n - i + 1) / i;
                
                if (rst > k)
                {
                    return k + 1;
                }
            }
            return rst;
        }

        long Permutation(int len)
        {
            long rst = 1L;
            for (int i = 0; i < 26; i++)
            {
                if (counts[i] == 0)
                {
                    continue;
                }
                
                rst *= C(len, counts[i]);
                if (rst > k)
                {
                    break;
                }
                len -= counts[i];
            }
            return rst;
        }

        StringBuilder sb = new StringBuilder();
        long startIndex = 1;
        for (int i = 0; i < half; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (counts[j] == 0)
                {
                    continue;
                }
                counts[j]--;
                long p = Permutation(half - i - 1);
                if (startIndex + p > k)
                {
                    sb.Append((char)(j + 'a'));
                    break;
                }

                startIndex += p;
                counts[j]++;
            }
        }

        if (sb.Length < half)
        {
            return string.Empty;
        }

        if ((s.Length & 1) == 1)
        {
            sb.Append(s[half]);
        }

        for (int i = half - 1; i >= 0; i--)
        {
            sb.Append(sb[i]);
        } 

        return sb.ToString();
    }
}
// @lc code=end

