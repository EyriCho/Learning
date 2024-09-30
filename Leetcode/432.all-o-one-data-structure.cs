/*
 * @lc app=leetcode id=432 lang=csharp
 *
 * [432] All O`one Data Structure
 */

// @lc code=start
public class AllOne {

    Dictionary<string, int> counts;

    SortedDictionary<int, HashSet<string>> dict;

    public AllOne() {
        counts = new ();
        dict = new ();
    }
    
    public void Inc(string key) {
        counts.TryGetValue(key, out int count);
        if (count > 0)
        {
            dict[count].Remove(key);
            if (dict[count].Count == 0)
            {
                dict.Remove(count);
            }
        }
        counts[key] = ++count;
        if (!dict.TryGetValue(count, out HashSet<string> set))
        {
            dict[count] = set = new ();
        }
        set.Add(key);
    }
    
    public void Dec(string key) {
        counts.TryGetValue(key, out int count);
        dict.TryGetValue(count, out HashSet<string> set);
        set.Remove(key);
        if (set.Count == 0)
        {
            dict.Remove(count);
        }

        counts[key] = --count;
        if (count == 0)
        {
            counts.Remove(key);
        }
        else
        {
            if (!dict.TryGetValue(count, out set))
            {
                dict[count] = set = new ();
            }
            set.Add(key);
        }
    }
    
    public string GetMaxKey() {
        if (counts.Count == 0)
        {
            return string.Empty;
        }

        return dict[dict.Keys.Max()].First();
    }
    
    public string GetMinKey() {
        if (counts.Count == 0)
        {
            return string.Empty;
        }
        
        return dict[dict.Keys.Min()].First();
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */
// @lc code=end

