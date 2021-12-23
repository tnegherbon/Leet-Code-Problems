// See https://aka.ms/new-console-template for more information

using Median_Two_Sorted_Arrays_Namespace;
using Regular_Expression_Matching_Namespace;
using Two_Sum_Namespace;

var nums = new int[] { 3, 2, 4 };
var expected = new int[] { 1, 2 };
var indices = Two_Sum_Solution.TwoSum(nums, 6);
Console.WriteLine($"index1 = {indices[0]}; index2 = {indices[1]}");

var input = "aa";
var pattern = "a";

Console.WriteLine($"input = {input}; pattern = {pattern}; result = {Regular_Expression_Matching_Solution.IsMatch(input, pattern)}");

var nums1 = new int[] { 1, 4, 5, 7, 8 };
var nums2 = new int[] { 2, 3, 4, 6, 9 };
Console.WriteLine($"median = {Median_Two_Sorted_Arrays_Solution.FindMedianSortedArrays(nums1, nums2)}");