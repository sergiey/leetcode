public class Solution {
    public IList<int> GrayCode(int n)
    {
        IList<int> list = new List<int>();
        int line = n;
        int column = (int)Math.Pow(2, n);
        bool[,] arr = new bool[column, line];
        StringBuilder sb = new StringBuilder("", line);
        string byteCode;

        for (int j = 0; j < line; j++)
        {
            int firstZero = (int)Math.Pow(2, j);
            int numberOfValues = (int)Math.Pow(2, j + 1);
            int counter = numberOfValues;
            bool bitValue = true;

            for (int i = 0; i < column; i++)
            {
                if (firstZero == 0)
                {
                    arr[i, j] = bitValue;
                    counter--;
                }

                if (counter == 0)
                {
                    bitValue = !bitValue;
                    counter = numberOfValues;
                }

                if (firstZero > 0)
                {
                    arr[i, j] = false;
                    firstZero--;
                }
            }
        }

        for(int i = 0; i < column; i++) {
            for(int j = 0; j < line; j++) {
                if(arr[i, j])
                    sb.Insert(0, '1');
                else
                    sb.Insert(0, '0');
            }
            byteCode = sb.ToString();
            sb.Clear();
            list.Add(Convert.ToInt32(byteCode, 2));
        }

        return list;
    }
}