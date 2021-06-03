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
                i++;
            var p = path[0..i];
            
            while (i < path.Length)
            {
                i++;
                int s = i;
                while (i < path.Length && path[i] != '(')
                    i++;
                var fileName = path[s..i];
                s = ++i;
                while (i < path.Length && path[i] != ')')
                    i++;
                var content = path[s..i];
                i++;
                
                if (!dict.ContainsKey(content))
                    dict.Add(content, new List<string>());
                dict[content].Add($"{p}/{fileName}");
            }
        }
        
        var result = new List<IList<string>>();
        foreach (var set in dict)
        {
            if (set.Value.Count > 1)
                result.Add(set.Value);
        }
        return result;
    }
}
// @lc code=end

