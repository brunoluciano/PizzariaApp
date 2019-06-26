using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Pedido
    {
        public string observacao { get; set; }
        public int idMesa { get; set; }
        public int idAtend { get; set; }
        public int idProduto { get; set; }

    }
}
