public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var map = new Dictionary<int,int>();

        foreach(int i in nums){
            if(map.ContainsKey(i)){
                return true;
            }

            map[i] = 1;
        }
        return false;
    }
}