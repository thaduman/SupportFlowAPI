using Microsoft.EntityFrameworkCore;
using SupportFlowAPI.Models;

namespace SupportFlowAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Ticket> Tickets { get; set; }
}