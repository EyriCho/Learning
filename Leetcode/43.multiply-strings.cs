/*
 * @lc app=leetcode id=43 lang=csharp
 *
 * [43] Multiply Strings
 */

// @lc code=start
public class Solution {
    public string Multiply(string num1, string num2) {
        var array = new int[num1.Length + num2.Length];
        
        for (int i = num1.Length - 1; i >= 0; i--)
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                var mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j, p2 = i + j + 1;
                var sum = mul + array[p2];
                array[p1] += sum / 10;
                array[p2] = sum % 10;
            }
                
        var chars = new char[num1.Length + num2.Length];
        int z = 0;
        for (int i = 0; i < array.Length; i++)
            if (z != 0 || array[i] > 0)
                chars[z++] = (char)('0' + array[i]);
        
        return z == 0 ? "0" : new string(chars, 0, z);
    }
}
// @lc code=end

