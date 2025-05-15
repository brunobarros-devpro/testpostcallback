public class AuthenticateResponse
{
    public string TransactionId { get; set; }
    public string Status { get; set; } // Ex: "CHALLENGE_REQUIRED", "FRICTIONLESS_AUTHENTICATED", etc.
    public string AcsUrl { get; set; }  // URL para redirecionar o usuário para o desafio 3DS
    public string PaReq { get; set; }     // Payload para o desafio 3DS (se necessário)
    public string RedirectHtml { get; set; } // HTML para redirecionamento automático (se aplicável)
    // ... outras propriedades da resposta da TokenEx, como erros, etc.


}