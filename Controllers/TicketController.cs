using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupportFlowAPI.Data;
using SupportFlowAPI.Models;
using SupportFlowAPI.Services;

namespace SupportFlowAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets()
    {
        var tickets = await _ticketService.GetTicketsAsync();
        return Ok(tickets);
    }

    [HttpPost]
    public async Task<ActionResult<Ticket>> CreateTicket(Ticket ticket)
    {
        var createdTicket = await _ticketService.CreateTicketAsync(ticket);

        return CreatedAtAction(nameof(GetTickets), new { id = createdTicket.Id }, createdTicket);
    }
}