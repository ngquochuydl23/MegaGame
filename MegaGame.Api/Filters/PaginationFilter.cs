namespace MegaGame.Api.Filters
{
	public class PaginationFilter
	{
		public int Limit { get; set; }

		public int Offset { get; set; }

		public PaginationFilter()
		{
			Offset = 0;
			Limit = 10;
		}
		public PaginationFilter(int offset, int limit)
		{
			Offset = offset < 0 ? 0 : offset;
			Limit = limit > 10 ? 10 : limit;
		}
	}
}
