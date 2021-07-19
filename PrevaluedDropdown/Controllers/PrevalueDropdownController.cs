using PrevalueDropdown.Extensions;
using System;
using System.IO;
using System.Web;
using System.Web.Http;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace PrevalueDropdown.Controllers
{
	public class PrevalueDropdownController : UmbracoApiController
	{
		[HttpGet]
		public IHttpActionResult GetPreValuesFromFile(string id)
		{
			var mediaItem = Umbraco.Media(id);

			if (mediaItem != null)
			{
				var filePath = HttpContext.Current.Server.MapPath(mediaItem.Url());

				var fileContent = File.ReadAllText(filePath).Split(new[] { '\r', '\n', }, StringSplitOptions.RemoveEmptyEntries);

				var dropdownItems = fileContent.SelectDropdownItems();

				return Ok(dropdownItems);
			}

			return Ok("");
		}
	}
}
