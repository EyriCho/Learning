/*
 * @lc app=leetcode id=3307 lang=csharp
 *
 * [3307] Find the K-th Character in String Game II
 */

// @lc code=start
public class Solution {
    public char KthCharacter(long k, int[] operations) {
        int pow = 0,
            shift = 0;
        k--;
        while (k > 0)
        {
            pow = (int)Math.Log(k, 2);
            k -= (1L << pow);
            if (operations[pow] > 0)
            {
                shift++;
            }
        }
        return (char)('a' + shift % 26);
    }
}
// @lc code=end

