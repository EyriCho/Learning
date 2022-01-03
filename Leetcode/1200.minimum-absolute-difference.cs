/*
 * @lc app=leetcode id=1200 lang=csharp
 *
 * [1200] Minimum Absolute Difference
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        
        var result = new List<IList<int>>();
        var min = int.MaxValue;
        
        for (int i = 1; i < arr.Length; i++)
            min = Math.Min(min, arr[i] - arr[i - 1]);
            
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] == min)
                result.Add(new List<int> { arr[i - 1], arr[i] });
        
        return result;
    }
}
// @lc code=end

