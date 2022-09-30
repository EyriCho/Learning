/*
 * @lc app=leetcode id=985 lang=csharp
 *
 * [985] Sum of Even Numbers After Queries
 */

// @lc code=start
public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        var result = new int[queries.Length];
        
        var sum = 0;
        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        
        for (int i = 0; i < queries.Length; i++)
        {
            var origin = nums[queries[i][1]];
            var now = origin + queries[i][0];
            
            if (origin % 2 == 0)
            {
                sum -= origin;
            }
            
            if (now % 2 == 0)
            {
                sum += now;
            }
            nums[queries[i][1]] = now;
            result[i] = sum;
        }
        
        return result; 
    }
}
// @lc code=end

