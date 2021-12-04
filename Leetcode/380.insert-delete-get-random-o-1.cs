/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet {

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (dict.ContainsKey(val))
            return false;
        
        dict.Add(val, list.Count);
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (dict.ContainsKey(val))
        {
            var lastPos = list.Count - 1;
            
            if (dict[val] < lastPos)
            {
                dict[list[lastPos]] = dict[val];
                list[dict[val]] ^= list[lastPos];
                list[lastPos] ^= list[dict[val]];
                list[dict[val]] ^= list[lastPos];
            }
            
            dict.Remove(val);
            list.RemoveAt(lastPos);
            return true;
        }
        else
            return false;
    }
    
    public int GetRandom() {
        return list[(random.Next(list.Count))];
    }
    
    Dictionary<int, int> dict;
    List<int> list;
    Random random;
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

