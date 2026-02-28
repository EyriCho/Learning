/*
 * @lc app=leetcode id=693 lang=csharp
 *
 * [693] Binary Number with Alternating Bits
 */

// @lc code=start
public class Solution {
    public bool HasAlternatingBits(int n) {
        List<bool> list = new ();

        for (int mask = 1; n > 0; mask <<= 1)
        {
            list.Add((mask & n) > 0);
            n &= ~mask;
        }

        for (int i = 1; i < list.Count; i++)
        {
            if (!(list[i] ^ list[i - 1]))
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

