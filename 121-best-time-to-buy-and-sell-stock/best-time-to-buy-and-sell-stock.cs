public class Solution {
    public int MaxProfit(int[] prices) {
        // Kenar durum kontrolü: Dizi boşsa veya alım-satım için yeterli gün yoksa (1 günden az),
        // kâr 0'dır.
        if (prices == null || prices.Length < 2) {
            return 0;
        }

        int minPrice = prices[0];
        int maxProfit = 0;

        // Döngüyü 1. indeksten başlatmak daha verimli olacaktır,
        // çünkü 0. indeksi zaten minPrice olarak atadık.
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            } else {
                // Mevcut fiyattan satarsak elde edeceğimiz kârı hesapla
                // ve şu ana kadarki maksimum kârdan büyükse güncelle.
                int currentProfit = prices[i] - minPrice;
                if (currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}