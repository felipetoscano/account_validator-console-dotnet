namespace AccountValidator.Filters
{
    public abstract class Filter
    {
        protected Filter NextFilter { get; set; }

        protected Filter(Filter nextFilter)
        {
            NextFilter = nextFilter;
        }

        protected Filter()
        {
            NextFilter = null;
        }

        public abstract IList<Account> FilterAccounts(IList<Account> accounts);

        protected IList<Account> NextFilterAccounts(IList<Account> accounts)
        {
            if (NextFilter == null)
            {
                return new List<Account>();
            }

            return NextFilter.FilterAccounts(accounts);
        }
    }
}
