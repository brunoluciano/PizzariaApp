using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.MODEL
{
    public class Atendimento
    {
        public int id { get; set; }
        public DateTime h_pagamento { get; set; }
        public float vlr_total { get; set; }
        public float vlr_pago { get; set; }
        public float troco { get; set; }
        public int idCliente { get; set; }
    }
}
