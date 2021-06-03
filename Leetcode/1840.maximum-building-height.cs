/*
 * @lc app=leetcode id=1840 lang=csharp
 *
 * [1840] Maximum Building Height
 */

// @lc code=start
public class Solution {
    public int MaxBuilding(int n, int[][] restrictions) {
        if (restrictions.Length == 0)
            return n - 1;
        
        Array.Sort(restrictions, (a, b) => a[0] - b[0]);
        
        // Arrage the restriction from start
        int prev = 1, prevHeight = 0;
        for (int i = 0; i < restrictions.Length; i++)
        {
            if (restrictions[i][1] - prevHeight >
               restrictions[i][0] - prev)
                restrictions[i][1] = restrictions[i][0] - prev + prevHeight;
            
            prev = restrictions[i][0];
            prevHeight = restrictions[i][1];
        }
        
        // Arrage the restriction from end
        prev = n;
        prevHeight = n - 1;
        for (int i = restrictions.Length - 1; i >= 0; i--)
        {
            if (restrictions[i][1] - prevHeight >
               prev - restrictions[i][0])
                restrictions[i][1] = prev - restrictions[i][0] + prevHeight;
            
            prev = restrictions[i][0];
            prevHeight = restrictions[i][1];            
        }
        
        // calc the maximum height
        int result = 0, height = 0;     
        if (restrictions[0][0] > 0)
        {
            result = (restrictions[0][0] - 1 + restrictions[0][1]) / 2;
        }
        
        for (int i = 1; i < restrictions.Length; i++)
        {
            height = (restrictions[i - 1][1] + restrictions[i][1] + 
                restrictions[i][0] - restrictions[i - 1][0]) /  2;
            result = Math.Max(result, height);
        }
        
        height = restrictions[restrictions.Length - 1][1] + (n - restrictions[restrictions.Length - 1][0]);
        result = Math.Max(result, height);
        return result;
    }
}
// @lc code=end