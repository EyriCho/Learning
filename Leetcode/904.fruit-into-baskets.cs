/*
 * @lc app=leetcode id=904 lang=csharp
 *
 * [904] Fruit Into Baskets
 */

// @lc code=start
public class Solution {
    public int TotalFruit(int[] fruits) {
        int result = 1,
            a = fruits[0],
            b = fruits[0],
            cur = 1,
            bCount = 1;
        
        for (int i = 1; i < fruits.Length; i++)
        {
            cur = (fruits[i] == a || fruits[i] == b) ? cur + 1 : bCount + 1;

            result = Math.Max(result, cur);
            if (fruits[i] != b)
            {
                a = b;
                b = fruits[i];
                bCount = 1;
            }
            else
            {
                bCount++;
            }
        }

        return result;
    }
}
// @lc code=end

