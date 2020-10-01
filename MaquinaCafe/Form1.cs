using MaquinaCafe.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaCafe
{
    public partial class Form1 : Form
    {
                
        string _status = "";
        Dictionary<string, Button> bebidas;
        BackgroundWorker _backgroundWorker;
        Maquina _maquina;

        private void AtualizarSaldo()
        {
            var _saldo = _maquina.SaldoMaquina;
            txtSaldo.Text = "R$ " + _saldo.ToString("0.00");
            //cmdCafe.Enabled = cmdCafecomLeite.Enabled = cmdCappuccino.Enabled = cmdMocha.Enabled = _saldo >= _valorCafe;                
        }

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                txtStatus.Text = _status;
                txtStatus.Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();            
            InicializarMaquina();
            InicializarBackground();
            InicializarBebidas();            
        }

        private void InicializarBebidas()
        {
            InicializarChavesBebidas();
            InicializarBebidasDisponiveis();
        }

        private void InicializarBebidasDisponiveis()
        {
            foreach (var item in _maquina.BebidasLiberadas())
            {
                Button button = null;
                bebidas.TryGetValue(item.Key, out button);
                if (button == null)
                    continue;
                button.Text = item.Value.NomeBebida + " R$ " + item.Value.ValorBebida.ToString("n2");
                button.Tag = item.Value;
                button.Enabled = true;
                button.Click += Button_Click;
            }
        }

        private void InicializarChavesBebidas()
        {
            bebidas = new Dictionary<string, Button>();
            bebidas.Add(Constantes.CHAVE_BEBIDA_CAFE, cmdCafe);
            bebidas.Add(Constantes.CHAVE_BEBIDA_CAFECOMLEITE, cmdCafecomLeite);
            bebidas.Add(Constantes.CHAVE_BEBIDA_CAPPUCCINO, cmdCappuccino);
            bebidas.Add(Constantes.CHAVE_BEBIDA_MOCHA, cmdMocha);
        }

        private void InicializarBackground()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            _backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    Status = e.UserState.ToString();
                    break;
                case 2:
                    _backgroundWorker.CancelAsync();
                    break;
                default:
                    break;
            }
                
        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {            
            InicializarMaquina();
            AtualizarSaldo();
            this.Enabled = true;            
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {            
            _maquina.PrepararBebida();
            _backgroundWorker.ReportProgress(2, "");
            e.Cancel = true;
            _backgroundWorker.ReportProgress(100);

        }

        private void InicializarMaquina()
        {
            _maquina = new Maquina();
            _maquina.StatusPreparacaoBebida += _maquina_StatusPreparacaoBebida;
            AtualizarSaldo();
            Status = _maquina.Status;
            mskMoeda.Text = "";            
        }
                

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _maquina.AdicionarBebida(button.Tag as Bebida);
            Preparar();
        }

        private void _maquina_StatusPreparacaoBebida(object sender, string e)
        {
            _backgroundWorker.ReportProgress(1, e);
        }

        void AdicionarMoeda()
        {
            string valor = mskMoeda.Text;
            _maquina.AdicionarDinheiro(valor);
            AtualizarSaldo();
            if (!_maquina.Sucesso)
                Status = _maquina.Messagem;
            else
                Status = "Pronta";
            mskMoeda.Text = "";
        }

        private void MskMoeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AdicionarMoeda();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InicializarMaquina();
        }

        void Preparar()
        {
            _maquina.ValidarSaldo();

            if (!_maquina.Sucesso)
            {
                this.Status = _maquina.Messagem;
                return;
            }           
            
            _backgroundWorker.RunWorkerAsync();
            this.Enabled = false;
        }
    }

    enum TiposPreparos
    {
        Cafe,
        Cappuccino,
        Mocha,
        CafecomLeite
    }
}
