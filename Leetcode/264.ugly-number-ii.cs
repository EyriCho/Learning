/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 */

// @lc code=start
public class Solution {
    public int NthUglyNumber(int n) {
        int next = 1,
            two = 0,
            three = 0,
            five = 0,
            twoProduct = 2,
            threeProduct = 3,
            fiveProduct = 5;

        List<int> list = new List<int>(n) { 1 };
        for (int i = 1; i < n; i++)
        {
            next = Math.Min(twoProduct, Math.Min(threeProduct, fiveProduct));
            list.Add(next);
            if (twoProduct <= next)
            {
                two++;
                twoProduct = list[two] * 2;
            }
            if (threeProduct <= next)
            {
                three++;
                threeProduct = list[three] * 3;
            }
            if (fiveProduct <= next)
            {
                five++;
                fiveProduct = list[five] * 5;
            }
        }

        return next;
    }
}
// @lc code=end

