/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, IList<string>>();
        
        foreach (var str in strs)
        {
            var array = str.ToCharArray();
            Array.Sort(array);
            var k = new string(array);
            if (!dict.ContainsKey(k))
                dict.Add(k, new List<string>());
            dict[k].Add(str);
        }
        
        return dict.Values.ToList();
    }
}
// @lc code=end

