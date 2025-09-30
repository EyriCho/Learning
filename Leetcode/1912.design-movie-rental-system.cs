/*
 * @lc app=leetcode id=1912 lang=csharp
 *
 * [1912] Design Movie Rental System
 */

// @lc code=start
public class MovieRentingSystem {

    Dictionary<int, SortedSet<(int, int)>> movies;

    SortedSet<(int, int, int)> rented;

    Dictionary<(int, int), int> shopMovie;

    public MovieRentingSystem(int n, int[][] entries) {
        movies = new ();
        rented = new ();
        shopMovie = new ();

        foreach (int[] entry in entries)
        {
            if (!movies.TryGetValue(entry[1], out SortedSet<(int, int)> set))
            {
                movies[entry[1]] = set = new();
            }
            set.Add((entry[2], entry[0]));
            shopMovie[(entry[0], entry[1])] = entry[2];
        }
    }
    
    public IList<int> Search(int movie) {
        IList<int> result = new List<int>();
        movies.TryGetValue(movie, out SortedSet<(int, int)> set);
        if (set == null || set.Count == 0)
        {
            return result;
        }

        foreach ((int price, int shop) in set)
        {
            result.Add(shop);
            if (result.Count == 5)
            {
                return result;
            }
        }
        return result;
    }
    
    public void Rent(int shop, int movie) {
        int price = shopMovie[(shop, movie)];
        movies.TryGetValue(movie, out SortedSet<(int, int)> set);
        set.Remove((price, shop));
        rented.Add((price, shop, movie));
    }
    
    public void Drop(int shop, int movie) {
        
        int price = shopMovie[(shop, movie)];
        rented.Remove((price, shop, movie));
        movies.TryGetValue(movie, out SortedSet<(int, int)> list);
        list.Add((price, shop));
    }
    
    public IList<IList<int>> Report() {
        IList<IList<int>> result = new List<IList<int>>();
        foreach ((int p,int s,int m) in rented)
        {
            result.Add(new List<int> { s, m });
            if (result.Count == 5)
            {
                return result;
            }
        }
        return result;
    }
}

/**
 * Your MovieRentingSystem object will be instantiated and called as such:
 * MovieRentingSystem obj = new MovieRentingSystem(n, entries);
 * IList<int> param_1 = obj.Search(movie);
 * obj.Rent(shop,movie);
 * obj.Drop(shop,movie);
 * IList<IList<int>> param_4 = obj.Report();
 */
// @lc code=end

