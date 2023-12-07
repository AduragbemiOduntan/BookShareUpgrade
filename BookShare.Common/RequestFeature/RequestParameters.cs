namespace BookShare.Common.RequestFeature
{
    public abstract class RequestParameters
    {
        const int maxPageSize = 20;
        private int pageSize = 5;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > maxPageSize ? maxPageSize : value; }
        }

        public int PageNumber { get; set; } = 1;
        public string? OrderBy { get; set; }
    }
}
