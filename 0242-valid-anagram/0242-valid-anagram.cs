public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] str1 = s.ToCharArray();
        char[] str2 = t.ToCharArray();

        if(str1.Length != str2.Length){
            return false;
        }
        
        Array.Sort(str1);
        Array.Sort(str2);

        for(int i = 0; i < str1.Length; i++){
            if(str1[i] != str2[i]){
                return false;
            }
        }
        return true;
    }
}