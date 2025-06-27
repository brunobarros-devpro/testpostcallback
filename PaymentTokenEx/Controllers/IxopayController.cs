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
    public async Task<IActionResult> threeDSMethodNotificationUrlPostAsync(
        [FromRoute] string? notification,
        [FromForm] string? cres,
        [FromForm] string? threeDSSessionData)
    {
        using (var reader = new StreamReader(Request.Body))
        {
            var body = await reader.ReadToEndAsync();

            var html = $@"
<!DOCTYPE html>
<html lang=""en"">
  <head>
    <meta charset=""UTF-8"" />
    <title>3DS Complete</title>
  </head>
  <body>
    <script>
      window.parent.postMessage(""challenge-complete"", ""*"");
    </script>
    <p>Authentication completed. You may close this window.</p>
<p>{cres}</p>
<p>{notification}</p>
<p>{threeDSSessionData}</p>
  </body>
</html>";

            return Content(html, "text/html");
        }
    }
}
