/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution {
    public void NextPermutation(int[] nums) {
        int i = nums.Length - 2;
        for (; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
                break;
        }
        
        int l = 0, r = nums.Length - 1;
        if (i >= 0)
        {
            int min = r;
            while (min > i && nums[min] <= nums[i])
                min--;
            
            int temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;
            
            l = i + 1;
        }
        
        while (l < r)
        {
            int temp = nums[l];
            nums[l++] = nums[r];
            nums[r--] = temp;
        }
    }
}
// @lc code=end

