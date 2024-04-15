public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        while (i<j){
            int soma = numbers[i] + numbers[j];
            if (soma == target){
                return [i+1,j+1];
            }
            if (soma> target){
                j=j-1;
            }
            else{
                i=i+1;
            }
                
        };
        return[];


        
    }
}