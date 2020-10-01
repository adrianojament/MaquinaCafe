using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Interfaces
{
    public interface IMaquina
    {
        void AdicionarDinheiro(string dinheiro);        
        void PrepararBebida();
        void AdicionarBebida(IBebida bebida);
        void ValidarSaldo();

    }
}
