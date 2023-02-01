/*
 * @lc app=leetcode id=460 lang=csharp
 *
 * [460] LFU Cache
 */

// @lc code=start
public class LFUCache {

    Dictionary<int, int> dict;
    Dictionary<int, IList<int>> freqList;
    Dictionary<int, int> keyFreq;
    int count;
    int capacity;
    int minFreq;

    public LFUCache(int capacity) {
        dict = new Dictionary<int, int>();
        freqList = new Dictionary<int, IList<int>>();
        keyFreq = new Dictionary<int, int>();
        count = 0;
        this.capacity = capacity;
        minFreq = 0;
    }
    
    public int Get(int key) {
        if (!keyFreq.TryGetValue(key, out int freq))
        {
            return -1;
        }

        freqList[freq].Remove(key);

        freq++;
        if (!freqList.TryGetValue(freq, out IList<int> list))
        {
            freqList[freq] = list = new List<int>();
        }
        list.Add(key);
        keyFreq[key] = freq;

        if (freqList[minFreq].Count == 0)
        {
            minFreq++;
        }

        return dict[key];
    }
    
    public void Put(int key, int value) {
        if (capacity == 0)
        {
            return;
        }

        if (Get(key) > -1)
        {
            dict[key] = value;
            return;
        }

        if (count >= capacity)
        {
            var toRemove = freqList[minFreq][0];
            freqList[minFreq].RemoveAt(0);
            dict.Remove(toRemove);
            keyFreq.Remove(toRemove);
            count--;
        }

        dict[key] = value;
        if (!freqList.TryGetValue(1, out IList<int> list))
        {
            freqList[1] = list = new List<int>();
        }
        list.Add(key);
        keyFreq[key] = 1;

        minFreq = 1;
        count++;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

