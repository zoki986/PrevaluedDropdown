using System;
using System.Collections.Generic;
using System.Linq;

namespace PrevalueDropdown.Extensions
{
	public static class EnumerableExtensions
	{
		public static IList<U> Each<T,U>(this IEnumerable<T> source, Func<T,U> action)
		{
			return source.Select(action).ToList();
		}
	}
}
