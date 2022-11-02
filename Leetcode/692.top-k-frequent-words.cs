/*
 * @lc app=leetcode id=692 lang=csharp
 *
 * [692] Top K Frequent Words
 */

// @lc code=start
public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!dict.TryGetValue(word, out int count))
            {
                dict[word] = count = 0;
            }
            dict[word] = count + 1;
        }
        
        var array = new (int, string)[dict.Count];
        var i = 0;
        foreach (var kv in dict)
        {
            array[i++] = (kv.Value, kv.Key);
        }
        
        Array.Sort(array, (a, b) =>
            a.Item1 == b.Item1 ? a.Item2.CompareTo(b.Item2) : b.Item1 - a.Item1);
        
        return array[0..k].Select(a => a.Item2).ToList();
    }
}
// @lc code=end

