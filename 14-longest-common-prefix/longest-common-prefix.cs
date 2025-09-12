public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0]; // İlk kelimeyi prefix kabul et

        for (int i = 1; i < strs.Length; i++) {
            // prefix, strs[i] içinde baştan ne kadar var bak
            while (strs[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1); // 1 harf kısalt
                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }}