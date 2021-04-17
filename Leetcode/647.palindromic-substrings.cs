/*
 * @lc app=leetcode id=647 lang=csharp
 *
 * [647] Palindromic Substrings
 */

// @lc code=start
public class Solution {
    public int CountSubstrings(string s) {
        var check = new bool[s.Length, s.Length];
        
        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (i == j)
                {
                    check[i, j] = true;
                    result++;
                }
                else if (s[i] == s[j])
                {
                    if (j + 1 >= i - 1 || check[j + 1, i - 1])
                    {
                        check[j, i] = true;
                        result++;
                    }
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

