public class Solution {
    
    public int Reverse(int x) {
        string s = x.ToString();
        int invX;
        StringBuilder sb = new StringBuilder("", s.Length);
        
        for(int i = 0; i < s.Length; i++)
            sb.Append(s[s.Length - i - 1]);
       
        if(sb[0] == '0' && sb.Length > 1)
            sb.Remove(0, 1);
        
        if(sb[sb.Length - 1] == '-') {
            sb.Remove(sb.Length - 1, 1);
            sb.Insert(0, "-", 1);
        }
            
        string invS = sb.ToString();

        bool success = int.TryParse(invS, out invX);
        if(success)
            return invX;
        else
            return 0;
    }
}