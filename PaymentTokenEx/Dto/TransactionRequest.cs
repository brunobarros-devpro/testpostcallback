public class TransactionRequest
{
    public string CardNumber { get; set; }
    // ... outras propriedades relevantes para a transação, como:
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string OrderId { get; set; }
    // ...
}