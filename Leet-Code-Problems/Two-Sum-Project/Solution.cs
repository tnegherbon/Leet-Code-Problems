using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum_Project
{
	public class Solution
	{
		public static int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = 0; j < nums.Length; j++)
				{
					if (i != j && (nums[i] + nums[j]) == target)
					{
						return new int[] { i, j };
					}

				}
			}

			return new int[] { 0, 0 };
		}
	}
}
