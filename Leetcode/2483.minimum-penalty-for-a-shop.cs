/*
 * @lc app=leetcode id=2483 lang=csharp
 *
 * [2483] Minimum Penalty for a Shop
 */

// @lc code=start
public class Solution {
    public int BestClosingTime(string customers) {
        var closePenalty = new int[customers.Length + 1];
        for (int i = customers.Length - 1; i >= 0; i--)
        {
            closePenalty[i] = closePenalty[i + 1];
            if (customers[i] == 'Y')
            {
                closePenalty[i] += 1;
            }
        }

        var min = closePenalty[0];
        var minDay = 0;
        var openPenalty = 0;
        for (int i = 0; i < customers.Length; i++)
        {
            if (openPenalty + closePenalty[i] < min)
            {
                min = openPenalty + closePenalty[i];
                minDay = i;
            }

            if (customers[i] == 'N')
            {
                openPenalty++;
            }
        }

        return openPenalty < min ? customers.Length : minDay;
    }
}
// @lc code=end

