using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Classes
{
    public class CafecomLeite : Cafe
    {
        public CafecomLeite()
        {
            _Chave = Constantes.CHAVE_BEBIDA_CAFECOMLEITE;
            _nomeBebida = "Cafe com Leite";
            _valorBebida = 3;
        }
    }
}
