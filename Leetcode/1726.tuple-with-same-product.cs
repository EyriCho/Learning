/*
 * @lc app=leetcode id=1726 lang=csharp
 *
 * [1726] Tuple with Same Product
 */

// @lc code=start
public class Solution {
    public int TupleSameProduct(int[] nums) {
        Dictionary<int, int> dict = new ();
        int product = 0,
            count = 0,
            tuples = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                product = nums[i] * nums[j];
                dict.TryGetValue(product, out count);
                tuples += count;
                dict[product] = count + 1;
            }
        }

        return tuples * 8;
    }
}
// @lc code=end

