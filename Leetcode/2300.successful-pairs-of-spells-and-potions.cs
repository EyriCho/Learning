/*
 * @lc app=leetcode id=2300 lang=csharp
 *
 * [2300] Successful Pairs of Spells and Potions
 */

// @lc code=start
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);

        var result = new int[spells.Length];
        for (int i = 0; i < spells.Length; i++)
        {
            int l = 0, r = potions.Length;

            while (l < r)
            {
                var m = (l + r) >> 1;
                var p = (long)spells[i] * potions[m];
                if (p >= success)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            result[i] = potions.Length - l;
        }

        return result;
    }
}
// @lc code=end

