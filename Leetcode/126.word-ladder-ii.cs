/*
 * @lc app=leetcode id=126 lang=csharp
 *
 * [126] Word Ladder II
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        var result = new List<IList<string>>();
        var wordSet = new HashSet<string>(wordList);
        
        if (!wordSet.Contains(endWord))
            return result;
        
        var paths = new Queue<IList<string>>();
        paths.Enqueue(new List<string> { beginWord });
        var words = new HashSet<string>();
        
        int level = 1, minLevel = int.MaxValue;
        while (paths.Count > 0)
        {
            var path = paths.Dequeue();
            if (path.Count > level)
            {
                foreach (var word in words)
                    wordSet.Remove(word);
                words.Clear();
                level++;
                if (level > minLevel)
                    break;
            }
            
            var last = path[path.Count - 1];
            for (int i = 0; i < last.Length; i++)
            {
                var array = last.ToCharArray();
                for (char c = 'a'; c <= 'z'; c++)
                {
                    array[i] = c;
                    var word = new string(array);
                    if (!wordSet.Contains(word))
                        continue;
                    words.Add(word);
                    var newPath = new List<string>(path);
                    newPath.Add(word);
                    if (word == endWord)
                    {
                        minLevel = level;
                        result.Add(newPath);
                    }
                    else
                        paths.Enqueue(newPath);
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

