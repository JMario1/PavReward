namespace PavRewards.Models
{
    public class Transaction
    {
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public string? Name { get; set; }
        public int Amount { get; set; }
    }

    public enum TransactionType 
    {
        Debit,
        Credit
    }
}