/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 */

// @lc code=start
public class Solution {
    public string ConvertToTitle(int columnNumber) {
        var list = new List<char>();
        while (columnNumber > 0)
        {
            columnNumber--;
            var remain = columnNumber % 26;
            list.Add((char)(remain + 'A'));
            columnNumber /= 26;
        }
        list.Reverse();
        return new string(list.ToArray());
    }
}
// @lc code=end

