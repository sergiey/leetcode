public class Solution {
    public bool IsPalindrome(int x) {
       string s = x.ToString();
       for(int i = 0, int j = s.Length - 1; i != j && i < j; i++, j--)
       {
            if(s[i] != s[j])
                return false;
       }
       return true;
    }
} 