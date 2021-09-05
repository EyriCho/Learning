/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 */

// @lc code=start
public class Solution {
    public string AddStrings(string num1, string num2) {
        int i1 = num1.Length - 1, i2 = num2.Length - 1,
            carry = 0;
        var list = new List<char>();
        while (i1 >= 0 && i2 >= 0)
        {
            var digit = (num1[i1--] - '0') + (num2[i2--] - '0') + carry;
            carry = digit / 10;
            list.Add((char)(digit % 10 + '0'));
        }
        
        while (i1 >= 0)
        {
            if (carry > 0)
            {
                var digit = (num1[i1--] - '0') + carry;
                carry = digit / 10;
                list.Add((char)(digit % 10 + '0'));
            }
            else
                list.Add(num1[i1--]);
        }
        
        while (i2 >= 0)
        {
            if (carry > 0)
            {
                var digit = (num2[i2--] - '0') + carry;
                carry = digit / 10;
                list.Add((char)(digit % 10 + '0'));
            }
            else
                list.Add(num2[i2--]);
        }
        
        if (carry > 0)
            list.Add((char)(carry + '0'));
        
        list.Reverse();
        
        return new string(list.ToArray());
    }
}
// @lc code=end

