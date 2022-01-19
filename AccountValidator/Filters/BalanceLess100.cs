namespace AccountValidator.Filters
{
    public class BalanceLess100 : Filter
    {
        public BalanceLess100() : base()
        {

        }

        public BalanceLess100(Filter nextFilter) : base(nextFilter)
        {

        }

        public override IList<Account> FilterAccounts(IList<Account> accounts)
        {
            var filteredAccounts = new List<Account>();
            foreach (var account in accounts)
            {
                if (account.Balance < 100)
                {
                    filteredAccounts.Add(account);
                }
            }
            filteredAccounts.AddRange(NextFilterAccounts(accounts));
            return filteredAccounts;
        }
    }
}
