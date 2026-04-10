/*
 * @lc app=leetcode id=3653 lang=csharp
 *
 * [3653] XOR After Range Multiplication Queries I
 */

// @lc code=start
public class Solution {
    public int XorAfterQueries(int[] nums, int[][] queries) {
        long temp = 0L;
        foreach (int[] query in queries)
        {
            for (int i = query[0]; i <= query[1]; i += query[2])
            {
                temp = (long)nums[i] * query[3] % 1_000_000_007L;
                nums[i] = (int)temp;
            }
        }

        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }
}
// @lc code=end

