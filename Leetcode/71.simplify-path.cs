/*
 * @lc app=leetcode id=71 lang=csharp
 *
 * [71] Simplify Path
 */

// @lc code=start
public class Solution {
    public string SimplifyPath(string path) {
        var list = new List<string>();
        int last = 0; // last non-slash character index
        int count = 0; // period count
        
        void FoundPath(int s, int e)
        {
            if (count == e - s)
            {
                if (count > 2)
                    list.Add(path[s..e]);
                else if (count == 2 && list.Count > 0)
                    list.RemoveAt(list.Count - 1);
            }
            else
            {
                list.Add(path[s..e]);
            }
        }
        
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == '.')
                count++;
            
            if (path[i] == '/')
            {
                if (i > last)
                {
                    FoundPath(last, i);
                }
                last = i + 1;
                count = 0;
            }
            else if (i == path.Length - 1)
                FoundPath(last, path.Length);
        }
        
        return $"/{string.Join('/', list)}";
    }
}
// @lc code=end

