/*
 * @lc app=leetcode id=880 lang=csharp
 *
 * [880] Decoded String at Index
 */

// @lc code=start
public class Solution {
    public string DecodeAtIndex(string S, int K) {
        long length = 0L,
            k1 = k;

        int i = 0;
        for (; i < s.Length && length < k; i++)
        {
            if (s[i] < 'a')
            {
                length *= s[i] - '0';
            }
            else
            {
                length++;
            }
        }

        for (--i; i >= 0; i--)
        {
            k1 %= length;
            if (k1 == 0 && s[i] > '9')
            {
                return s[i..(i + 1)];
            }

            if (s[i] > '9')
            {
                length--;
            }
            else
            {
                length /= s[i] - '0';
            }
        }
        
        return string.Empty;
    }
}
// @lc code=end

