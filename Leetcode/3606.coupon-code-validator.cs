/*
 * @lc app=leetcode id=3606 lang=csharp
 *
 * [3606] Coupon Code Validator
 */

// @lc code=start
public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        List<(int line, string cod)> list = new ();

        int line = 0;
        for (int i = 0; i < code.Length; i++)
        {
            if (!isActive[i])
            {
                continue;
            }
            if (string.IsNullOrEmpty(code[i]) ||
                code[i].Any(c => !Char.IsLetterOrDigit(c) && c != '_'))
            {
                continue;
            }

            line = businessLine[i] switch
            {
                "electronics" => 1,
                "grocery" => 2,
                "pharmacy" => 3,
                "restaurant" => 4,
                _ => 0,
            };

            if (line == 0)
            {
                continue;
            }

            list.Add((line, code[i]));
        }

        list.Sort((a, b) => a.line == b.line ?
            String.Compare(a.cod, b.cod, StringComparison.Ordinal) :
            a.line.CompareTo(b.line));

        return list.Select(item => item.cod).ToList();
    }
}
// @lc code=end

