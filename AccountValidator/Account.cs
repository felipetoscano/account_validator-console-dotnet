namespace AccountValidator
{
    public class Account
    {
        public DateTime OpeningDate { get; private set; }
        public double Balance { get; private set; }

        public Account(DateTime openingDate, double balance)
        {
            OpeningDate = openingDate;
            Balance = balance;
        }
    }
}
