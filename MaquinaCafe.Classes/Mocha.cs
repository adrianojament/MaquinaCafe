using MaquinaCafe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Classes
{
    public class Mocha : Bebida
    {
        public Mocha()
        {
            _Chave = Constantes.CHAVE_BEBIDA_MOCHA;
            _nomeBebida = "Mocha";
            _valorBebida = 4;
        }
    }
}
