/*
 * @lc app=leetcode id=3583 lang=csharp
 *
 * [3583] Count Special Triplets
 */

// @lc code=start
public class Solution {
    public int SpecialTriplets(int[] nums) {
        Dictionary<int, int> dict = new (),
            possibly = new ();
        int i = 0, j = 0, ij = 0,
            result = 0;

        foreach (int num in nums)
        {
            if ((num & 1) == 0)
            {
                result = (result + possibly.GetValueOrDefault(num >> 1, 0)) % 1_000_000_007;
            }

            possibly[num] = (possibly.GetValueOrDefault(num, 0) +
                dict.GetValueOrDefault(num * 2, 0)) % 1_000_000_007;

            dict.TryGetValue(num, out j);
            dict[num] = j + 1;
        }

        return result;
    }
}
// @lc code=end

