using SupportFlowAPI.Models;

namespace SupportFlowAPI.Services;

public interface ITicketService
{
    Task<IEnumerable<Ticket>> GetTicketsAsync();
    Task<Ticket> CreateTicketAsync(Ticket ticket);
}

// Neden Interface? Çünkü bağımlılıkları azaltır ve ileride bu servisin "sahte" (Mock) versiyonlarını
// yazarak test yapmanı kolaylaştırır