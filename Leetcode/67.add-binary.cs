/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        var list = new List<char>(Math.Max(a.Length, b.Length) + 1);
        var carry = 0;
        int i = a.Length - 1,
            j = b.Length - 1;
        
        while (i >= 0 && j >= 0)
        {
            var add = carry + (a[i--] - '0') + (b[j--] - '0');
            if (add > 1)
                carry = 1;
            else
                carry = 0;
            
            if (add == 0 || add == 2)
                list.Add('0');
            else
                list.Add('1');
        }
        
        while (i >= 0)
        {
            if (carry == 0)
                list.Add(a[i--]);
            else
            {
                if (a[i--] == '1')
                    list.Add('0');
                else
                {
                    list.Add('1');
                    carry = 0;
                }
            }
        }
        
        while (j >= 0)
        {
            if (carry == 0)
                list.Add(b[j--]);
            else
            {
                if (b[j--] == '1')
                    list.Add('0');
                else
                {
                    list.Add('1');
                    carry = 0;
                }
            }
        }
        if (carry > 0)
            list.Add('1');
        
        list.Reverse();
        return new string(list.ToArray());
    }
}
// @lc code=end

