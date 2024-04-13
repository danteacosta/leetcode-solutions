public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int complemento = target - nums[i];
            if(hashTable.ContainsKey(complemento)) {
                return new int[] { hashTable[complemento], i };
            }
            hashTable[nums[i]] = i;
            }
    return new int[] { };
    }
}