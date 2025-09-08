public class Solution {
    public int TitleToNumber(string columnTitle) {
  
int result = 0;
    for (int i = 0; i < columnTitle.Length; i++)
    {
        // Her harfi sayıya çeviriyoruz: 'A' = 1, 'B' = 2, ..., 'Z' = 26
        int value = columnTitle[i] - 'A' + 1;
        result = result * 26 + value;
    }
    return result;
    }
    }
