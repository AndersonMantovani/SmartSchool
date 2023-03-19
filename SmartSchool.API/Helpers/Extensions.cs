using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SmartSchool.API.Helpers
{
	public static class Extensions
	{
        public static void AddPagination(this HttpResponse response, int CurrentPage, int ItemsPerPage, int TotalItems, int TotaPages)
		{
			var paginationHeader = new PaginationHeader(CurrentPage, ItemsPerPage, TotalItems, TotaPages);
			var camelCaseFormatter = new JsonSerializerSettings();

			camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

			response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
			response.Headers.Add("Access-Control-Expose-Header", "Pagination");
		}
	}
}
