/*
 * @lc app=leetcode id=2379 lang=csharp
 *
 * [2379] Minimum Recolors to Get K Consecutive Black Blocks 
 */

// @lc code=start
public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int result = k,
            white = 0,
            i = 0;

        while (i < k)
        {
            if (blocks[i++] == 'W')
            {
                white++;
            }
        }

        result = white;
        while (i < blocks.Length)
        {
            if (blocks[i] == 'W')
            {
                white++;
            }
            if (blocks[i - k] == 'W')
            {
                white--;
            }

            result = Math.Min(result, white);
            i++;
        }

        return result;
    }
}
// @lc code=end

