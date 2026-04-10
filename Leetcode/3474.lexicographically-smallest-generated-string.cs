/*
 * @lc app=leetcode id=3474 lang=csharp
 *
 * [3474] Lexicographically Smallest Generated String
 */

// @lc code=start
public class Solution {
    public string GenerateString(string str1, string str2) {
        char[] array = new char[str1.Length + str2.Length - 1];

        int i = 0;
        
        for (int i1 = 0; i1 < str1.Length; i1++)
        {
            if (str1[i1] == 'F')
            {
                continue;
            }
            
            for (int i2 = 0; i2 < str2.Length; i2++)
            {
                i = i1 + i2;
                if (array[i] != '\0' &&
                    array[i] != str2[i2])
                {
                    return string.Empty;
                }
                array[i] = str2[i2];
            }
        }

        string prev = new string(array);
        for (i = 0; i < array.Length; i++)
        {
            if (array[i] == '\0')
            {
                array[i] = 'a';
            }
        }

        bool check = false;
        for (int i1 = 0; i1 < str1.Length; i1++)
        {
            if (str1[i1] != 'F')
            {
                continue;
            }

            if (!str2.Equals(new string(array, i1, str2.Length)))
            {
                continue;
            }

            check = false;
            for (i = i1 + str2.Length - 1; i >= i1; i--)
            {
                if (prev[i] == '\0')
                {
                    array[i] = 'b';
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                return string.Empty;
            }
        }

        return new string(array);
    }
}
// @lc code=end

