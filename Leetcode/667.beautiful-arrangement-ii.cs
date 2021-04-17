/*
 * @lc app=leetcode id=667 lang=csharp
 *
 * [667] Beautiful Arrangement II
 */

// @lc code=start
public class Solution {
    public int[] ConstructArray(int n, int k) {
        int l = 1, r = n;
        var result = new int[n];
        bool isFront = false;
        
        for (int i = 0; i < n; i++)
        {
            if (k > 0)
            {
                k--;
                isFront = !isFront;
            }
            
            if (isFront)
                result[i] = l++;
            else
                result[i] = r--;
        }
        
        return result;
    }
}
// @lc code=end

