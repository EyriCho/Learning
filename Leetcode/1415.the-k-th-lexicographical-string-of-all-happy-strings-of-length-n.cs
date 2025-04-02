/*
 * @lc app=leetcode id=1415 lang=csharp
 *
 * [1415] The k-th Lexicographical String of All Happy Strings of Length n
 */

// @lc code=start
public class Solution {
    public string GetHappyString(int n, int k) {
        int count = 1 << (n - 1);

        if (k > count * 3)
        {
            return string.Empty;
        }

        char[] array = new char[n];
        for (int i = 0; i < 3; i++)
        {
            if (count * (i + 1) >= k)
            {
                array[0] = (char)('a' + i);
                k -= count * i;
                break;
            }
        }

        for (int i = 1; i < n; i++)
        {
            count >>= 1;

            if (k <= count)
            {
                array[i] = array[i - 1] == 'a' ? 'b' : 'a';
            }
            else
            {
                array[i] = array[i - 1] == 'c' ? 'b' : 'c';
                k -= count;
            }
        }

        return new string(array);
    }
}
// @lc code=end

