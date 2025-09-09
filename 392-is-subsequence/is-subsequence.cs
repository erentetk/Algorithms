public class Solution {
    public bool IsSubsequence(string s, string t) {
            int i = 0;
        int j = 0;
        string tempStr = "";
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                tempStr += s[i];
                i++;
            }
            j++;
        }
        if (tempStr == s)
        {
            return true;
        }
        return false;
    }
}