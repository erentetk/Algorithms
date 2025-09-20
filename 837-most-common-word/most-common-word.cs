using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        
            string[] words = Regex.Matches(paragraph.ToLower(), @"[a-z]+")
                      .Cast<Match>()
                      .Select(m => m.Value)
                      .ToArray();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words) 
            {
                if (!banned.Contains(word))
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    if(!wordCount.ContainsKey(word)){
                        wordCount.Add(word, 1);
                    }
                       
                }
            }
            int max = wordCount.Values.Max();
            string donecekdeger = wordCount.First(x => x.Value == max).Key;
            return donecekdeger;

    }
}