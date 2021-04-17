/*
 * @lc app=leetcode id=1396 lang=csharp
 *
 * [1396] Design Underground System
 */

// @lc code=start
public class UndergroundSystem {

    public UndergroundSystem() {
        passagers = new Dictionary<int, (string, int)>();
        travelTime = new Dictionary<string, (int, int)>();
    }
    
    Dictionary<int, (string, int)> passagers;
    Dictionary<string, (int, int)> travelTime;
    
    public void CheckIn(int id, string stationName, int t) {
        passagers.Add(id, (stationName, t));
    }
    
    public void CheckOut(int id, string stationName, int t) {
        var (startStation, startTime) = passagers[id];
        passagers.Remove(id);
        var startEnd = $"{startStation}-{stationName}";
        if (!travelTime.ContainsKey(startEnd))
            travelTime.Add(startEnd, (0, 0));
        var (time, count) = travelTime[startEnd];
        time += t - startTime;
        count++;
        travelTime[startEnd] = (time, count);
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        var startEnd = $"{startStation}-{endStation}";
        var (time, count) = travelTime[startEnd];
        return (double)time / count;
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */
// @lc code=end

