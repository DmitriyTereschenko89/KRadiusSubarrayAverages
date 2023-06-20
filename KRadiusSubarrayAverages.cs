using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRadiusSubarrayAverages
{
	internal class KRadiusSubarrayAverages
	{
		public int[] GetAverages(int[] nums, int k)
		{
			int n = nums.Length;
			int[] averages = new int[n];
			Array.Fill(averages, -1);
			int slidingWindowSum = 0;
			int slidingWindowLength = k * 2 + 1;
			if (slidingWindowLength > n)
			{
				return averages;
			}
			for (int i = 0; i < slidingWindowLength; ++i)
			{
				slidingWindowSum += nums[i];
			}
			averages[k] = slidingWindowSum / slidingWindowLength;
			for (int i = slidingWindowLength; i < n; ++i)
			{
				slidingWindowSum = slidingWindowSum - nums[i - slidingWindowLength] + nums[i];
				averages[i - k] = slidingWindowSum / slidingWindowLength;
			}
			return averages;
		}
	}
}
