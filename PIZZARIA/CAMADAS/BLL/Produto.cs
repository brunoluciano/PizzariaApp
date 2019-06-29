using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZARIA.CAMADAS.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public List<MODEL.Produto> SelectByFkID(int fk)
        {
            if (fk < 0) 
                fk = 1;
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByFkID(fk);

        }
    }
}
