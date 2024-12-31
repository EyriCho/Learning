/*
 * @lc app=leetcode id=2825 lang=csharp
 *
 * [2825] Make String a Subsequence Using Cyclic Increments
 */

// @lc code=start
public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        int s1 = 0,
            s2 = 0;
        
        while (s2 < str2.Length)
        {
            while (s1 < str1.Length)
            {
                if (str1[s1] == str2[s2] ||
                    str1[s1] == (str2[s2] - 1) ||
                    (str1[s1] == 'z' && str2[s2] == 'a'))
                {
                    break;
                }
                s1++;
            }

            if (s1 == str1.Length)
            {
                return false;
            }

            s1++;
            s2++;
        }

        return true;
    }
}
// @lc code=end

