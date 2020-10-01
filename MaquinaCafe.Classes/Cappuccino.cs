using MaquinaCafe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Classes
{
    public class Cappuccino : Bebida
    {
        public Cappuccino()
        {
            _Chave = Constantes.CHAVE_BEBIDA_CAPPUCCINO;
            _nomeBebida = "Cappuccino";
            _valorBebida = 3.5;
        }
    }
}
