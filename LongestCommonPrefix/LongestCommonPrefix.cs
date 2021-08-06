public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder("");

        for(int i = 0; i < strs[0].Length; i++)
        {
            for(int j = 1; j < strs.Length; j++) 
            {
                try
                {
                    if(strs[0][i] != strs[j][i]) 
                        return sb.ToString();
                }
                catch
                {
                    return sb.ToString();
                }
            }
            sb.Append(strs[0][i]);
        } 
        return sb.ToString();       
    }
}