/*
 * @lc app=leetcode id=1957 lang=csharp
 *
 * [1957] Delete Characters to Make Fancy String
 */

// @lc code=start
public class Solution {
    public string MakeFancyString(string s) {
        char[] array = new char[s.Length];
        int k = 0,
            count = 1;
        
        array[k++] = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                if (++count > 2)
                {
                    continue;
                }
            }
            else
            {
                count = 1;
            }

            array[k++] = s[i];
        }

        return new string(array, 0, k);
    }
}
// @lc code=end

