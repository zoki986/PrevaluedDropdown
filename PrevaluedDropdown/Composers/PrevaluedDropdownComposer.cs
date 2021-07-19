using PrevalueDropdown.Components;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace PrevalueDropdown.Composers
{
	[RuntimeLevel(MinLevel = RuntimeLevel.Run)]
	public class PrevaluedDropdownComposer : IUserComposer
	{
		public void Compose(Composition composition)
		{
			composition.Components().Append<PrevaluedDropdownComponent>();
		}
	}
}
