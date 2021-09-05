/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */

// @lc code=start
public class NumArray {

    public NumArray(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
            nums[i] += nums[i - 1];
        this.nums = nums;
    }

    int[] nums;

    public int SumRange(int left, int right) {
        return left == 0 ? nums[right] : (nums[right] - nums[left - 1]);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end

