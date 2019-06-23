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
        public string cpf { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateTime dt_nasc { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public int cep { get; set; }
        public int idCidade { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }

    }
}
