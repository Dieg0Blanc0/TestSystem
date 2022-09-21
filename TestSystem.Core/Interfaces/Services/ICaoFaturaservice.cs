using TestSystem.Core.DTOs;

namespace TestSystem.Core.Interfaces.Services
{
    public interface ICaoFaturaService
    {
        Task<IEnumerable<ProfitDTO>> GetProfitAsync(List<string> consultors, DateOnly fromDate, DateOnly ToDate, CancellationToken cancellationToken = default);
    }
}
