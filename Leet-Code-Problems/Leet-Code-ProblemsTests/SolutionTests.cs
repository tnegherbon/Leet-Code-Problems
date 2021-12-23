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
	}
}