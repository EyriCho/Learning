/*
 * @lc app=leetcode id=906 lang=csharp
 *
 * [906] Super Palindromes
 */

// @lc code=start
public class Solution {
    public int SuperpalindromesInRange(string left, string right) {
        var result = 0;
        long leftNum = long.Parse(left),
            rightNum = long.Parse(right);
        
        bool IsPalindromes(string str)
        {
            int l = 0, r = str.Length - 1;
            while (l < r)
                if (str[l++] != str[r--])
                    return false;
            
            return true;
        }
        
        for (int i = 1; i < 4; i++)
            if (i * i >= leftNum && i * i <= rightNum)
                result++;
        
        for (int i = 1; i < 10000; i++)
        {
            var s = i.ToString();
            var array = new char[s.Length * 2 + 1];
            for (int j = 0; j < s.Length; j++)
                array[j] = array[s.Length * 2 - 1 - j] = s[j];
            var num = long.Parse(new string(array[0..(s.Length * 2)]));
            num *= num;
            
            if (num > rightNum)
                break;
            
            if (IsPalindromes(num.ToString()) && num >= leftNum)
                result++;
            
            for (int j = 0; j < s.Length; j++)
                array[j] = array[s.Length * 2 - j] = s[j];
            for (char c = '0'; c <= '9'; c++)
            {
                array[s.Length] = c;
                num = long.Parse(new string(array));
                num *= num;
                if (IsPalindromes(num.ToString()) && num >= leftNum && num <= rightNum)
                    result++;
            }
        }
        
        return result;
    }
}
// @lc code=end

