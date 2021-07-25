using System.Collections;

public class Solution1 {
    public int[] TwoSum(int[] nums, int target) {
        int[] sol = new int[] {0,0};       
        for(int i = 0; i < nums.Length; i++) {
            for(int j = 1 + i; j < nums.Length; j++) {
                if(nums[i] + nums[j] == target) {
                    sol[0] = i;
                    sol[1] = j;
                    return sol;
                }
            }
        }
        return sol;
    }
}

public class Solution2 {
    public int[] TwoSum(int[] nums, int target) {
        int[] sol = new int[] {0,0};       
        int adjunct;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] < target) {
                adjunct = target - nums[i];
                for(int j = 1 + i; j < nums.Length; j++) {
                    if(adjunct == nums[j]) {
                        sol[0] = i;
                        sol[1] = j;
                        return sol;
                    }   
                }        
            }
        }        
        return sol;
    }
}


public class Solution3 {
   //  public static void PrintKeysAndValues( Hashtable myHT )
   // {
   //    Console.WriteLine("\t-KEY-\t-VALUE-");
   //    foreach (DictionaryEntry de in myHT)
   //       Console.WriteLine($"\t{de.Key}:\t{de.Value}");
   //    Console.WriteLine();
   // }
    
    public int[] TwoSum(int[] nums, int target) {
        int[] sol = new int[] {0,0};
        Dictionary<int, int> dict = new Dictionary<int, int>(nums.Length);
        Hashtable hashNums = new Hashtable();

        for(int i = 0; i < nums.Length; i++) {  
            
            hashNums.Add(target - nums[i], nums[i]);
            dict.Add(target - nums[i], i);
        } 
        
    
        // PrintKeysAndValues(hashNums);

        int counter = 0;
        foreach (DictionaryEntry hn in hashNums) {
            if(hashNums.ContainsKey(hn.Value)) {
                sol[1] = nums.Length - counter;
                sol[0] = dict[(int)hn.Key];
                // break;
            }
            counter++;
        }

        return sol;    
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sol = new int[] {0,0};
        Dictionary<int, int> hashNums = new Dictionary<int, int> (nums.Length);

        for(int i = 0; i < nums.Length; i++) {  
            hashNums.Add(i, nums[i]);
        } 
        
        for(int i = 0; i < nums.Length; i++) {
            int y = target - nums[i];
            if(hashNums.ContainsValue(y)) {
                sol[1] = i;
                sol[0] = hashNums.Keys.FirstOrDefault(s => hashNums[s] == (y));
            }
        }
        return sol;    
    }
}















