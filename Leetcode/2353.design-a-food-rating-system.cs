/*
 * @lc app=leetcode id=2353 lang=csharp
 *
 * [2353] Design a Food Rating System
 */

// @lc code=start
public class FoodRatings {

    Dictionary<string, PriorityQueue<(string, int), (string, int)>> cuisineDict;
    Dictionary<string, (int, string)> foodDict;

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        cuisineDict = new ();
        foodDict = new ();

        for (int i = 0; i < foods.Length; i++)
        {
            foodDict[foods[i]] = (ratings[i], cuisines[i]);
            if (!cuisineDict.TryGetValue(cuisines[i], out PriorityQueue<(string, int), (string, int)> queue))
            {
                queue = cuisineDict[cuisines[i]] = new (Comparer<(string food, int rate)>.Create((a, b) => 
                    a.rate.Equals(b.rate) ? a.food.CompareTo(b.food) : b.rate.CompareTo(a.rate)));
            }
            queue.Enqueue((foods[i], ratings[i]), (foods[i], ratings[i]));
        }
    }
    
    public void ChangeRating(string food, int newRating) {
        string cuisine = foodDict[food].Item2;
        foodDict[food] = (newRating, cuisine);
        cuisineDict.TryGetValue(cuisine, out PriorityQueue<(string, int), (string, int)> queue);
        queue.Enqueue((food, newRating), (food, newRating));
    }
    
    public string HighestRated(string cuisine) {
        cuisineDict.TryGetValue(cuisine, out PriorityQueue<(string, int), (string, int)> queue);
        string food = null;
        int rate = 0;
        (food, rate) = queue.Peek();
        while (foodDict[food].Item1 != rate)
        {
            queue.Dequeue();
            (food, rate) = queue.Peek();
        }
        return food;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */
// @lc code=end

