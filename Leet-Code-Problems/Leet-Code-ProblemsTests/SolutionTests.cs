using Median_Two_Sorted_Arrays_Namespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regular_Expression_Matching_Namespace;
using System.Linq;
using Two_Sum_Namespace;

namespace Leet_Code_Problems.Tests
{
	[TestClass()]
	public class SolutionTests
	{
		[TestMethod()]
		public void TwoSum6Test()
		{
			var nums = new int[] { 3, 2, 4 };
			var expected = new int[] { 1, 2 };
			Assert.IsTrue(Enumerable.SequenceEqual(Two_Sum_Solution.TwoSum(nums, 6), expected));
		}

		[TestMethod()]
		public void TwoSum10Test()
		{
			var nums = new int[] { 3, 2, 4, 5, 9, 1, 8 };
			var expected = new int[] { 1, 6 };
			Assert.IsTrue(Enumerable.SequenceEqual(Two_Sum_Solution.TwoSum(nums, 10), expected));
		}

		[TestMethod()]
		public void TwoSumInexistentTest()
		{
			var nums = new int[] { 3, 2, 4, 5, 9, 1, 8 };
			var expected = new int[] { 0, 0 };
			Assert.IsTrue(Enumerable.SequenceEqual(Two_Sum_Solution.TwoSum(nums, 31), expected));
		}

		[TestMethod()]
		public void RegexNotMatchingTest()
		{
			var input = "aa";
			var pattern = "a";
			Assert.IsFalse(Regular_Expression_Matching_Solution.IsMatch(input, pattern));
		}

		[TestMethod()]
		public void RegexMatchingWildcardTest()
		{
			var input = "aa";
			var pattern = "a*";
			Assert.IsTrue(Regular_Expression_Matching_Solution.IsMatch(input, pattern));
		}

		[TestMethod()]
		public void RegexMatchingAnyTest()
		{
			var input = "ab";
			var pattern = ".*";
			Assert.IsTrue(Regular_Expression_Matching_Solution.IsMatch(input, pattern));
		}

		/// <summary>
		/// [1, 2, 3, 4, 5, 6, 7, 8, 9]
		/// </summary>
		[TestMethod()]
		public void MedianTwoSortedOdd5Test()
		{
			var nums1 = new int[] { 1, 5, 7, 8 };
			var nums2 = new int[] { 2, 3, 4, 6, 9 };
			Assert.AreEqual(Median_Two_Sorted_Arrays_Solution.FindMedianSortedArrays(nums1, nums2), 5);
		}

		/// <summary>
		/// [2, 4, 5]
		/// </summary>
		[TestMethod()]
		public void MedianTwoSortedOdd4Test()
		{
			var nums1 = new int[] { 4 };
			var nums2 = new int[] { 2, 5 };
			Assert.AreEqual(Median_Two_Sorted_Arrays_Solution.FindMedianSortedArrays(nums1, nums2), 4);
		}

		/// <summary>
		/// [1, 2, 3, 4, 9, 9]
		/// </summary>
		[TestMethod()]
		public void MedianTwoSortedEven3dot5Test()
		{
			var nums1 = new int[] { 1, 3, 9 };
			var nums2 = new int[] { 2, 4, 9 };
			Assert.AreEqual(Median_Two_Sorted_Arrays_Solution.FindMedianSortedArrays(nums1, nums2), 3.5);
		}

		/// <summary>
		/// [2, 3, 4, 4, 8, 9, 12, 13]
		/// </summary>
		[TestMethod()]
		public void MedianTwoSortedEven6Test()
		{
			var nums1 = new int[] { 4, 9, 12 };
			var nums2 = new int[] { 2, 3, 4, 8, 13 };
			Assert.AreEqual(Median_Two_Sorted_Arrays_Solution.FindMedianSortedArrays(nums1, nums2), 6);
		}
	}
}