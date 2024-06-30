/*
 * @lc app=leetcode id=1791 lang=csharp
 *
 * [1791] Find Center of Star Graph
 */

// @lc code=start
public class Solution {
    public int FindCenter(int[][] edges) {
        if (edges[0][0] == edges[1][0] ||
            edges[0][1] == edges[1][0])
        {
            return edges[1][0];
        }
        else
        {
            return edges[1][1];
        }
    }
}
// @lc code=end

