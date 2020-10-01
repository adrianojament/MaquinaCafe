using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Classes
{
    public class Cafe : Bebida
    {
        public Cafe()
        {
            _Chave = Constantes.CHAVE_BEBIDA_CAFE;
            _nomeBebida = "Café";
            _valorBebida = 2.0;
        }
    }
}
