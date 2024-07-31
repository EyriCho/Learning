/*
 * @lc app=leetcode id=1105 lang=csharp
 *
 * [1105] Filling Bookcase Shelves
 */

// @lc code=start
public class Solution {
    public int MinHeightShelves(int[][] books, int shelfWidth) {
        int[] dp = new int[books.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        int i = 0,
            r = 1,
            height = 0,
            width = 0;

        while (r <= books.Length)
        {
            width = 0;
            height = 0;

            i = r - 1;
            while (i >= 0)
            {
                width += books[i][0];
                if (width > shelfWidth)
                {
                    break;
                }
                height = Math.Max(height, books[i][1]);
                dp[r] = Math.Min(dp[r], dp[i] + height);
                i--;
            }

            r++;
        }

        return dp[books.Length];
    }
}
// @lc code=end

