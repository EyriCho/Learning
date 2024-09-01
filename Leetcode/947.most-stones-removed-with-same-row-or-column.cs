/*
 * @lc app=leetcode id=947 lang=csharp
 *
 * [947] Most Stones Removed with Same Row or Column
 */

// @lc code=start
public class Solution {
    public int RemoveStones(int[][] stones) {
        int[] roots = new int[stones.Length];
        
        int getRoot(int x) =>
            x == roots[x] ? x : getRoot(roots[x]);
        
        for (int i = 0; i < stones.Length; i++)
        {
            roots[i] = i;
        }
        for (int i = 0; i < stones.Length; i++)
        {
            for (int j = i + 1; j < stones.Length; j++)
            {
                if (stones[i][0] == stones[j][0] ||
                    stones[i][1] == stones[j][1])
                {
                    roots[getRoot(i)] = getRoot(j);
                }
            }
        }
        
        int group = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if (roots[i] == i)
            {
                group++;
            }
        }
        
        return stones.Length - group;
    }
}
// @lc code=end

