public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map[nums[i]] = 0;
            }

            map[nums[i]]++;
        }
        
        var sortedList = map.OrderByDescending(pair => pair.Value);
        var topK = sortedList.Take(k);

        return topK.Select(pair => pair.Key).ToArray();
    }
}