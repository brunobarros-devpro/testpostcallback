public class AuthenticationRequest
{
    public string Token { get; set; }
    public decimal Amount { get; set; }
    public string CurrencyCode { get; set; }
    public string MerchantId { get; set; }
    public string ReturnUrl { get; set; }
}
