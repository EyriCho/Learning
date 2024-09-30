/*
 * @lc app=leetcode id=214 lang=csharp
 *
 * [214] Shortest Palindrome
 */

// @lc code=start
public class Solution {
    public string ShortestPalindrome(string s) {
        StringBuilder builder = new (s);
        builder.Append('#');
        int i = 0,
            j = 0;
        for (i = s.Length - 1; i >= 0; i--)
        {
            builder.Append(s[i]);
        }
        string str = builder.ToString();
        int[] common = new int[str.Length];
        i = 1;
        while (i < str.Length)
        {
            if (str[i] == str[j])
            {
                j++;
                common[i] = j;
                i++;
            }
            else
            {
                if (j > 0)
                {
                    j = common[j - 1];
                }
                else
                {
                    common[i] = 0;
                    i++;
                }
            }
        }

        return str.Substring(s.Length + 1, s.Length - common[str.Length - 1]) + s;
    }
}
// @lc code=end

