/*
 * @lc app=leetcode id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
public class Solution {
    public IList<string> FizzBuzz(int n) {
        var list = new List<string>(n);
        var sb = new StringBuilder();
        for (int i = 1; i < n + 1; i++)
        {
            sb.Clear();
            if (i % 3 == 0)
                sb.Append("Fizz");
            if (i % 5 == 0)
                sb.Append("Buzz");
            if (sb.Length == 0)
                sb.Append(i.ToString());
            list.Add(sb.ToString());
        }
        return list;
    }
}
// @lc code=end

