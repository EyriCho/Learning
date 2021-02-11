/*
 * @lc app=leetcode id=821 lang=csharp
 *
 * [821] Shortest Distance to a Character
 */

// @lc code=start
public class Solution {
    public int[] ShortestToChar(string s, char c) {
        var result = new int[s.Length];
        int i = 0;
        
        i = 0;
        while (s[i] != c)
            i++;
        for (int j = i - 1; j >= 0; j--)
            result[j] = i - j;
        
        var last = i++;
        for (; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                for (int j = i - 1; j > last; j--)
                {
                    if (i - j < result[j])
                        result[j] = i - j;
                    else
                        break;
                }
                last = i;
            }
            else
            {
                result[i] = i - last;
            }
        }
        
        return result;
    }
}
// @lc code=end

