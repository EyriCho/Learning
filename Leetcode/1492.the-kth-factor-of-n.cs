/*
 * @lc app=leetcode id=1492 lang=csharp
 *
 * [1492] The kth Factor of n
 */

// @lc code=start
public class Solution {
    public int KthFactor(int n, int k) {
        int i = 1, c = 0;
        int loop = n / 2;
        for (; i <= loop; i++)
        {
            if (n % i == 0)
            {
                if (++c == k)
                    return i;
            }
        }
        
        if (c + 1 == k)
            return n;
        return -1;
    }
}
// @lc code=end

