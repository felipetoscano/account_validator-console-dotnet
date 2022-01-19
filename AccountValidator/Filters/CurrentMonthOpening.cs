namespace AccountValidator.Filters
{
    public class CurrentMonthOpening : Filter
    {
        public CurrentMonthOpening() : base()
        {

        }

        public CurrentMonthOpening(Filter nextFilter) : base(nextFilter)
        {
            NextFilter = nextFilter;
        }

        public override IList<Account> FilterAccounts(IList<Account> accounts)
        {
            var filteredAccounts = new List<Account>();
            foreach (var account in accounts)
            {
                if (account.OpeningDate.Month == DateTime.Now.Month)
                {
                    filteredAccounts.Add(account);
                }
            }
            filteredAccounts.AddRange(NextFilterAccounts(accounts));
            return filteredAccounts;
        }
    }
}
