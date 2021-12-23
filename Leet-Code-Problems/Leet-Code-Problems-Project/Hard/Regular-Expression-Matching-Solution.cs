using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression_Matching_Namespace
{
	public class Regular_Expression_Matching_Solution
	{
		public static bool IsMatch(string s, string p)
		{
			return Regex.IsMatch(s, $"^{p}$");
		}
	}
}
