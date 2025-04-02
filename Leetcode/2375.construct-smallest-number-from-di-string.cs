/*
 * @lc app=leetcode id=2375 lang=csharp
 *
 * [2375] Construct Smallest Number From DI String
 */

// @lc code=start
public class Solution {
    public string SmallestNumber(string pattern) {
        char[] array = new char[pattern.Length + 1];
        int last = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (char)(i + '1');
            if (i == pattern.Length || pattern[i] == 'I')
            {
                Array.Reverse(array, last, i - last + 1);
                last = i + 1;
            }
        }

        return new string(array);
    }
}
// @lc code=end

