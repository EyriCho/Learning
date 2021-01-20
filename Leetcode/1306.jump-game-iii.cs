/*
 * @lc app=leetcode id=1306 lang=csharp
 *
 * [1306] Jump Game III
 */

// @lc code=start
public class Solution {
    public bool CanReach(int[] arr, int start) {
        bool[] visit = new bool[arr.Length];
        return CanReach(arr, visit, start);
    }
    
    private bool CanReach(int[] arr, bool[] visit, int pos)
    {
        if (arr[pos] == 0)
            return true;
        
        if (visit[pos])
            return false;
        
        visit[pos] = true;
        
        int next = pos - arr[pos];
        if (next >= 0 && CanReach(arr, visit, next))
            return true;
            
        next = pos + arr[pos];
        if (next < arr.Length && CanReach(arr, visit, next))
            return true;
        
        visit[pos] = false;
        
        return false;
    }
}
// @lc code=end

