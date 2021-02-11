/*
 * @lc app=leetcode id=1649 lang=csharp
 *
 * [1649] Create Sorted Array through Instructions
 */

// @lc code=start
public class Solution {
    public int CreateSortedArray(int[] instructions) {
        int result = 0;
        const int length = 100_001;
        const int mod = 1_000_000_007;
        var tree = new int[length];
        
        void Update(int number)
        {
            while (number < length)
            {
                tree[number]++;
                number += number & -number;
            }
        }
        
        int Count(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count += tree[number];
                number -= number & -number;
            }
            return count;
        }
        
        for (int i = 0; i < instructions.Length; i++)
        {
            int lt = Count(instructions[i] - 1);
            int gt = i - Count(instructions[i]);
            result = (result + Math.Min(lt, gt)) % mod;
            Update(instructions[i]);
        }
        return result;
    }        
}
// @lc code=end

