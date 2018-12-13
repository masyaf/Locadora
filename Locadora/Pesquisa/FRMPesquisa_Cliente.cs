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
using BLL.Service.Interfaces;

namespace Locadora.Pesquisa
{
    public partial class FRMPesquisa_Cliente : Form
    {
        private ICustomerService CustomerService;
        public Customer CustomerSelect;
        private List<Customer> AllCustomers;
        public FRMPesquisa_Cliente()
        {
            InitializeComponent();


        }

        private void LoadDataGridView()
        {

            AllCustomers = CustomerService.AllCustomersWithCity().ToList();
            for (int i = 0; i < AllCustomers.Count(); i++)
            {
                DGVCliente.Rows.Add(AllCustomers[i].CustomerCode.ToString(), AllCustomers[i].Name);
            }
        }


        #region Botão

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DGVCliente.CurrentRow.ToString())) // TO DO MUDAR ISSO AQUI
            {
                MessageBox.Show("Selecione uma linha");
            }

            var CustomerCodeSelect = Convert.ToInt32(DGVCliente.CurrentRow.Cells[0].Value);
            bool isCustomerSelected = false;
            var count = 0;
            while (!isCustomerSelected)
            {
                if (AllCustomers[count].CustomerCode == CustomerCodeSelect)
                {
                    CustomerSelect = AllCustomers[count];
                    isCustomerSelected = true;
                }
                count++;
            }

           this.Close();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            CustomerSelect = new Customer();
            this.Close();
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            DGVCliente.Rows.Clear();
            DGVCliente.Refresh();
            var customers = CustomerService.findByName(TBXPesquisa.Text);
            for (int i = 0; i < customers.Count(); i++)
            {
                DGVCliente.Rows.Add(customers[i].CustomerCode.ToString(), customers[i].Name);
            }

        }

        #endregion

        #region Load

        private void FRMPesquisa_Cliente_Load(object sender, EventArgs e)
        {
            CustomerService = new CustomerService();
            LoadDataGridView();
        }

        #endregion

        #region DGV

        private void DGVCliente_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
