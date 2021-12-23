using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_Two_Sorted_Arrays_Namespace
{
	public class Median_Two_Sorted_Arrays_Solution
	{
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int[] merged = Enumerable.Concat(nums1, nums2).ToArray();
			merged = Enumerable.OrderBy(merged, num => num).ToArray();
			if (merged.Length % 2 != 0)
			{
				return merged[(merged.Length - 1) / 2];
			}
			else
			{
				int mid = merged.Length / 2;
				return (merged[mid] + merged[mid - 1]) / 2d;
			}
		}
	}
}
