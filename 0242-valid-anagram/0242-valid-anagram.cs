public class Solution {
    public bool IsAnagram(string s, string t) {
        var map1 = new Dictionary<char, int>();
        var map2 = new Dictionary<char, int>();

        if(s.Length != t.Length){
            return false;
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i]; 

   
            if (!map1.ContainsKey(c))
                map1[c] = 0;


            map1[c]++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            char c = t[i];

            if (!map2.ContainsKey(c))
                map2[c] = 0;

            map2[c]++;
        }

        if (map1.Count != map2.Count)
            return false;

        foreach (var pair in map1)
        {
            char key = pair.Key;     
            int value = pair.Value;  


            if (!map2.ContainsKey(key))
                return false;


            if (map2[key] != value)
                return false;
        }

        return true;

    }
}