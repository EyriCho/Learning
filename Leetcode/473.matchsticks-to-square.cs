/*
 * @lc app=leetcode id=473 lang=csharp
 *
 * [473] Matchsticks to Square
 */

// @lc code=start
public class Solution {
    public bool Makesquare(int[] matchsticks) {
        long total = 0L;
        foreach (var stick in matchsticks)
            total += stick;
        if (total % 4 != 0)
            return false;
        int sideLen = (int)(total / 4);
        int[] sides = new int[] {
            sideLen, sideLen, sideLen, sideLen
        };
        
        bool Make(int i)
        {
            if (i == matchsticks.Length)
                return true;
            
            for (int j = 0; j < 4; j++)
            {
                if (matchsticks[i] <= sides[j])
                {
                    sides[j] -= matchsticks[i];
                    if (Make(i + 1))
                        return true;
                    sides[j] += matchsticks[i];
                }
            }
            
            return false;
        }
        
        return Make(0);
    }
}
// @lc code=end

