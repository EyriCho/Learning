/*
 * @lc app=leetcode id=3494 lang=csharp
 *
 * [3494] Find the Minimum Amount of Time to Brew Potions
 */

// @lc code=start
public class Solution {
    public long MinTime(int[] skill, int[] mana) {
        long[] finish = new long[skill.Length];
        long total = 0L;

        for (int m = 0; m < mana.Length; m++)
        {
            total = finish[0];
            for (int s = 0; s < skill.Length - 1; s++)
            {
                total = Math.Max(total + (long)skill[s] * mana[m], finish[s + 1]);
            }

            total += (long)skill[^1] * mana[m];
            finish[^1] = total;

            for (int s = skill.Length - 2; s >= 0; s--)
            {
                finish[s] = finish[s + 1] - (long)skill[s + 1] * mana[m];
            }
        }

        return finish[^1];
    }
}
// @lc code=end

