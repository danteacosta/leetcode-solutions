public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int start = 1;
        int end =  n;
         while (start < end) {
            int mid = (start + end) / 2;
            bool isBad = IsBadVersion(mid);
            if (isBad) {
                end = mid;
            }
            else {
                start = mid + 1;
            }
        }
        return start;
    }
}