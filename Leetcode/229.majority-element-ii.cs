/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        if (nums.Length < 2)
        {
            return new List<int>(nums);
        }

        int first = 0, second = 0;
        int count1 = 0, count2 = 0;

        foreach (var num in nums)
        {
            if (first == num)
            {
                count1++;
            }
            else if (second == num)
            {
                count2++;
            }
            else if (count1 == 0)
            {
                count1++;
                first = num;
            }
            else if (count2 == 0)
            {
                count2++;
                second = num;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        count1 = count2 = 0;

        foreach (var num in nums)
        {
            if (first == num)
            {
                count1++;
            }
            else if (second == num)
            {
                count2++;
            }
        }

        var result = new List<int>();
        if (count1 > nums.Length / 3)
        {
            result.Add(first);
        }
        if (count2 > nums.Length / 3)
        {
            result.Add(second);
        }

        return result;
    }
}
// @lc code=end

