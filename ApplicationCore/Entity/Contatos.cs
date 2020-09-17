using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entity
{
    public class Contatos
    {
        public int ID { get; set; }
        public string Con_nome { get; set; }
        public string Con_fone { get; set; }
        public string Con_email { get; set; }
        public int Clientes_ID { get; set; }
    }
}