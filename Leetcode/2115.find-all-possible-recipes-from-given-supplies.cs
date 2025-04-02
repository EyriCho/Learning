/*
 * @lc app=leetcode id=2115 lang=csharp
 *
 * [2115] Find All Possible Recipes from Given Supplies
 */

// @lc code=start
public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        List<string> result = new ();
        int[] counts = new int[recipes.Length];
        Dictionary<string, IList<int>> iTor = new ();
        IList<int> list = null;
        for (int i = 0; i < recipes.Length; i++)
        {
            foreach (string ingre in ingredients[i])
            {
                if (!iTor.TryGetValue(ingre, out list))
                {
                    iTor[ingre] = list = new List<int>();
                }
                list.Add(i);
            }
        }

        Queue<int> queue = new ();
        foreach (string s in supplies)
        {
            if (!iTor.TryGetValue(s, out list))
            {
                continue;
            }

            foreach (int r in list)
            {
                counts[r]++;
                if (counts[r] == ingredients[r].Count)
                {
                    queue.Enqueue(r);
                }
            }
        }

        int recipe = 0;
        while (queue.Count > 0)
        {
            recipe = queue.Dequeue();
            result.Add(recipes[recipe]);
            if (!iTor.TryGetValue(recipes[recipe], out list))
            {
                continue;
            }
            foreach (int r in list)
            {
                counts[r]++;
                if (counts[r] == ingredients[r].Count)
                {
                    queue.Enqueue(r);
                }
            }
        }
        return result;
    }
}
// @lc code=end

