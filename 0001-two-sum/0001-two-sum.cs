public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            var need = target - nums[i];
            if(map.ContainsKey(need)){
                return new int[] {map[need], i};
            }
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}