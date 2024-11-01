/*
 * @lc app=leetcode id=1233 lang=csharp
 *
 * [1233] Remove Sub-Folders from the Filesystem
 */

// @lc code=start
public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder);

        List<string> result = new ();

        foreach (string f in folder)
        {
            if (result.Count == 0 ||
                !f.StartsWith($"{result[result.Count - 1]}/"))
            {
                result.Add(f);
            }
        }

        return result;        
    }
}
// @lc code=end

