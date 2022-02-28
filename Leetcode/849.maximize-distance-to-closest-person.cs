/*
 * @lc app=leetcode id=849 lang=csharp
 *
 * [849] Maximize Distance to Closest Person
 */

// @lc code=start
public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int l = 0, r = seats.Length - 1;
        
        while (seats[l] == 0)
            l++;
        
        while (seats[r] == 0)
            r--;
        
        int result = Math.Max(l, seats.Length - 1 - r);
        
        int maxDistance = 0;
        for (int i = l; i <= r; i++)
        {
            if (seats[i] == 1)
            {
                maxDistance = Math.Max(maxDistance, i - l);
                l = i;
            }
        }
        
        return Math.Max(maxDistance / 2, result);
    }
}
// @lc code=end

