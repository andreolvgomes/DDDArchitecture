using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entity
{
    public class Enderecos
    {
        public int ID { get; set; }
        public string End_logradouro { get; set; }
        public string End_bairro { get; set; }
        public string End_cep { get; set; }
        public int Clientes_ID { get; set; }
    }
}
