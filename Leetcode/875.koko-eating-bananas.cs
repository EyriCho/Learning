/*
 * @lc app=leetcode id=875 lang=csharp
 *
 * [875] Koko Eating Bananas
 */

// @lc code=start
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = 1, min = 1;
        
        foreach (var pile in piles)
        {
            max = Math.Max(max, pile);
        }
        
        while (min < max)
        {
            var mid = (max + min) / 2;

            var time = 0;
            foreach (var pile in piles)
            {
                time += pile / mid;
                if (pile % mid > 0)
                {
                    time++;
                }
            }

            if (time <= h)
            {
                max = mid;
            }
            else
            {
                min = mid + 1;
            }
        }
        
        return max;
    }
}
// @lc code=end

