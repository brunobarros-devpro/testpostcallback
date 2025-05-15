public class ChallengeResultResponse
{
    public string TransactionId { get; set; }
    public string Status { get; set; }       // Ex: "AUTHENTICATED", "DECLINED", etc.
    public string Eci { get; set; }           // Electronic Commerce Indicator
    public string Cavv { get; set; }         // Cardholder Authentication Verification Value
    public string Xid { get; set; }            // Transaction ID da ACS
    // ... outras propriedades da resposta do resultado do challenge
}