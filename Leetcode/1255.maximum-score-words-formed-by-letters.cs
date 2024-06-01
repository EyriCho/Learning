/*
 * @lc app=leetcode id=1255 lang=csharp
 *
 * [1255] Maximum Score Words Formed by Letters
 */

// @lc code=start
public class Solution {
    public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        int[,] wArray = new int[words.Length, 26];
        int[] lArray = new int[26],
            temp = new int[26];
        foreach (char l in letters)
        {
            lArray[l - 'a']++;
        }

        for (int i = 0; i < words.Length; i++)
        {
            foreach (char l in words[i])
            {
                wArray[i, l - 'a']++;
            }
        }

        int result = 0;

        void Dfs(int index, int s)
        {
            result = Math.Max(result, s);

            for (int i = index; i < words.Length; i++)
            {
                bool satisfy = true;
                for (int l = 0; l < 26; l++)
                {
                    if (temp[l] + wArray[i, l] > lArray[l])
                    {
                        satisfy = false;
                        break;
                    }
                }

                if (satisfy)
                {
                    for (int l = 0; l < 26; l++)
                    {
                        temp[l] += wArray[i, l];
                        s += wArray[i, l] * score[l];
                    }

                    Dfs(i + 1, s);

                    for (int l = 0; l < 26; l++)
                    {
                        temp[l] -= wArray[i, l];
                        s -= wArray[i, l] * score[l];
                    }
                }
            }
        }

        Dfs(0, 0);
        
        return result;
    }
}
// @lc code=end

