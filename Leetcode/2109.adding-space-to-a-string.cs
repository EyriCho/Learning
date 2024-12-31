/*
 * @lc app=leetcode id=2109 lang=csharp
 *
 * [2109] Adding Space to a String
 */

// @lc code=start
public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        char[] array = new char[s.Length + spaces.Length];
        int sIndex = 0, spaceIndex = 0, resultIndex = 0;
        while (sIndex < s.Length)
        {
            if (spaceIndex < spaces.Length && sIndex == spaces[spaceIndex])
            {
                array[resultIndex++] = ' ';
                spaceIndex++;
            }

            array[resultIndex++] = s[sIndex++];
        }

        return new string(array);
    }
}
// @lc code=end

