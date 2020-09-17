using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProfissoesRepository : DapperRepository<Profissoes>, IProfissoesRepository
    {
        public ProfissoesRepository(ClienteContext dbcontext) 
            : base(dbcontext)
        {
        }
    }
}