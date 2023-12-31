/*
 * @lc app=leetcode id=1436 lang=csharp
 *
 * [1436] Destination City
 */

// @lc code=start
public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> derived = new ();
        foreach (IList<string> path in paths)
        {
            derived.Add(path[0]);
        }

        foreach (IList<string> path in paths)
        {
            if (!derived.Contains(path[1]))
            {
                return path[1];
            }
        }

        return string.Empty;
    }
}
// @lc code=end

