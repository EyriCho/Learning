/*
 * @lc app=leetcode id=936 lang=csharp
 *
 * [936] Stamping The Sequence
 */

// @lc code=start
public class Solution {
    public int[] MovesToStamp(string stamp, string target) {
        var t = target.ToCharArray();
        int last = target.Length - stamp.Length + 1;
        var stack = new Stack<int>();
        var stamped = new bool[last];
        var count = 0;
        
        (bool, int) CanStamp(int index)
        {
            int l = 0, r = stamp.Length - 1;
            while (l <= r && t[index + l] == '*')
                l++;
            while (l <= r && t[index + r] == '*')
                r--;
            
            for (int i = l; i <= r; i++)
                if (t[index + i] != stamp[i])
                    return (false, 0);
            
            for (int i = l; i <=r; i++)
                t[index + i] = '*';
            
            return (true, r - l + 1);
        }
        
        while (count < target.Length)
        {
            var c = count;
            for (int i = 0; i < last; i++)
            {
                if (stamped[i])
                    continue;
                
                var (canStamp, l) = CanStamp(i);
                if (canStamp)
                {
                    if (l <= 0)
                    {
                        stamped[i] = true;
                        continue;
                    }
                        
                    stamped[i] = true;
                    stack.Push(i);
                    c += l;
                    break;
                }
            }
            
            if (c > count)
                count = c;
            else
                return new int[0];
        }
        
        var result = new int[stack.Count];
        for (int i = 0; i < result.Length; i++)
            result[i] = stack.Pop();
        return result;
    }
}
// @lc code=end

