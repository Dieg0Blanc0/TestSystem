using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.DTOs;
using TestSystem.Core.Entities;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Core.Interfaces.Services;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Persistence.Service.Base;

namespace TestSystem.Infrastructure.Persistence.Service
{
    public class CaoFaturaService : CRUDService<CaoFaturaDTO, CaoFaturaCreateDTO, CaoFaturaUpdateDTO, CaoFaturaDeleteDTO, CaoFatura, ICaoFaturaRepository<TestSystemDbContext>, TestSystemDbContext>, ICaoFaturaService
    {
        private readonly ICaoFaturaRepository<TestSystemDbContext> _caoFaturaRepository;
        private readonly ICaoUsuarioService _caoUsuarioService;
        private readonly ICaoSalarioService _caoSalarioService;

        public CaoFaturaService(IMapper mapper, IUnitOfWork<TestSystemDbContext> unitOfWork, 
            ICaoFaturaRepository<TestSystemDbContext> caoFaturaRepository,
            ICaoUsuarioService caoUsuarioService,
            ICaoSalarioService caoSalarioService) : base(caoFaturaRepository, unitOfWork, mapper)
        {
            _caoFaturaRepository = caoFaturaRepository;
            _caoUsuarioService = caoUsuarioService;
            _caoSalarioService = caoSalarioService;
        }

        public async Task<IEnumerable<ProfitDTO>> GetProfitAsync(List<string> consultors, DateOnly fromDate, DateOnly ToDate, CancellationToken cancellationToken = default)
        {
            var profitDto = new List<ProfitDTO>();

            foreach (var consultor in consultors)
            {
                var profit = new ProfitDTO();

                var name =  _caoUsuarioService.SingleFilterCaoUsuarioAsync(x => x.CoUsuario == consultor, cancellationToken).Result.NoUsuario;
                var salario = await _caoSalarioService.GetByCoUsuarioAsync(consultor, cancellationToken);
                var fixedCost = salario != null ? salario.BrutSalario : 0;
                var invoices = await _caoFaturaRepository.GetAllByCoUsuarioAtRangeDateAsync(consultor, fromDate, ToDate, cancellationToken);

                var periods =from invoice in invoices
                            group invoice by invoice.DataEmissao.ToString("MM-yyyy") into period
                            select new { 
                                date = period.Key, 
                                value = period.Sum(x => x.Total - ((x.Total * x.TotalImpInc)/100)),
                                fixedC = fixedCost,
                                commision = period.Sum(x => ((x.Total - (x.Total * x.TotalImpInc / 100)) * x.ComissaoCn)/100),
                                loot = period.Sum(x => x.Total - ((x.Total * x.TotalImpInc) / 100) - (fixedCost + ((x.Total - (x.Total * x.TotalImpInc / 100)) * x.ComissaoCn) / 100))
                            };
                
                profit.Name = name;
                profit.FixedCost = fixedCost;
                profit.Total = periods.Sum(x => x.value);

                foreach (var period in periods.OrderBy(x => x.date))
                {
                    profit.Periods.Add(new Period
                    {
                        Description = period.date,
                        Profit = period.value,
                        Commission = period.commision,
                        Loot = period.loot
                    });
                }

                profitDto.Add(profit);
            }

            return profitDto;
        }
    }
}
