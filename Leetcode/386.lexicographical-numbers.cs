/*
 * @lc app=leetcode id=386 lang=csharp
 *
 * [386] Lexicographical Numbers
 */

// @lc code=start
public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<int> result = new (n);

        int current = 1;
        for (int i = 0; i < n; i++)
        {
            result.Add(current);
            if (current * 10 <= n)
            {
                current *= 10;
            }
            else
            {
                if (current >= n)
                {
                    current /= 10;
                }
                current++;
                while (current % 10 == 0)
                {
                    current /= 10;
                }
            }
        }

        return result;
    }
}
// @lc code=end

