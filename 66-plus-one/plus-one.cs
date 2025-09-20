public class Solution {
    public int[] PlusOne(int[] digits) {
         int n = digits.Length;
        int carry = 1; 
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] == 9 && carry == 1) {
                digits[i] = 0;
               
            }
            else {
                digits[i] += carry;
                carry = 0;
                break;
            }
        }

        
        if (carry == 1) {
            int[] result = new int[n + 1];
            result[0] = 1;
            return result;
        }

        return digits;
    }
    }
