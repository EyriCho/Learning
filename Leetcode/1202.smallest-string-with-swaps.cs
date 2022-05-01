/*
 * @lc app=leetcode id=1202 lang=csharp
 *
 * [1202] Smallest String With Swaps
 */

// @lc code=start
public class Solution {
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        var group = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            group[i] = i;
        }
        
        int GetGroup(int idx)
        {
            while (group[idx] != idx)
            {
                idx = group[idx];
            }
            return idx;
        }
        
        foreach (var pair in pairs)
        {
            int l = GetGroup(pair[0]),
                r = GetGroup(pair[1]);
            
            if (l < r)
            {
                group[r] = l;
            }
            else
            {
                group[l] = r;
            }
        }
        
        var dict = new Dictionary<int, PriorityQueue<char, char>>();
        
        for (int i = 0; i < s.Length; i++)
        {
            group[i] = GetGroup(i);
            if (!dict.ContainsKey(group[i]))
            {
                dict[group[i]] = new PriorityQueue<char, char>();
            }
            dict[group[i]].Enqueue(s[i], s[i]);
        }
        
        var array = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            var queue = dict[group[i]];
            array[i] = queue.Dequeue();
        }
        
        return new string(array);
    }
}
// @lc code=end

