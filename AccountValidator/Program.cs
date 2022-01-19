using AccountValidator.Filters;

namespace AccountValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var filter = new BalanceGreater500Thousand(new BalanceLess100(new CurrentMonthOpening()));

            var ac1 = new Account(DateTime.Now, 500);
            var ac2 = new Account(DateTime.Now.AddDays(-10), 500);
            var ac3 = new Account(DateTime.Now.AddMonths(-1), 50);
            var ac4 = new Account(DateTime.Now.AddMonths(-2), 25);
            var ac5 = new Account(DateTime.Now.AddMonths(-3), 1000000);
            var ac6 = new Account(DateTime.Now.AddMonths(-4), 2000000);
            var ac7 = new Account(DateTime.Now.AddMonths(-5), 250);
            var ac8 = new Account(DateTime.Now.AddMonths(-6), 250);
            var ac9 = new Account(DateTime.Now.AddMonths(-7), 250);
            var ac10 = new Account(DateTime.Now.AddMonths(-8), 250);

            var accounts = new List<Account>() { ac1, ac2, ac3, ac4, ac5, ac6, ac7, ac8, ac9, ac10 };

            var filteredAccounts = filter.FilterAccounts(accounts);

            foreach (var account in filteredAccounts)
            {
                Console.WriteLine($"{account.OpeningDate}, {account.Balance}");
            }
        }
    }
}