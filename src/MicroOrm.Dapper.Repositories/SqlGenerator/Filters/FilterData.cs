namespace MicroOrm.Dapper.Repositories.SqlGenerator.Filters
{
    /// <summary>
    /// The filter data class; This should have some more things...
    /// </summary>
    public class FilterData
    {
        /// <summary>
        /// The query order settings
        /// </summary>
        public OrderInfo OrderInfo { get; set; }

        /// <summary>
        /// The query limits settings
        /// </summary>
        public LimitInfo LimitInfo { get; set; }
    }
}
