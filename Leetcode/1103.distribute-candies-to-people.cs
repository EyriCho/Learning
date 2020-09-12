/*
 * @lc app=leetcode id=1103 lang=csharp
 *
 * [1103] Distribute Candies to People
 */

// @lc code=start
public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        var result = new int[num_people];
        
        int index = 0, left = candies, i = 1;
        while (left >= 0)
        {
            left -= i;
            if (left > 0)
            {
                result[index] += i;
                if (++index == num_people) index = 0;
            }
            else
            {
                result[index] += left + i;
                break;
            }
            ++i;
        }
        
        return result;
    }
}
// @lc code=end

