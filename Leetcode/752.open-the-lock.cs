/*
 * @lc app=leetcode id=752 lang=csharp
 *
 * [752] Open the Lock
 */

// @lc code=start
public class Solution {
    public int OpenLock(string[] deadends, string target) {
        var deads = new HashSet<int>();
        foreach (var deadend in deadends)
        {
            var num = 0;
            for (int i = 0; i < 4; i++)
                num = num * 10 + (deadend[i] - '0');
            if (num == 0)
                return -1;
            deads.Add(num);
        }
        
        var t = 0;
        for (int i = 0; i < 4; i++)
            t = t * 10 + (target[i] - '0');
        if (t == 0)
            return 0;
        deads.Add(t);
        
        var queue = new Queue<int>();
        queue.Enqueue(t);
        var result = 0;
        
        while (queue.Count > 0)
        {
            result++;
            var c = queue.Count;
            while (c-- > 0)
            {
                var num = queue.Dequeue();
                for (int i = 1; i < 10_000; i *= 10)
                {
                    var digit = num / i % 10;
                    
                    // move a wheel forward
                    var n = num + (digit == 9 ? -digit : 1) * i;
                    if (n == 0)
                        return result;
                    else if (!deads.Contains(n))
                    {
                        deads.Add(n);
                        queue.Enqueue(n);
                    }
                    
                    // move a wheel backward
                    n = num + (digit == 0 ? 9 : -1) * i;
                    if (n == 0)
                        return result;
                    else if (!deads.Contains(n))
                    {
                        deads.Add(n);
                        queue.Enqueue(n);
                    }
                }
            }
        }
        
        return -1;
    }
}
// @lc code=end

