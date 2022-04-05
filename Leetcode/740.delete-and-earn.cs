/*
 * @lc app=leetcode id=740 lang=csharp
 *
 * [740] Delete and Earn
 */

// @lc code=start
public class Solution {
    public int DeleteAndEarn(int[] nums) {
        int min = 10000, max = 0;
        var dict = new Dictionary<int, int>();
        
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
            
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        
        int prev = 0, curr = 0;
        for (int i = min; i <= max; i++)
        {
            if (dict.ContainsKey(i))
            {
                var m = Math.Max(dict[i] * i + prev, curr);
                prev = curr;
                curr = m;
            }
            else
            {
                prev = curr;
            }
        }
        
        return curr;
     }
}
// @lc code=end

