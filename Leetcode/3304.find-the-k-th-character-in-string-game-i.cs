/*
 * @lc app=leetcode id=3304 lang=csharp
 *
 * [3304] Find the K-th Character in String Game I
 */

// @lc code=start
public class Solution {
    public char KthCharacter(int k) {
        int pow = 0,
            shift = 0;
        k--;
        while (k > 0)
        {
            pow = (int)Math.Log(k, 2);
            k -= 1 << pow;
            shift++;
        }

        return (char)('a' + shift % 26);
    }
}
// @lc code=end

