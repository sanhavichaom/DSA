public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string word in strs){   //คำทั้งหมด ใน Array ->> 'tan'
            char[] chars = word.ToCharArray(); // แปลงเป็น char และเก็บใน chars[] ->> 't','a','n'

            Array.Sort(chars); // เรียงตัวอักษร ยกตัวอย่าง tan ->> 'a','n','t'

            string key = new string(chars); // แปลงคำกลับเป็น string key 'ant'

            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }
        return new List<IList<string>>(map.Values);
    }
}