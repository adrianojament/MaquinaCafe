using MaquinaCafe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.Classes
{
    public abstract class Bebida : IBebida
    {
        protected string _Chave = string.Empty;
        protected string _nomeBebida = string.Empty;
        protected double _valorBebida;
        public double ValorBebida { get => _valorBebida;}
        public string NomeBebida { get => _nomeBebida; }
        public string Chave { get => _Chave; }
    }
}
