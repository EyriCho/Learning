/*
 * @lc app=leetcode id=2305 lang=csharp
 *
 * [2305] Fair Distribution of Cookies
 */

// @lc code=start
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
    public int DistributeCookies(int[] cookies, int k) {
        var childs = new int[k];

        int Backtrace(int idx)
        {
            if (idx == cookies.Length)
            {
                return childs.Max();
            }

            var rst = int.MaxValue;
            for (int i = 0; i < k; i++)
            {
                childs[i] += cookies[idx];
                rst = Math.Min(rst, Backtrace(idx + 1));
                childs[i] -= cookies[idx];
                if (childs[i] == 0)
                {
                    break;
                }
            }
            return rst;
        }

        return Backtrace(0);
    }
}
// @lc code=end