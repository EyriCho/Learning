/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution {
    public int MyAtoi(string s) {
        int i = 0;
        while (i < s.Length && s[i] == ' ')
            i++;
        
        if (i == s.Length)
            return 0;
        
        int sign = 1;
        if (s[i] == '-')
        {
            sign = -1;
            i++;
        }
        else if (s[i] == '+')
        {
            i++;
        }
        
        if (i == s.Length || s[i] < '0' || s[i] > '9')
            return 0;
        long number = 0;
        while (i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            number = number * 10 + (s[i] - '0');
            if (number > int.MaxValue)
                break;
            i++;
        }

        if (sign > 0 && number > int.MaxValue)
            return int.MaxValue;
        if (sign < 0 && (number * sign) < int.MinValue)
            return int.MinValue;
        
        return (int)(sign * number);
    }
}
// @lc code=end

