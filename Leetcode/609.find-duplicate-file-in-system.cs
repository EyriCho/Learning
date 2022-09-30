/*
 * @lc app=leetcode id=609 lang=csharp
 *
 * [609] Find Duplicate File in System
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
        var dict = new Dictionary<string, IList<string>>();
        
        foreach (var path in paths)
        {
            int i = 0;
            while (i < path.Length && path[i] != ' ')
            {
                i++;
            }
            var d = path[0..i];
            
            while (i < path.Length)
            {
                i++;
                int s = i;
                while (i < path.Length && path[i] != '(')
                {
                    i++;
                }
                
                var filename = path[s..i];
                
                s = ++i;
                while (i < path.Length && path[i] != ')')
                {
                    i++;
                }
                var content = path[s..i];
                i++;
                
                if (!dict.TryGetValue(content, out IList<string> p))
                {
                    dict[content] = p = new List<string>();
                }
                p.Add($"{d}/{filename}");
            }
        }
        
        return dict
            .Where(kv => kv.Value.Count > 1)
            .Select(kv => kv.Value)
            .ToList();
    }
}
// @lc code=end

