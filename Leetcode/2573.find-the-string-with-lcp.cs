/*
 * @lc app=leetcode id=2573 lang=csharp
 *
 * [2573] Find the String with LCP
 */

// @lc code=start
public class Solution {
    public string FindTheString(int[][] lcp) {
        char[] word = new char[lcp.Length];
        char current = 'a';

        for (int i = 0; i < lcp.Length; i++)
        {
            if (word[i] < 'a')
            {
                if (current > 'z')
                {
                    return string.Empty;
                }
                word[i] = current;

                for (int j = i + 1; j < lcp.Length; j++)
                {
                    if (lcp[i][j] > 0)
                    {
                        word[j] = word[i];
                    }
                }
                current++;
            }
        }

        for (int i = lcp.Length - 1; i >= 0; i--)
        {
            for (int j = lcp.Length - 1; j >= 0; j--)
            {
                if (word[i] != word[j])
                {
                    if (lcp[i][j] != 0)
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    if (i == lcp.Length - 1 ||
                        j == lcp.Length - 1)
                    {
                        if (lcp[i][j] != 1)
                        {
                            return string.Empty;
                        }
                    }
                    else
                    {
                        if (lcp[i][j] != lcp[i + 1][j + 1] + 1)
                        {
                            return string.Empty;
                        }
                    }
                }
            }
        }

        return new string(word);
    }
}
// @lc code=end

