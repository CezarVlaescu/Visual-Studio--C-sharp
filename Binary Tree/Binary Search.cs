public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0; // first index
        int right = nums.Length - 1; 

        while (left <= right)  
        {
            int mid = (left + right) / 2;  
            if (nums[mid] == target) 
            {
                return mid;
            }
            if (nums[mid] > target)
            {
                right = mid - 1; 
            }
            else
            {
                left = mid + 1; 
            }
        }
        return -1;  
    }
}
