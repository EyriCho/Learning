/*
 * @lc app=leetcode id=849 lang=csharp
 *
 * [849] Maximize Distance to Closest Person
 */

// @lc code=start
public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int result = 1;
        int l = 0, r = seats.Length - 1;
        while (seats[l] == 0)
            l++;
        while (seats[r] == 0)
            r--;
        
        if (l > result)
            result = l;
        if (seats.Length - 1 - r > result)
            result = seats.Length - 1 - r;
        
        for (int i = l + 1; i <= r; i++)
        {
            if (seats[i] == 1)
            {
                if ((i - l) / 2 > result)
                    result = (i - l) / 2;
                l = i;
            }
        }
        
        return result;
    }
}
// @lc code=end

