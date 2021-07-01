/*
 * @lc app=leetcode id=307 lang=csharp
 *
 * [307] Range Sum Query - Mutable
 */

// @lc code=start
public class NumArray {

    public NumArray(int[] nums) {
        trie = new int[nums.Length + 1];
        array = nums;
        for (int i = 0; i < nums.Length; i++)
        {
            int k = i + 1;
            while (k <= nums.Length)
            {
                trie[k] += nums[i];
                k += k & -k;
            }
        }
    }
    
    int[] array;
    int[] trie;
    
    public void Update(int index, int val) {
        var diff = val - array[index];
        var k = index + 1;
        while (k <= array.Length)
        {
            trie[k] += diff;
            k += k & -k;
        }
        array[index] = val;
    }
    
    public int SumRange(int left, int right) {
        var result = 0;
        right++;
        while (right > 0)
        {
            result += trie[right];
            right -= right & -right;
        }
        while (left > 0)
        {
            result -= trie[left];
            left -= left & -left;
        }
        
        return result;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */
// @lc code=end

