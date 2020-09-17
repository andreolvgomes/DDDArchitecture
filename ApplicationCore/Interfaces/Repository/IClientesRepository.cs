using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Repository
{
    public interface IClientesRepository : IRepository<Clientes>
    {
        IEnumerable<Profissoes> FindProfissoes(int id);
    }
}
