using PrevalueDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrevalueDropdown.Extensions
{
	public static class StringExtensions
	{
		public static List<DropdownItem> SelectDropdownItems(this string[] source)
		{
			return source.Select(x =>
			{
				var value = x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Each(v => v.Trim());

				return new DropdownItem { Value = value.First(), Text = value.Last() };
			})
			.ToList();
		}
	}
}
