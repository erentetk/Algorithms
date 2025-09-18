public class Solution {
       public  string AddStrings(string sayi1, string sayi2)
    {
        var result = new StringBuilder();
        int i = sayi1.Length - 1;
        int j = sayi2.Length - 1;
        int carry = 0; // Elde var

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = i >= 0 ? sayi1[i] - '0' : 0;
            int digit2 = j >= 0 ? sayi2[j] - '0' : 0;

            int sum = digit1 + digit2 + carry;
            carry = sum / 10;

            result.Insert(0, sum % 10);

            i--;
            j--;
        }
        return result.ToString();
    }
}