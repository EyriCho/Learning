/*
 * @lc app=leetcode id=1823 lang=csharp
 *
 * [1823] Find the Winner of the Circular Game
 */

// @lc code=start
public class Solution {
    public int FindTheWinner(int n, int k) {
        List<int> list = new (n);
        int i = 0;
        for (; i < n; i++)
        {
            list.Add(i + 1);
        }

        i = 0;
        while (n > 1)
        {
            i = (i + k - 1) % n;
            list.RemoveAt(i);
            n--;
        }
        return list[0];
    }
}
// @lc code=end

