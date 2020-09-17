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
    public class ContatosService : IContatosService
    {
        private readonly IContatosRepository _contatosRepository = null;

        public ContatosService(IContatosRepository contatosRepository)
        {
            _contatosRepository = contatosRepository;
        }

        public Contatos Add(Contatos entity)
        {
            return _contatosRepository.Add(entity);
        }

        public IEnumerable<Contatos> All()
        {
            return _contatosRepository.All();
        }

        public IEnumerable<Contatos> All(string sql)
        {
            return _contatosRepository.All(sql);
        }

        public Contatos Delete(Contatos entity)
        {
            return _contatosRepository.Delete(entity);
        }

        public Contatos Find(int id)
        {
            return _contatosRepository.Find(id);
        }

        public void Update(Contatos entity)
        {
            _contatosRepository.Update(entity);
        }
    }
}
