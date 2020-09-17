using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using Dapper;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClientesRepository : DapperRepository<Clientes>, IClientesRepository
    {
        public ClientesRepository(ClienteContext dbcontext)
            : base(dbcontext)
        {
        }

        public IEnumerable<Profissoes> FindProfissoes(int clienteId)
        {
            return _dbcontext.Connection.Query<Profissoes>("select * from dbo.Profissores where Clientes_ID = @Cliente_id",
                new { Cliente_id = clienteId });
        }

        public override Clientes Add(Clientes entity)
        {
            //TODO: implmentação específica para add o cliente
            return base.Add(entity);
        }
    }
}