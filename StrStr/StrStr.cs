public class Solution {
    public int StrStr(string haystack, string needle) {
        int idx = 0;

        if(needle == "")
            return 0;
        if(haystack == "")
            return -1;

        for(int i = 0; i < haystack.Length && idx < needle.Length; i++) {
            if(haystack[i] == needle[idx]) {
                idx++;
            }
            else {
                i = i - idx;
                idx = 0;
            }
            
            if(idx == needle.Length && needle.Length > 1)
                return i - idx + 1;
            else if(idx == needle.Length && needle.Length == 1)
                return i;
        }
        
        return -1;
    }
}