/*
 * @lc app=leetcode id=1863 lang=csharp
 *
 * [1863] Sum of All Subset XOR Totals
 */

// @lc code=start
public class Solution {
    public int SubsetXORSum(int[] nums) {
        List<int> array = new ();
        array.Add(0);

        int count = 0,
            result = 0,
            xor = 0;
        foreach (int num in nums)
        {
            count = array.Count;
            for (int i = 0; i < count; i++)
            {
                xor = array[i] ^ num;
                array.Add(xor);
                result += xor;
            }
        }

        return result;
    }
}
// @lc code=end

