namespace LeetCode.Impl;

public class MedianSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var list = Merge(nums1, nums2); // nums1.Concat(nums2).OrderBy(x => x).ToArray();
        var len = list.Length;
        if (len % 2 == 1) //uneven
        {
            //[1,2,3,4,5] => medianIdx = len+1/2
            int medianIdx = (len - 1) / 2;
            double d = list[medianIdx];
            return d;
        }
        else
        {
            // [1,1,1,2] => idx = len/2-1, len/2  1,2. 1,2
            int medianIdx = len / 2; //2
            double d = list[medianIdx - 1] + list[medianIdx];
            return d / 2.0;
        }
    }

    private static int[] Merge(int[] a1, int[] a2)
    {
        int a1len = a1.Length;
        int a2len = a2.Length;
        int totallength = a1len + a2len;
        var result = new int[totallength];
        int idx1 = 0, idx2 = 0;
        for (int i = 0; i < totallength; i++)
        {
            if (idx1 >= a1len)
            {
                result[i] = a2[idx2];
                idx2++;
            }
            else if (idx2 >= a2len)
            {
                result[i] = a1[idx1];
                idx1++;
            }
            else
            {
                if (a1[idx1] <= a2[idx2])
                {
                    result[i] = a1[idx1];
                    idx1++;
                }
                else
                {
                    result[i] = a2[idx2];
                    idx2++;
                }

            }
        }
        return result;
    }
}
