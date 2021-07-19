using Newtonsoft.Json;

namespace PrevalueDropdown.Models
{
	public class DropdownItem
	{
		[JsonProperty("value")]
		public string Value { get; set; }
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}
