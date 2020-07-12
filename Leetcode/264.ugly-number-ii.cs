/*
 * @lc app=leetcode id=264 lang=csharp
 *
 * [264] Ugly Number II
 */

// @lc code=start
public class Solution {
    public int NthUglyNumber(int n) {
        int a = 0, b = 0, c = 0;
        List<int> list = new List<int>(n) { 1 };
        int next = 1;
        int aProduct = 2, bProduct = 3, cProduct = 5;
        for (int i = 1; i < n; i++)
        {
            next = Math.Min(aProduct, Math.Min(bProduct, cProduct));
            list.Add(next);
            if (next >= aProduct ) {
                a++;
                aProduct = list[a] * 2;
            }
            if (next >= bProduct) {
                b++;
                bProduct = list[b] * 3;
            }
            if (next >= cProduct) {
                c++;
                cProduct = list[c] * 5;
            }
        }
        return next;        
    }
}
// @lc code=end

