/*
 * @lc app=leetcode id=2515 lang=csharp
 *
 * [2515] Shortest Distance to Target String in a Circular Array
 */

// @lc code=start
public class Solution {
    public int ClosestTarget(string[] words, string target, int startIndex) {
        int result = words.Length;

        for (int i = 0; i < words.Length; i++)
        {
            if (!words[i].Equals(target))
            {
                continue;
            }

            if (i <= startIndex)
            {
                result = Math.Min(result, startIndex - i);
                result = Math.Min(result, words.Length - startIndex + i);
            }
            else
            {
                result = Math.Min(result, i - startIndex);
                result = Math.Min(result, words.Length - i + startIndex);
            }
        }

        return result == words.Length ? -1 : result;
    }
}
// @lc code=end

