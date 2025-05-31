/*
 * @lc app=leetcode id=3335 lang=csharp
 *
 * [3335] Total Characters in String After Transformations I
 */

// @lc code=start
public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        int[] cs = new int[26];
        foreach (char c in s)
        {
            cs[c - 'a']++;
        }

        int z = 0;
        for (int i = 0; i < t; i++)
        {
            z = cs[25];
            for (int k = 24; k >= 0; k--)
            {
                cs[k + 1] = cs[k];
            }
            cs[0] = z;
            cs[1] = (cs[1] + z) % 1_000_000_007;
        }

        int result = 0;
        for (int i = 0; i < cs.Length; i++)
        {
            result = (result + cs[i]) % 1_000_000_007;
        }
        return result;
    }
}
// @lc code=end

