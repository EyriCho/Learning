/*
 * @lc app=leetcode id=1967 lang=csharp
 *
 * [1967] Number of Strings That Appear as Substrings in Word
 */

// @lc code=start
public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int[] BuildPrefix(string str)
        {
            int[] rst = new int[str.Length];
            for (int i = 1, j = 0; i < str.Length; i++)
            {
                while (j > 0 && str[i] != str[j])
                {
                    j = rst[j - 1];
                }

                if (str[i] == str[j])
                {
                    j++;
                }
                rst[i] = j;
            }
            return rst;
        }

        int[] kmp = null;
        bool flag = false;
        int result = 0;
        foreach (string p in patterns)
        {
            kmp = BuildPrefix(p);

            flag = false;
            for (int i = 0, j = 0; i < word.Length; i++)
            {
                while (j > 0 && word[i] != p[j])
                {
                    j = kmp[j - 1];
                }

                if (word[i] == p[j])
                {
                    j++;
                }

                if (j == p.Length)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

