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
    public class ContatosRepository : DapperRepository<Contatos>, IContatosRepository
    {
        public ContatosRepository(ClienteContext dbcontext) 
            : base(dbcontext)
        {
        }
    }
}