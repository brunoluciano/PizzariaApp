using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.BLL
{
    public class Cliente
    {
        public List<MODEL.Cliente> Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.Select();
        }
    }
}
