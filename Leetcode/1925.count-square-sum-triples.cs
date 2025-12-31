/*
 * @lc app=leetcode id=1925 lang=csharp
 *
 * [1925] Count Square Sum Triples
 */

// @lc code=start
public class Solution {
    public int CountTriples(int n) {
        int result = 0,
            c = 0,
            csquare = 0;
        for (int a = 1; a < n - 1; a++)
        {
            for (int b = a + 1; b < n; b++)
            {
                csquare = a * a + b * b;
                c = (int)Math.Sqrt(csquare);
                if (c <= n && c * c == csquare)
                {
                    result += 2;
                }
            }
        }

        return result;
    }
}
// @lc code=end

