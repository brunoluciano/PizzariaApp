using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Produto
    {
        public int id { get; set; }
        public float preco { get; set; }
        public string  descricao { get; set; }
        public string classificacao { get; set; }
        public int idClassificacao { get; set; }
    }
}
