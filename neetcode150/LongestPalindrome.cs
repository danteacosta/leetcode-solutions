public class Solution {
    public int LongestPalindrome(string s) {
        
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        
        foreach (char c in s) {
            if (!frequency.ContainsKey(c)) {
                frequency[c] = 1;
            } else {
                frequency[c]++;
            }
        }
        
        int palindromeSize = 0;
        bool containsOdd = false;
        
        foreach (int freq in frequency.Values) {
            if (freq % 2 == 0) {
                //palindromo é feito por pares
                palindromeSize += freq;
            } else {
                palindromeSize += freq - 1;
                containsOdd = true;
            }
        }
        //se tiver frequencia impar, o palindromo seria a somatoria com os pares e o char do meio
        return containsOdd ? palindromeSize + 1 : palindromeSize;
    }
    
}