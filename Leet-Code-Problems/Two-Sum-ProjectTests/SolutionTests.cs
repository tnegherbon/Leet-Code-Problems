using Microsoft.VisualStudio.TestTools.UnitTesting;
using Two_Sum_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum_Project.Tests
{
	[TestClass()]
	public class SolutionTests
	{
		[TestMethod()]
		public void TwoSum6Test()
		{
			var nums = new int[] { 3, 2, 4 };
			var expected = new int[] { 1, 2 };
			Assert.IsTrue(Enumerable.SequenceEqual(Solution.TwoSum(nums, 6), expected));
		}

		[TestMethod()]
		public void TwoSum10Test()
		{
			var nums = new int[] { 3, 2, 4, 5, 9, 1, 8 };
			var expected = new int[] { 1, 6 };
			Assert.IsTrue(Enumerable.SequenceEqual(Solution.TwoSum(nums, 10), expected));
		}

		[TestMethod()]
		public void TwoSumInexistentTest()
		{
			var nums = new int[] { 3, 2, 4, 5, 9, 1, 8 };
			var expected = new int[] { 0, 0 };
			Assert.IsTrue(Enumerable.SequenceEqual(Solution.TwoSum(nums, 31), expected));
		}
	}
}