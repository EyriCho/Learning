/*
 * @lc app=leetcode id=433 lang=csharp
 *
 * [433] Minimum Genetic Mutation
 */

// @lc code=start
public class Solution {
    public int MinMutation(string start, string end, string[] bank) {
        var set = new HashSet<string>(bank);
        if (!bank.Contains(end))
        {
            return -1;
        }
        
        var chars = new char[] {
            'A', 'C', 'G', 'T'
        };
        
        int round = 1;
        var queue = new Queue<string>();
        queue.Enqueue(start);
        
        while (queue.Count > 0)
        {
            var count = queue.Count;
            while (count-- > 0)
            {
                var str = queue.Dequeue();
                var array = str.ToCharArray();
                
                for (int i = 0; i < 8; i++)
                {
                    foreach (var c in chars)
                    {
                        if (c != str[i])
                        {
                            array[i] = c;
                            var mutation = new string(array);
                            if (set.Contains(mutation))
                            {
                                if (mutation == end)
                                {
                                    return round;
                                }
                                
                                set.Remove(mutation);
                                queue.Enqueue(mutation);
                            }
                        }
                    }
                    array[i] = str[i];
                }
            }
            round++;
        }
        
        return -1;
    }
}
// @lc code=end

