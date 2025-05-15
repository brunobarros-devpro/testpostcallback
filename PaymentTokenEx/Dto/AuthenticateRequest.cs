public class AuthenticateRequest
{
    public string CardNumber { get; set; }  // Ou token, dependendo da implementação
    public string CardExpiryDate { get; set; } // Formato MM/YY
    public string CardCvv { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string OrderId { get; set; }
    public string ReturnUrl { get; set; }  // URL para redirecionar após a autenticação
    // ... outros campos conforme necessário pela API TokenEx e sua lógica de negócio
    public string MerchantUrl { get; set; } // URL da sua loja
    public string CustomerBrowserIP { get; set; } // IP do cliente


}