using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        #region Cadastro

        private void BTNCliente_Click(object sender, EventArgs e)
        {
            Cadastro.FRMCliente frm = new Cadastro.FRMCliente();
            frm.ShowDialog();
        }

        private void BTNCidade_Click(object sender, EventArgs e)
        {
            Cadastro.FRMCidade frm = new Cadastro.FRMCidade();
            frm.ShowDialog();
        }

        private void BTNFilme_Click(object sender, EventArgs e)
        {
            Cadastro.FRMFilme frm = new Cadastro.FRMFilme();
            frm.ShowDialog();
        }

        private void BTNGenero_Click(object sender, EventArgs e)
        {
            Cadastro.FRMGenero frm = new Cadastro.FRMGenero();
            frm.ShowDialog();
        }

        private void BTNTipo_Click(object sender, EventArgs e)
        {
            Cadastro.FRMTipo frm = new Cadastro.FRMTipo();
            frm.ShowDialog();
        }

        private void BTNClassificacao_Click(object sender, EventArgs e)
        {
            Cadastro.FRMClassificacao frm = new Cadastro.FRMClassificacao();
            frm.ShowDialog();
        }

        private void BTNGravadora_Click(object sender, EventArgs e)
        {
            Cadastro.FRMGravadora frm = new Cadastro.FRMGravadora();
            frm.ShowDialog();
        }

        private void BTNFuncionario_Click(object sender, EventArgs e)
        {
            Cadastro.FRMFuncionario frm = new Cadastro.FRMFuncionario();
            frm.ShowDialog();
        }

        #endregion

        #region Aluguel

        private void BTNAluguel_Click(object sender, EventArgs e)
        {
            Movimento.FRMAluguel frm = new Movimento.FRMAluguel();
            frm.ShowDialog();
        }

        #endregion

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
