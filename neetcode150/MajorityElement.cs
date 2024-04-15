public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> counter = new Dictionary<int,int>();


        foreach(int num in nums){
            if(counter.ContainsKey(num)){
                counter[num]++;
            }
            else{
                counter[num]=1;
            }

            if(counter[num]>nums.Length/2){
                return num;
            }
        }
        return 0;
        
    }
}