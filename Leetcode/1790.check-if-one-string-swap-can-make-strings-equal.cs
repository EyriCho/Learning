/*
 * @lc app=leetcode id=1790 lang=csharp
 *
 * [1790] Check if One String Swap Can Make Strings Equal
 */

// @lc code=start
public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int indic1 = -1,
            indic2 = -1;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (indic1 == -1)
                {
                    indic1 = i;
                }
                else if (indic2 == -1)
                {
                    indic2 = i;
                }
                else
                {
                    return false;
                }
            }
        }

        if (indic1 == -1)
        {
            return true;
        }
        else if (indic2 == -1)
        {
            return false;
        }

        return s1[indic1] == s2[indic2] && s1[indic2] == s2[indic1];
    }
}
// @lc code=end

