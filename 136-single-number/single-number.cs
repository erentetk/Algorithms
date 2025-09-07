public class Solution {
    public int SingleNumber(int[] nums) {
        int e=0;
        for(int i=0;i<nums.Length;i++)
        e=e^nums[i];
        return e;
    }
}