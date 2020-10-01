using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Interfaces
{
    public interface IBebida
    {
        string Chave { get; }
        double ValorBebida { get; }
        string NomeBebida { get;}
    }
}
