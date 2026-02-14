public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int x = nums[i]; 
            int need = target - x;

            if(map.ContainsKey(need)){
                return new int[] {map[need], i};
            }
            
            map[x] = i;
        }
        return new int[] {};
    }
}