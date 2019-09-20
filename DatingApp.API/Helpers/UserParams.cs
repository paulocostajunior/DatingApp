namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; }
        private int pageSize = 5;
        public int PageSize 
        {
            get { return pageSize = 5; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
    }
}