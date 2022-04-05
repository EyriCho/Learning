/*
 * @lc app=leetcode id=410 lang=csharp
 *
 * [410] Split Array Largest Sum
 */

// @lc code=start
public class Solution {
    public int SplitArray(int[] nums, int m) {
        int sum = 0, max = 0;
        
        foreach (var num in nums)
        {
            sum += num;
            max = Math.Max(max, num);
        }
        
        bool Valid(int target)
        {
            int count = 1, curSum = 0;
            foreach (var num in nums)
            {
                curSum += num;
                if (curSum > target)
                {
                    curSum = num;
                    count++;
                    
                    if (count > m)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
        
        int l = max, r = sum;
        
        while (l < r)
        {
            var mid = (l + r) >> 1;
            
            if (Valid(mid))
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        
        return l;
    }
}
// @lc code=end

