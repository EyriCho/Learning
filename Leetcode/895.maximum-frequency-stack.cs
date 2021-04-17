/*
 * @lc app=leetcode id=895 lang=csharp
 *
 * [895] Maximum Frequency Stack
 */

// @lc code=start
public class FreqStack {

    public FreqStack() {
        freq = new Dictionary<int, int>();
        occur = new Dictionary<int, Stack<int>>();
    }
    
    Dictionary<int, int> freq;
    Dictionary<int, Stack<int>> occur;
    
    public void Push(int x) {
        if (!freq.ContainsKey(x))
            freq.Add(x, 1);
        else
            freq[x]++;
        
        if (!occur.ContainsKey(freq[x]))
            occur.Add(freq[x], new Stack<int>());
        
        occur[freq[x]].Push(x);
    }
    
    public int Pop() {
        var result = occur[occur.Count].Pop();
        if (occur[occur.Count].Count == 0)
            occur.Remove(occur.Count);
        
        freq[result]--;
        
        return result;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 */
// @lc code=end

