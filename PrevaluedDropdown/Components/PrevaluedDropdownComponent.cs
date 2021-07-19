using System.Collections.Generic;
using Umbraco.Core.Composing;
using Umbraco.Web.JavaScript;

namespace PrevalueDropdown.Components
{
	public class PrevaluedDropdownComponent : IComponent
	{
		private const string PrevaluedDropdown = "PrevaluedDropdown";
		private const string ApiUrl = "/umbraco/api/PrevalueDropdown/GetPreValuesFromFile/?id=";

		public void Initialize()
		{
			ServerVariablesParser.Parsing += ServerVariablesParser_Parsing;
		}

		private void ServerVariablesParser_Parsing(object sender, Dictionary<string, object> e)
		{
			e.Add(PrevaluedDropdown, new Dictionary<string, object> { { "ApiUrl", ApiUrl } });
		}

		public void Terminate()
		{
		}
	}
}
