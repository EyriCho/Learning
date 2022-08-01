/*
 * @lc app=leetcode id=473 lang=csharp
 *
 * [473] Matchsticks to Square
 */

// @lc code=start
public class Solution {
    public bool Makesquare(int[] matchsticks) {
        var total = 0L;
        foreach (var match in matchsticks)
        {
            total += match;
        }
        
        if (total % 4 != 0)
        {
            return false;
        }
        
        Array.Sort(matchsticks, (a, b) => b - a);
        
        var length = (int)(total / 4);
        var sides = new int[] {
            length, length,
            length, length
        };
        
        bool Check(int i)
        {
            if (i == matchsticks.Length)
            {
                return true;
            }
            
            for (int j = 0; j < 4; j++)
            {
                if (sides[j] >= matchsticks[i])
                {
                    sides[j] -= matchsticks[i];
                    
                    if (Check(i + 1))
                    {
                        return true;
                    }
                    
                    sides[j] += matchsticks[i];
                }
            }
            
            return false;
        }
        
        return Check(0);
    }
}
// @lc code=end

