/*
 * @lc app=leetcode id=1948 lang=csharp
 *
 * [1948] Delete Duplicate Folders in System
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths) {
        Node root = new (string.Empty),
            current = null;
        foreach (IList<string> path in paths)
        {
            current = root;
            foreach (string folder in path)
            {
                if (!current.Nexts.ContainsKey(folder))
                {
                    current.Nexts[folder] = new Node(folder);
                }
                current = current.Nexts[folder];
            }
        }

        Dictionary<string, int> dict = new ();
        void Dfs(Node node)
        {
            if (node.Nexts.Count == 0)
            {
                node.HashValue = string.Empty;
            }
            StringBuilder sb = new ();
            foreach (KeyValuePair<string, Node> kv in node.Nexts)
            {
                Dfs(kv.Value);
                sb.Append(kv.Key)
                    .Append('(')
                    .Append(kv.Value.HashValue)
                    .Append(')');
            }
            node.HashValue = sb.ToString();
            dict.TryGetValue(node.HashValue, out int c);
            dict[node.HashValue] = c + 1;
        }

        Dfs(root);

        List<string> p = new ();
        List<IList<string>> result = new ();
        void BuildNonDuplicate(Node node)
        {
            if (node.Nexts.Count > 0 &&
                dict[node.HashValue] > 1)
            {
                return;
            }

            p.Add(node.Name);
            result.Add(new List<string> (p));
            foreach (KeyValuePair<string, Node> kv in node.Nexts)
            {
                BuildNonDuplicate(kv.Value);
            }
            p.RemoveAt(p.Count - 1);
        }
        foreach (Node n in root.Nexts.Values)
        {
            BuildNonDuplicate(n);
        }
        
        return result;
    }

    internal class Node {
        internal string Name { get; set; }
        internal string HashValue { get; set; }
        internal SortedDictionary<string, Node> Nexts { get; set; }
        
        internal Node(string name)
        {
            this.Name = name;
            this.Nexts = new ();
        }
    }
}
// @lc code=end

