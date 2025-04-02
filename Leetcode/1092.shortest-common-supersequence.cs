/*
 * @lc app=leetcode id=1092 lang=csharp
 *
 * [1092] Shortest Common Supersequence 
 */

// @lc code=start
public class Solution {
    public string ShortestCommonSupersequence(string str1, string str2) {
        int[,] dp = new int[str1.Length + 1, str2.Length + 1];

        int i = 0,
            i1 = 1,
            i2 = 1;

        for (; i1 <= str1.Length; i1++)
        {
            i2 = 1;
            for (; i2 <= str2.Length; i2++)
            {
                if (str1[i1 - 1] == str2[i2 - 1])
                {
                    dp[i1, i2] = dp[i1 - 1, i2 - 1] + 1;
                }
                else
                {
                    dp[i1, i2] = Math.Max(dp[i1 - 1, i2], dp[i1, i2 - 1]);
                }
            }
        }

        char[] array = new char[str1.Length + str2.Length - dp[str1.Length, str2.Length]];
        i1 = str1.Length;
        i2 = str2.Length;
        i = array.Length - 1;

        while (i1 > 0 && i2 > 0)
        {
            if (str1[i1 - 1] == str2[i2 - 1])
            {
                array[i--] = str1[--i1];
                i2--;
            }
            else if (dp[i1 - 1, i2] > dp[i1, i2 - 1])
            {
                array[i--] = str1[--i1];
            }
            else
            {
                array[i--] = str2[--i2];
            }
        }

        while (i1 > 0)
        {
            array[i--] = str1[--i1];
        }
        while (i2 > 0)
        {
            array[i--] = str2[--i2];
        }

        return new string(array);
    }
}
// @lc code=end

