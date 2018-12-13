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
        private string Source;
        private Customer Customer;
        private Employee Employee;
        public City CitySelected;
        public FRMPesquisa_Cidade()
        {
            InitializeComponent();
            service = new CityService();
         

        }
      
        public FRMPesquisa_Cidade(string source, Employee employee)
        {
            InitializeComponent();
            service = new CityService();

            Source = source;
            Employee = employee;


        }

        #region Botão

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


            /*
             * 
            if (!string.IsNullOrWhiteSpace(Source))
            {
                if (Source.Equals("FRMCliente"))
                {

                    Customer.CityCode = Convert.ToInt32(DGVCidade.CurrentRow.Cells[0].Value);
                    FRMCliente frmCliente = new FRMCliente(Customer);

                    this.Hide();
                    frmCliente.ShowDialog();
                }else  if (Source.Equals("FRMFuncionario"))
                    {
                        Employee.CityCode = Convert.ToInt32(DGVCidade.CurrentRow.Cells[0].Value);
                        FRMFuncionario frmFuncionario = new FRMFuncionario(Employee);

                        this.Hide();
                        frmFuncionario.ShowDialog();
                    }

            }
            else
            {
                FRMCidade frmCity = new FRMCidade(city);
                this.Hide();
                frmCity.ShowDialog();
            }
             * */


            this.Close();

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

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