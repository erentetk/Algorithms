//Input: nums = [0,1,2,2,3,3,4,4]
           
public class Solution {
   public int RemoveDuplicates(int[] nums) {
    if (nums.Length == 0) return 0;
    int i = 0; // son benzersiz elemanın indexi
    for (int j = 1; j < nums.Length; j++) {
        if (nums[j] != nums[i]) {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1; // benzersiz eleman sayısı
}
}