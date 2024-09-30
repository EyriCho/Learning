/*
 * @lc app=leetcode id=2326 lang=csharp
 *
 * [2326] Spiral Matrix IV
 */

// @lc code=start
public class Solution {
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        int[][] result = new int[m][];
        for (int k = 0; k < m; k++)
        {
            result[k] = new int[n];
            Array.Fill(result[k], -1);
        }

        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };
        int d = 0,
            count = m * n,
            c = 0,
            x = 0,
            y = -1,
            i = 0,
            j = 0;

        ListNode node = head;
        while (node != null && c < count)
        {
            i = x + ds[d, 0];
            j = y + ds[d, 1];
            if (i < 0 || i >= m ||
                j < 0 || j >= n ||
                result[i][j] > -1)
            {
                d++;
                d %= 4;

                i = x + ds[d, 0];
                j = y + ds[d, 1];
            }

            result[i][j] = node.val;
            x = i;
            y = j;

            node = node.next;
            c++;
        }

        return result;
    }
}
// @lc code=end

