/*
 * @lc app=leetcode id=2434 lang=csharp
 *
 * [2434] Using a Robot to Print the Lexicographically Smallest String
 */

// @lc code=start
public class Solution {
    public string RobotWithString(string s) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        Stack<int> stack = new ();
        char[] array = new char[s.Length];
        int idx = 0,
            last = 0, prev = 0;

        for (int c = 0; c < counts.Length; c++)
        {
            while (stack.Count > 0 && s[stack.Peek()] - 'a' <= c)
            {
                array[idx++] = s[stack.Pop()];
            }

            while (counts[c] > 0)
            {
                for (int i = prev; i < s.Length; i++)
                {
                    stack.Push(i);
                    counts[s[i] - 'a']--;
                    if (s[i] - 'a' == c)
                    {
                        prev = i + 1;
                        break;
                    }
                }
                array[idx++] = s[stack.Pop()];
            }
        }

        while (stack.Count > 0)
        {
            array[idx++] = s[stack.Pop()];
        }

        return new string(array);
    }
}
// @lc code=end

