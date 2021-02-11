/*
 * @lc app=leetcode id=1675 lang=csharp
 *
 * [1675] Minimum Deviation in Array
 */

// @lc code=start
public class Solution {
    public int MinimumDeviation(int[] nums) {
        var ss = new SortedSet<int>();
        int min = int.MaxValue;
        
        foreach (var num in nums)
        {
            int temp = (num & 1) == 0 ? num : (num << 1);
            ss.Add(temp);
            min = Math.Min(min, temp);
        }
        
        int result = ss.Max - min;
        
        while (ss.Count > 0 && (ss.Max & 1) == 0)
        {
            int num = ss.Max / 2;
            ss.Remove(ss.Max);
            min = Math.Min(min, num);
            ss.Add(num);
            result = Math.Min(result, ss.Max - min);
        }
        
        return result;
    }
}
// @lc code=end

