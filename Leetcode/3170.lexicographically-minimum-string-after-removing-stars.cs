/*
 * @lc app=leetcode id=3170 lang=csharp
 *
 * [3170] Lexicographically Minimum String After Removing Stars
 */

// @lc code=start
public class Solution {
    public string ClearStars(string s) {
        Stack<int>[] stacks = new Stack<int>[26];
        for (int i = 0; i < 26; i++)
        {
            stacks[i] = new ();
        }

        char[] array = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '*')
            {
                stacks[s[i] - 'a'].Push(i);
            }
            else
            {
                for (int c = 0; c < 26; c++)
                {
                    if (stacks[c].Count > 0)
                    {
                        array[stacks[c].Pop()] = '*';
                        break;
                    }
                }
            }
        }

        return new string(array.Where(c => c != '*').ToArray());
    }
}
// @lc code=end

