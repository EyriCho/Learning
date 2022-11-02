/*
 * @lc app=leetcode id=981 lang=csharp
 *
 * [981] Time Based Key-Value Store
 */

// @lc code=start
public class TimeMap {

    Dictionary<string, List<(int, string)>> dict;
    
    public TimeMap() {
        dict = new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!dict.TryGetValue(key, out List<(int, string)> list))
        {
            dict[key] = list = new List<(int, string)>();
        }
        
        list.Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!dict.TryGetValue(key, out List<(int, string)> list))
        {
            return string.Empty;
        }
        
        int l = 0, r = list.Count - 1;
        while (l <= r)
        {
            int mid = (r - l) / 2 + l;
            
            if (list[mid].Item1 == timestamp)
            {
                return list[mid].Item2;
            }
            else if (list[mid].Item1 < timestamp)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        if (list.Count != 0 && r >= 0 && r < list.Count)
        {
            return list[r].Item2;
        }

        return string.Empty;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
// @lc code=end

