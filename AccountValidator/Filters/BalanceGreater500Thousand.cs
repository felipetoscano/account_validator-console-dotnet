namespace AccountValidator.Filters
{
    public class BalanceGreater500Thousand : Filter
    {

        public BalanceGreater500Thousand() : base()
        {

        }

        public BalanceGreater500Thousand(Filter nextFilter) : base()
        {
            NextFilter = nextFilter;
        }

        public override IList<Account> FilterAccounts(IList<Account> accounts)
        {
            var filteredAccounts = new List<Account>();
            foreach (var account in accounts)
            {
                if (account.Balance > 500000)
                {
                    filteredAccounts.Add(account);
                }
            }

            filteredAccounts.AddRange(NextFilterAccounts(accounts));

            return filteredAccounts;
        }
    }
}
