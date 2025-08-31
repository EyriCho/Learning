/*
 * @lc app=leetcode id=3477 lang=csharp
 *
 * [3477] Fruits Into Baskets II
 */

// @lc code=start
public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int result = fruits.Length;

        foreach (int fruit in fruits)
        {
            for (int i = 0; i < baskets.Length; i++)
            {
                if (baskets[i] >= fruit)
                {
                    baskets[i] = 0;
                    result--;
                    break;
                }

            }
        }

        return result;
    }
}
// @lc code=end

