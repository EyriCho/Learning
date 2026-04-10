/*
 * @lc app=leetcode id=2840 lang=csharp
 *
 * [2840] Check if Strings Can be Made Equal With Operations II
 */

// @lc code=start
public class Solution {
    public bool CheckStrings(string s1, string s2) {
        int[] odd1 = new int[26],
            odd2 = new int[26],
            even1 = new int[26],
            even2 = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            if ((i & 1) == 0)
            {
                even1[s1[i] - 'a']++;
                even2[s2[i] - 'a']++;
            }
            else
            {
                odd1[s1[i] - 'a']++;
                odd2[s2[i] - 'a']++;
            }
        }

        for (int i = 0; i < odd1.Length; i++)
        {
            if (odd1[i] != odd2[i] ||
                even1[i] != even2[i])
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

