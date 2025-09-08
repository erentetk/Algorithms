public class Solution {
    public int MySqrt(int x) {
       
    if (x < 2) return x;

    int left = 1, right = x / 2, kok = 0;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        long sq = (long)mid * mid; // taşma olmaması için long

        if (sq == x) return mid;
        if (sq < x)
        {
            kok = mid; // geçerli aday
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return kok;
    }
}