using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _clientesRepository = null;

        public ClientesService(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }

        public Clientes Add(Clientes entity)
        {
            return _clientesRepository.Add(entity);
        }

        public IEnumerable<Clientes> All()
        {
            return _clientesRepository.All();
        }

        public IEnumerable<Clientes> All(string sql)
        {
            return _clientesRepository.All(sql);
        }

        public Clientes Delete(Clientes entity)
        {
            return _clientesRepository.Delete(entity);
        }

        public Clientes Find(int id)
        {
            return _clientesRepository.Find(id);
        }

        public void Update(Clientes entity)
        {
            _clientesRepository.Update(entity);
        }
    }
}
