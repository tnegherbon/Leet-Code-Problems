using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum_Project
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int index1 = 0, index2 = 1;

            foreach (int number in nums)
            {
                if (index2 <= nums.Count())
                {
                    if ((nums[index1] + nums[index2]) == target)
                    {
                        break;
                    }
                    else
                    {
                        index1++;
                        index2++;
                    }
                }
            }

            return new int[] { index1, index2 };
        }
    }
}
