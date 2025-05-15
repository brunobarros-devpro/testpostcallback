using Microsoft.EntityFrameworkCore;
using PaymentTokenEx.Models;

public class PaymentContext : DbContext
{
    public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }

    public DbSet<Payment> Payments { get; set; }
}
