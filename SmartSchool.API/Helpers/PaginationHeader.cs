namespace SmartSchool.API.Helpers
{
	public class PaginationHeader
	{
		public int CurrentPage { get; set; }
		public int ItemsPerPage { get; set; }
		public int TotalItems { get; set; }
		public int TotaPages { get; set; }

		public PaginationHeader(int currentPage, int itemsPerPage, int totalItems, int totaPages)
		{
			CurrentPage = currentPage;
			ItemsPerPage = itemsPerPage;
			TotalItems = totalItems;
			TotaPages = totaPages;
		}
	}
}
