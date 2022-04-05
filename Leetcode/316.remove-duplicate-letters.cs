/*
 * @lc app=leetcode id=316 lang=csharp
 *
 * [316] Remove Duplicate Letters
 */

// @lc code=start
public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var letters = new int[26];
        var visited = new bool[26];
        
        var stack = new Stack<char>();
        
        foreach (var c in s)
        {
            letters[c - 'a']++;
        }
        
        stack.Push('0');
        
        foreach (var c in s)
        {
            int i = c - 'a';
            letters[i]--;
            
            if (visited[i])
            {
                continue;
            }
            
            while (c < stack.Peek() && letters[stack.Peek() - 'a'] > 0)
            {
                visited[stack.Pop() - 'a'] = false;
            }
            
            stack.Push(c);
            visited[i] = true;
        }
        
        var array = new char[stack.Count - 1];
        int j = stack.Count - 2;
        while (j >= 0)
        {
            array[j--] = stack.Pop();
        }
        
        return new string(array);
    }
}
// @lc code=end

