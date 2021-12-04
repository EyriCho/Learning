/*
 * @lc app=leetcode id=668 lang=csharp
 *
 * [668] Kth Smallest Number in Multiplication Table
 */

// @lc code=start
public class Solution {
    public int FindKthNumber(int m, int n, int k) {
        int l = 1, r = m * n;
        while (l < r)
        {
            int mid = l + (r - l) / 2,
                count = 0,
                x = m,
                y = 1;
            while (x >= 1 && y <= n)
            {
                if (x * y <= mid)
                {
                    count += x;
                    y++;
                }
                else
                    x--;
            }
            
            if (count < k)
                l = mid + 1;
            else
                r = mid;
        }
        
        return r;
    }
}
// @lc code=end

