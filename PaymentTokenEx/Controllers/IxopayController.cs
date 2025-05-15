using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/3ds")]
public class IxopayController : ControllerBase
{

    [HttpPost("authenticate")]
    public async Task<IActionResult> Authenticate([FromBody] AuthenticationRequest request)
    {
        return Ok();
    }

    [HttpGet("challenge-result/{transactionId}")]
    public async Task<IActionResult> GetChallengeResult(string transactionId)
    {
        return Ok();
    }

    [HttpGet("threeDSMethodNotificationUrl")]
    public IActionResult threeDSMethodNotificationUrlGet(string threeDSMethodNotificationUrl)
    {
        return Ok(threeDSMethodNotificationUrl);
    }

    [HttpPost("threeDSMethodNotificationUrl")]
    public async Task<IActionResult> threeDSMethodNotificationUrlPostAsync(string? threeDSMethodNotificationUrl)
    {
        using (var reader = new StreamReader(Request.Body))
        {
            var body = await reader.ReadToEndAsync();
            // Aqui você pode processar o corpo da requisição.
            return Ok(body);
        }
    }
}
