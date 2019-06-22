using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public DateTime dt_nasc { get; set; }
        public int telefone { get; set; }
        public string  endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }

    }
}
