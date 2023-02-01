/*
 * @lc app=leetcode id=997 lang=csharp
 *
 * [997] Find the Town Judge
 */

// @lc code=start
public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int[] t = new int[n + 1];
        
        foreach (var tru in trust)
        {
            t[tru[0]] = -1;
            if (t[tru[1]] >= 0)
                t[tru[1]]++;
        }
        
        for (int i = 1; i <= n; i++)
        {
            if (t[i] == n - 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}
// @lc code=end

