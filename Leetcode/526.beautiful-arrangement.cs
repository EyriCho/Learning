/*
 * @lc app=leetcode id=526 lang=csharp
 *
 * [526] Beautiful Arrangement
 */

// @lc code=start
public class Solution {
    public int CountArrangement(int n) {
        var array = new bool[n + 1];
        
        CountArrangement(n, 1, array);
        return result;
    }
    
    int result = 0;
    
    private void CountArrangement(int n, int index, bool[] used)
    {
        if (index > n)
        {
            result++;
            return;
        }
        
        for (int i = 1; i <= n; i++)
        {
            if (!used[i] && (i % index == 0 ||
                index % i == 0))
            {
                used[i] = true;
                
                CountArrangement(n, index + 1, used);
                
                used[i] = false;
            }
        }
    }
}
// @lc code=end

