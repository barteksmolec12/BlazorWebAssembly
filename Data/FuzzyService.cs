using System.Linq;
using System.Threading.Tasks;
using System;
using FuzzySharp;

namespace BlazorWebAssembly.Data
{
    public class FuzzyService
    {
		public Task<int> GetScore(string value1, string value2)
		{
			return Task.FromResult(Fuzz.Ratio(value1, value2));
		}
	}
}
