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
using BLL.Service;
using Models.Entities;
using Locadora.Cadastro;

namespace Locadora.Pesquisa
{
    public partial class FRMPesquisa_Cidade : Form
    {
        private CityService service;
        public City CitySelected;
        public FRMPesquisa_Cidade()
        {
            InitializeComponent();
            service = new CityService();
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(DGVCidade.CurrentRow.ToString())) // TO DO MUDAR ISSO AQUI
            {
                MessageBox.Show("Selecione uma linha");
            }
            CitySelected = new City()
            {
                CityCode = Convert.ToInt32(DGVCidade.CurrentRow.Cells[0].Value),
                Name = Convert.ToString(DGVCidade.CurrentRow.Cells[1].Value),
                State = Convert.ToString(DGVCidade.CurrentRow.Cells[2].Value)

            };
            Close();

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        #region Load

        private void FRMPesquisa_Cidade_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        #endregion


        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            var name = TBXPesquisa.Text;
            DGVCidade.DataSource = service.findByName(TBXPesquisa.Text);
            DisableColumn();


        }

        private void LoadDataGridView()
        {

            DGVCidade.DataSource = service.All();
            DisableColumn();

        }
        private void DisableColumn()
        {
            DGVCidade.Columns.Remove("Customers");
            DGVCidade.Columns.Remove("Employees");
        }

        #region DGV

        private void DGVCidade_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion

    }
}