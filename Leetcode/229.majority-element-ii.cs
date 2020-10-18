/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var result = new List<int>();
        
        int a = 0, b = 0;
        int aCount = 0, bCount = 0;
        foreach (var num in nums)
        {
            if (num == a)
                aCount++;
            else if (num == b)
                bCount++;
            else if (aCount == 0)
            {
                a = num;
                aCount = 1;
            }
            else if (bCount == 0)
            {
                b = num;
                bCount = 1;
            }
            else
            {
                aCount--;
                bCount--;
            }
        }
        
        aCount = 0;
        bCount = 0;
        foreach (var num in nums)
        {
            if (num == a)
                aCount++;
            else if (num == b)
                bCount++;
        }
        if (aCount > nums.Length / 3)
            result.Add(a);
        if (bCount > nums.Length / 3)
            result.Add(b);
        
        return result;
    }
}
// @lc code=end

