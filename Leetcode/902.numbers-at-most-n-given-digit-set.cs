/*
 * @lc app=leetcode id=902 lang=csharp
 *
 * [902] Numbers At Most N Given Digit Set
 */

// @lc code=start
public class Solution {
    public int AtMostNGivenDigitSet(string[] digits, int n) {
        int num = n,
            position = 1;
        while (num / 10 > 0)
        {
            num /= 10;
            position *= 10;
        }
        
        bool[] found = new bool[10];
        int[] array = new int[10];
        foreach (var digit in digits)
        {
            int d = (int)(digit[0] - '0');
            int c = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i < d && found[i])
                    c = array[i];
                else if (i > d)
                    array[i]++;
                else if (i == d)
                {
                    found[i] = true;
                    array[i] = ++c;
                }
            }
        }
        
        num = n;
        int last = num / position;
        bool isFind = found[last];
        int count = array[last];
        num -= position * last;
        position /= 10;
        
        while (position > 0)
        {
            last = num / position;
            if (!isFind)
                count = (count + 1) * digits.Length;
            else
            {
                var prev = count * digits.Length;
                if (last == 0)
                    count = prev;
                else
                    count = prev + array[last];
                isFind = found[last];
            }
            
            num -= position * last;
            position /= 10;
        }
        
        return count; 
    }
}
// @lc code=end

