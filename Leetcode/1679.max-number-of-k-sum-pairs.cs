/*
 * @lc app=leetcode id=1679 lang=csharp
 *
 * [1679] Max Number of K-Sum Pairs
 */

// @lc code=start
public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        
        int result = 0;
        foreach (var num in nums)
        {
            int remain = k - num;
            if (dict.ContainsKey(remain) && 
               dict[remain] > 0)
            {
                dict[remain]--;
                result++;
            }
            else
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;
            }
        }
        
        return result;
    }
}
// @lc code=end

