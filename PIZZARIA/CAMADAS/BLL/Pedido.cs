using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.BLL
{
    public class Pedido
    {
        public List<MODEL.Pedido> SelectByFkID(int fk)
        {
            DAL.Pedido dalPed = new DAL.Pedido();

            return dalPed.SelectByFkID(fk);
        }

        public void Inserir(MODEL.Pedido ped)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            if(ped.id != 0)
            {
                dalPed.Inserir(ped);
            }
        }
    }
}
