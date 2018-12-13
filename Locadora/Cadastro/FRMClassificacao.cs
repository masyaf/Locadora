using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Models.Entities;
using BLL.Service;

namespace Locadora.Cadastro
{
    public partial class FRMClassificacao : Form
    {
        private RankingService service;
        public FRMClassificacao()
        {
            InitializeComponent();
            service = new RankingService();
            LoadDataGridRanking();
        }

        #region Load

        private void FRMClassificacao_Load(object sender, EventArgs e)
        {
         
        }

        #endregion

        #region Botão

        private void ClearFormRanking()
        {
            this.TBXClassificacao.Text = string.Empty;
            this.TBXCodigo.Text = string.Empty;

        }

        private void BTNGravar_Click(object sender, EventArgs e)
        {
           
            var newRanking = new Ranking()
            {
                RankingCode = string.IsNullOrWhiteSpace(TBXCodigo.Text) ? new int() : int.Parse(TBXCodigo.Text),
                Name = TBXClassificacao.Text
            };

            if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
            {
                service.Save(newRanking);
            }
            else
            {
                var rankingUpdate = service.GetByCode(Convert.ToInt32(TBXCodigo.Text));
                rankingUpdate.Name = TBXClassificacao.Text;
                service.Update(rankingUpdate);
            }
            LoadDataGridRanking();
            ClearFormRanking();
        }
        private void LoadDataGridRanking()
        {
            DGVClassificacao.DataSource = service.All();
            DisableColumn();


        }

        private void DisableColumn()
        {
            DGVClassificacao.Columns["Movies"].Visible = false;
        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBXCodigo.Text))
            {
                var rankingCode = Convert.ToInt32(TBXCodigo.Text);
                service.Delete(rankingCode);
                ClearFormRanking();
                LoadDataGridRanking();

            }
            else
            {
                MessageBox.Show("Selecione uma classificação para remover!");
            }

        }



        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormRanking();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            var name = TBXPesquisa.Text;
            DGVClassificacao.Refresh();
            DGVClassificacao.DataSource = service.findByName(name);
            DisableColumn();
        }

        #endregion


        #region DGV

        private void DGVClassificacao_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion

        private void DGVClassificacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DGVClassificacao_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.TBXCodigo.Text = DGVClassificacao.CurrentRow.Cells[0].Value.ToString();
            this.TBXClassificacao.Text = DGVClassificacao.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
