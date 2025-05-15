using Microsoft.AspNetCore.Mvc;
using PaymentTokenEx.Models;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly PaymentContext _context;


    public PaymentController(PaymentContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> ProcessPayment([FromBody] Payment payment)
    {
        try
        {

            return Ok(new { Message = "Payment processed successfully!" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = "Error processing payment", Error = ex.Message });
        }
    }
}
