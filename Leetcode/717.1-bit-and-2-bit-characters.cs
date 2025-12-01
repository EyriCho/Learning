/*
 * @lc app=leetcode id=717 lang=csharp
 *
 * [717] 1-bit and 2-bit Characters
 */

// @lc code=start
public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i = 0, last = bits.Length - 1;
        
        for (; i < last; i++)
        {
            if (bits[i] == 1)
            {
                i++;
            }
        }

        return i != bits.Length;
    }
}
// @lc code=end

