public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        int[]counterS = new int[26];
        int[]counterT = new int[26];
        for(int i =0;i<s.Length;i++){
            counterS[s[i] - 'a']++;
            counterT[t[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (counterS[i] != counterT[i])
            {
                return false;
            }
        }

        return true;
        }

    }