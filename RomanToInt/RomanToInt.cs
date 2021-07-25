public class Solution {
    static bool isSubtractive(int number1, int number2) {
        return number1 < number2;
    }
    
    public int RomanToInt(string s)
    {
        char[] romanNumberArray = s.ToCharArray();

        var romanArabicDictionary = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        int arabicNumber = 0;

        for (int i = 0; i < romanNumberArray.Length; i++)
        {
            if (i + 1 < romanNumberArray.Length
                && isSubtractive(romanArabicDictionary[romanNumberArray[i]],
                romanArabicDictionary[romanNumberArray[i + 1]])) {
                arabicNumber -= romanArabicDictionary[romanNumberArray[i]];
            }
            else 
                arabicNumber += romanArabicDictionary[romanNumberArray[i]];
        }

        return arabicNumber;
    }
}