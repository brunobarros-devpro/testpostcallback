public class BinLookupResponse
{
    public string CardType { get; set; }    // Ex: "VISA", "MASTERCARD"
    public string CardCategory { get; set; } // Ex: "CREDIT", "DEBIT"
    public string IssuerCountry { get; set; }  // Código do país do emissor
    public bool Is3DSSupported { get; set; }
    public string ThreeDSVersion { get; set; }

    // ... outros dados úteis do BIN lookup
}
