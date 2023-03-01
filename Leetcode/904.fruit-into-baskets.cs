/*
 * @lc app=leetcode id=904 lang=csharp
 *
 * [904] Fruit Into Baskets
 */

// @lc code=start
public class Solution {
    public int TotalFruit(int[] fruits) {
        int result = 1;
        int a = fruits[0], b = fruits[0],
            countB = 1,
            cur = 1;
        for (int i = 1; i < fruits.Length; i++)
        {
            cur = (fruits[i] == a || fruits[i] == b) ?
                cur + 1 :
                countB + 1;
            countB = fruits[i] == b ?
                countB + 1 :
                1;

            result = Math.Max(cur, result);
            if (b != fruits[i])
            {
                a = b;
                b = fruits[i];
            }
        }
        return result;
    }
}
// @lc code=end

