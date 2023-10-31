/*
 * @lc app=leetcode id=779 lang=csharp
 *
 * [779] K-th Symbol in Grammar
 */

// @lc code=start
public class Solution {
    public int KthGrammar(int n, int k) {
        bool Dfs(int row, int index)
        {
            if (row == 1)
            {
                return false;
            }

            var c = 1 << (row - 2);
            return index > c ? !Dfs(row - 1, index - c) : Dfs(row - 1, index);
        }
        
        return Dfs(n, k) ? 1 : 0;
    }
}
// @lc code=end

