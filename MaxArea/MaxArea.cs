public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int idxArea = 0;

        for (int i = 0; i < height.Length; i++) {
            int leftIdxArea = 0;
            int rightIdxArea = 0;

            for (int j = i - 1; j >= 0; j--) {
                    if (height[j] >= height[i])
                        leftIdxArea = height[i] * (i - j);
            }

            for (int j = i + 1; j < height.Length; j++) {
                if (height[j] >= height[i])
                    rightIdxArea = height[i] * (j - i);
            }
            idxArea = (leftIdxArea > rightIdxArea) ? leftIdxArea : rightIdxArea;
            maxArea = idxArea > maxArea ? idxArea : maxArea;
        }
        return maxArea;
    }
}