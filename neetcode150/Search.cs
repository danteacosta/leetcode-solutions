public class Solution {
    public int Search(int[] nums, int target) {
        int start  = 0;
        int end = nums.Length - 1;
        int mid;
         // Verificar se o elemento está fora do intervalo do array
        if (target < nums[start] || target > nums[end])
        {
            return -1;
        }
        while(start<=end){
            mid = start+(end-start)/2;
            if (nums[mid]==target){
                return mid;
            }
            else if(nums[mid]<target){
                start=mid+1;
            }
            else{
                end = mid - 1;
            }
        }


        return -1;
        
    }
}