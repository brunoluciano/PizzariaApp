using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idEstado { get; set; }
        public virtual string uf { get; set; }
    }
}
