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
            max = Math.Max(max, pile);
        
        bool CanEat(int speed)
        {
            int time = 0;
            foreach (var pile in piles)
                time += (int)Math.Ceiling((double) pile / speed);
            
            return time <= h;
        }
        
        while (min < max)
        {
            var mid = (max + min) / 2;
            if (CanEat(mid))
                max = mid;
            else
                min = mid + 1;
        }
        
        return max;
    }
}
// @lc code=end

