/*
 * @lc app=leetcode id=721 lang=csharp
 *
 * [721] Accounts Merge
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        var map = new int[accounts.Count];
        var dict = new Dictionary<string, int>();
        
        int find(int i)
        {
            return i == map[i] ? i : find(map[i]);
        }
        
        for (int i = 0; i < accounts.Count; i++)
        {
            map[i] = i;
            for (int k = 1; k < accounts[i].Count; k++)
            {
                string mail = accounts[i][k];
                if (dict.ContainsKey(mail))
                    map[find(i)] = find(dict[mail]);
                else
                    dict[mail] = i;
            }
        }
        
        var names = new Dictionary<int, HashSet<string>>();
        for (int i = 0; i < accounts.Count; i++)
        {
            var j = find(i);
            if (!names.ContainsKey(j))
                names[j] = new HashSet<string>();
            
            for (int k = 1; k < accounts[i].Count; k++)
                if (!names[j].Contains(accounts[i][k]))
                    names[j].Add(accounts[i][k]);
        }
        
        return names.Select(n => {
            var a = n.Value.ToArray();
            Array.Sort(a, string.CompareOrdinal);
            var l = a.ToList();
            l.Insert(0, accounts[n.Key][0]);
            return l as IList<string>;
        }).ToList();
    }
}
// @lc code=end

