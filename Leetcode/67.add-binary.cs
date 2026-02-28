/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
public class Solution {
    public string AddBinary(string a, string b) {
        List<char> list = new (Math.Max(a.Length, b.Length) + 1);
        int carry = 0,
            i = a.Length - 1, j = b.Length - 1;

        while (i >= 0 && j >= 0)
        {
            if (a[i] == '1' && b[j] == '1')
            {
                list.Add(carry == 1 ? '1' : '0');
                carry = 1;
            }
            else if (a[i] == '0' && b[j] == '0')
            {
                list.Add(carry == 1 ? '1' : '0');
                carry = 0;
            }
            else
            {
                list.Add(carry == 1 ? '0' : '1');
            }
            i--;
            j--;
        }

        while (i >= 0)
        {
            if (carry == 0)
            {
                list.Add(a[i--]);
                continue;
            }
            
            list.Add(a[i] == '1' ? '0' : '1');
            carry = a[i--] - '0';
        }

        while (j >= 0)
        {
            if (carry == 0)
            {
                list.Add(b[j--]);
                continue;
            }
            
            list.Add(b[j] == '1' ? '0' : '1');
            carry = b[j--] - '0';
        }

        if (carry > 0)
        {
            list.Add('1');
        }

        list.Reverse();
        return new string(list.ToArray());
    }
}
// @lc code=end

