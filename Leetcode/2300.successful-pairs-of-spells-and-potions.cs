/*
 * @lc app=leetcode id=2300 lang=csharp
 *
 * [2300] Successful Pairs of Spells and Potions
 */

// @lc code=start
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);

        int[] result = new int[spells.Length];
        int l = 0, r = 0, m = 0;
        for (int i = 0; i < spells.Length; i++)
        {
            l = 0;
            r = potions.Length;
            while (l < r)
            {
                m = (l + r) >> 1;
                if ((long)spells[i] * potions[m] < success)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            result[i] = potions.Length - l;
        }

        return result;
    }
}
// @lc code=end

