/*
 * @lc app=leetcode id=761 lang=csharp
 *
 * [761] Special Binary String
 */

// @lc code=start
public class Solution {
    public string MakeLargestSpecial(string s) {
        if (s.Length == 2)
        {
            return s;
        }

        List<string> list = new ();
        int balance = 0, index = 0;
        string inner = null;
        for (int i = 0; i < s.Length; i++)
        {
            balance += s[i] == '1' ? 1 : -1;

            if (balance == 0)
            {
                inner = MakeLargestSpecial(s[(index + 1)..i]);
                list.Add($"1{inner}0");
                index = i + 1;
            }
        }
        list.Sort((a, b) => b.CompareTo(a));
        StringBuilder sb = new ();
        foreach (string str in list)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }
}
// @lc code=end

