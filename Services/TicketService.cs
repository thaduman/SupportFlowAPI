using Microsoft.EntityFrameworkCore;
using SupportFlowAPI.Data;
using SupportFlowAPI.Models;

namespace SupportFlowAPI.Services;

public class TicketService : ITicketService
{
    private readonly AppDbContext _context;
    
    public TicketService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Ticket> CreateTicketAsync(Ticket ticket)
    {
        _context.Tickets.Add(ticket);
        await _context.SaveChangesAsync();
        return ticket;
    }

    public async Task<IEnumerable<Ticket>> GetTicketsAsync()
    {
        return await _context.Tickets.ToListAsync();
    }
}