using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Pedido
    {
        public int id { get; set; }
        public string observacao { get; set; }
        public int idAtend { get; set; }
        public int idProduto { get; set; }
        public string produto { get; set; }
        public int quantidade { get; set; }
        public int idClass { get; set; }
        public string classificacao { get; set; }
    }
}
