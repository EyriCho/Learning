/*
 * @lc app=leetcode id=2029 lang=csharp
 *
 * [2029] Stone Game IX
 */

// @lc code=start
public class Solution {
    public bool StoneGameIX(int[] stones) {
        int[] remains = new int[3];
        foreach (int stone in stones)
        {
            remains[stone % 3]++;
        }

        if (remains[0] % 2 == 0)
        {
            return remains[1] >= 1 && remains[2] >= 1;
        }

        return remains[1] - remains[2] > 2 ||
            remains[2] - remains[1] > 2;
    }
}
// @lc code=end

