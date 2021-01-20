/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */

// @lc code=start
public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0)
            return true;
        
        int l = 0, planted = 0;
        int i = 0;
        for (; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1)
            {
                if (i > l + 1)
                {
                    planted += (i - l) / 2;
                }
                l = i + 2;
            }
        }
        
        if (flowerbed[i - 1] == 0)
        {
            planted += (i - l + 1) / 2;
        }
        
        return planted >= n;
    }
}
// @lc code=end

