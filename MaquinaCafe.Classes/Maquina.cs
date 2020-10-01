using MaquinaCafe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MaquinaCafe.Classes
{
    public class Maquina : IMaquina
    {
        const int TempoPreparacao = 1500;
        double _Total;
        string _Messagem;
        bool _Sucesso;
        string _Status;
        IBebida _bebida;

        public string Status { get => _Status; }
        public double SaldoMaquina { get => _Total;}
        public string Messagem { get => _Messagem; }
        public bool Sucesso { get => _Sucesso; }

        public Maquina()
        {
            _Status = "Pronta.";
        }

        public event EventHandler<string> StatusPreparacaoBebida;

        protected virtual void OnStatusPreparacaoBebida(string e)
        {
            EventHandler<string> handler = StatusPreparacaoBebida;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public void AdicionarDinheiro(string dinheiro)
        {
            _Sucesso = true;
            double valor = 0;
            if (!double.TryParse( dinheiro, out valor))
            {
                _Sucesso = false;
                _Messagem = "Moeda Invalida, por favor adicione a moeda novamente";
                return;
            }

            ValidarDinheiro(valor);
            if (!Sucesso)
                return;

            _Total += valor;
        }

        private void ValidarDinheiro(double valor)
        {
            _Messagem = string.Empty;
            switch (valor)
            {
                case 0.10:
                case 0.25:
                case 0.50:
                case 1.00:
                    _Sucesso = true;
                    break;
                default:
                    _Sucesso = false;
                    _Messagem = "Aceitas Moedas R$ 0,10 R$ 0,25 R$ 0,50 R$ 1,00";
                    break;
            }
        }

        public void PrepararBebida()
        {            
          
            this.OnStatusPreparacaoBebida("Preparando: " + _bebida.NomeBebida);
            Thread.Sleep(TempoPreparacao);
            this.OnStatusPreparacaoBebida("Finalizando: " + _bebida.NomeBebida);
            Thread.Sleep(TempoPreparacao);
            this.OnStatusPreparacaoBebida("Finalizado: " + _bebida.NomeBebida+", por favor, retire o copo");
            _Total -= _bebida.ValorBebida;

            if (_Total > 0)
            {
                this.OnStatusPreparacaoBebida("Por favor, retire o troco: "+ _Total.ToString("n2"));
                Thread.Sleep(TempoPreparacao);
                _Total = 0;
            }
            this.OnStatusPreparacaoBebida("Obrigado, reinicializando a maquina");
            Thread.Sleep(TempoPreparacao);

            _bebida = null;
        }

        public Dictionary<string, Bebida> BebidasLiberadas()
        {
            var bebidas = new Dictionary<string, Bebida>();

            bebidas.Add(Constantes.CHAVE_BEBIDA_CAFE, new Cafe());
            bebidas.Add(Constantes.CHAVE_BEBIDA_CAPPUCCINO, new Cappuccino());
            bebidas.Add(Constantes.CHAVE_BEBIDA_MOCHA, new Mocha());
            bebidas.Add(Constantes.CHAVE_BEBIDA_CAFECOMLEITE, new CafecomLeite());
            return bebidas;
        }

        public void AdicionarBebida(IBebida bebida)
        {
            _Sucesso = true;
            this._bebida = bebida;
        }

        public void ValidarSaldo()
        {
            _Sucesso = true;
            if (_bebida.ValorBebida > _Total)
            {
                this._Sucesso = false;
                this._Messagem = "Creditos insuficientes";
                return;
            }
        }
    }
}
