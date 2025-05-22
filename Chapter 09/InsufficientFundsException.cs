public class InsufficientFundsException : Exception
{
    public decimal Balance { get; }
    public decimal Amount { get; }

    public InsufficientFundsException()
    {
    }

    public InsufficientFundsException(string message) : base(message)
    {
    }

    public InsufficientFundsException(string message, Exception inner) : base(message, inner)
    {
    }

    public InsufficientFundsException(string message, decimal balance, decimal amount) : base(message)
    {
        Balance = balance;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Balance: {Balance}, Amount: {Amount}";
    }
}
