// See https://aka.ms/new-console-template for more information
using Two_Sum_Project;

var nums = new int[] { 3, 2, 4 };
var expected = new int[] { 1, 2 };
var indices = Solution.TwoSum(nums, 6);
Console.WriteLine($"index1 = {indices[0]}; index2 = {indices[1]}");