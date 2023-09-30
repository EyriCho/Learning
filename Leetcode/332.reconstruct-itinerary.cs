/*
 * @lc app=leetcode id=332 lang=csharp
 *
 * [332] Reconstruct Itinerary
 */

// @lc code=start
public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var dict = new Dictionary<string, SortedDictionary<string, int>>();

        foreach (var ticket in tickets)
        {
            if (!dict.TryGetValue(ticket[0], out SortedDictionary<string, int> sDict))
            {
                dict[ticket[0]] = sDict = new SortedDictionary<string, int>();
            }
            if (!sDict.TryGetValue(ticket[1], out int count))
            {
                sDict[ticket[1]] = count = 0;
            }
            sDict[ticket[1]] = count + 1;
        }

        var result = new List<string>(tickets.Count);

        void Dfs(string airport)
        {
            if (dict.ContainsKey(airport))
            {
                while (dict[airport].Count > 0)
                {
                    var next = dict[airport].Keys.First();
                    dict[airport][next]--;
                    if (dict[airport][next] == 0)
                    {
                        dict[airport].Remove(next);
                    }
                    Dfs(next);
                }
            }
            result.Add(airport);
        }

        Dfs("JFK");
        
        result.Reverse();
        return result;
    }
}
// @lc code=end

