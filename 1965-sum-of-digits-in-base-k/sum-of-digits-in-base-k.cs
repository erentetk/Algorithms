public class Solution {
    public int SumBase(int n, int k) {
           int toplam = 0;
   while (n > 0)
   {
       toplam += n % k; 
       n /= k;          
   }
   return toplam;
    }
}