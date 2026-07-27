/*
 * @lc app=leetcode id=1081 lang=csharp
 *
 * [1081] Smallest Subsequence of Distinct Characters
 */

// @lc code=start
public class Solution {
    public string SmallestSubsequence(string s) {
        int[] counts = new int[26];
        bool[] visited = new bool[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        Stack<char> stack = new ();
        stack.Push('0');

        int idx = 0;
        foreach (char c in s)
        {
            idx = c - 'a';
            counts[idx]--;

            if (visited[idx])
            {
                continue;
            }

            while (c < stack.Peek() &&
                counts[stack.Peek() - 'a'] > 0)
            {
                visited[stack.Pop() - 'a'] = false;
            }

            stack.Push(c);
            visited[idx] = true;
        }

        char[] array = new char[stack.Count - 1];
        int j = stack.Count - 2;
        while (j >= 0)
        {
            array[j--] = stack.Pop();
        }

        return new string(array);
    }
}
// @lc code=end

