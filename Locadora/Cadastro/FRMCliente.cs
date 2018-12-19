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
using Locadora.Pesquisa;
using System.Globalization;
using BLL.Service.Interfaces;

namespace Locadora.Cadastro
{
    public partial class FRMCliente : Form
    {
        private ICustomerService CustomerService;
        public static Customer Customer;
        private City CitySelected;
        public FRMCliente()
        {
            InitializeComponent();
            CitySelected = new City();
            Customer = new Customer();

        }


        #region Load

        private void FRMCliente_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botão

        private void BTNGravar_Click(object sender, EventArgs e)
        {

            if (ValidatedFormCustomer())
            {
                CustomerService = new CustomerService();
                GetCustomerForm();

                if (string.IsNullOrWhiteSpace(TBXCodigo.Text) || Convert.ToInt32(TBXCodigo.Text) == 0)
                {

                    CustomerService.Save(Customer);

                }
                else
                {
                    CustomerService.Update(Customer);
                }
                ClearFormCustomer();
            }


        }


        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            CustomerService = new CustomerService();
            var customerCode = Convert.ToInt32(TBXCodigo.Text);
            CustomerService.Delete(customerCode);
            ClearFormCustomer();
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormCustomer();
        }
        private void ClearFormCustomer()
        {
            TBXCodigo.Text = string.Empty;
            TBXNome.Text = string.Empty;
            TBXRg.Text = string.Empty;
            TBXCpf.Text = string.Empty;
            TBXTelefone.Text = string.Empty;
            TBXEndereco.Text = string.Empty;
            TBXNumero.Text = string.Empty;
            TBXBairro.Text = string.Empty;
            TBXDataNascimento.Text = string.Empty;
            TBXCidade.Text = string.Empty;
        }
        private void BTNPesquisar_Click(object sender, EventArgs e)
        {

            FRMPesquisa_Cliente frmPesquisa = new FRMPesquisa_Cliente();
            frmPesquisa.ShowDialog();
            try
            {
                Customer = frmPesquisa.CustomerSelect;
            }
            catch (NullReferenceException ex)
            {
                Customer = new Customer();
                Console.WriteLine(ex.StackTrace);
            }

            CustomerToForm();

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region KeyDown

        private void TBXCidade_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #endregion

        private void TBXCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRMPesquisa_Cidade frmPesquisaCidade = new FRMPesquisa_Cidade();
            frmPesquisaCidade.ShowDialog();

            CitySelected = frmPesquisaCidade.CitySelected;
            TBXUf.Text = CitySelected.State;
            TBXCidade.Text = CitySelected.Name;
            Customer.CityCode = CitySelected.CityCode;

        }

        private void CustomerToForm()
        {
            try
            {
                TBXCodigo.Text = Customer.CustomerCode.ToString();
                TBXNome.Text = Customer.Name;
                TBXCpf.Text = Customer.DocumentCpf;
                TBXRg.Text = Customer.DocumentRg;
                TBXTelefone.Text = Customer.Phone;
                TBXDataNascimento.Text = Customer.DateBirth.ToString();
                TBXEndereco.Text = Customer.Address;
                TBXNumero.Text = Customer.Number;
                TBXBairro.Text = Customer.Neighborhood;
                TBXDataNascimento.Text = Convert.ToString(Customer.DateBirth, CultureInfo.InvariantCulture);
                TBXCidade.Text = Customer.City.Name;
                Customer.CityCode = Customer.City.CityCode;
                TBXUf.Text = Customer.City.State;
            }
            catch (NullReferenceException ex)
            {
                TBXCodigo.Text = string.Empty;
                Console.WriteLine(ex.StackTrace);
            }



        }

        private bool ValidatedFormCustomer()
        {
            if (string.IsNullOrWhiteSpace(TBXNome.Text))
            {
                MessageBox.Show("O campo nome deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXCpf.Text))
            {
                MessageBox.Show("O campo CPF deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXRg.Text))
            {
                MessageBox.Show("O campo RG deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXEndereco.Text))
            {
                MessageBox.Show("O campo endereço deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXNumero.Text))
            {
                MessageBox.Show("O campo número deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXDataNascimento.Text))
            {
                MessageBox.Show("O campo data de nascimento deve ser preenchido");
                return false;
            }
            if (string.IsNullOrEmpty(TBXBairro.Text))
            {
                MessageBox.Show("O campo bairro deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXCidade.Text))
            {
                MessageBox.Show("O campo cidade deve ser preenchido");
                return false;
            }

            return true;
        }

        private DateTime GetDateBirth()
        {
            DateTime dateBirth;
            if (DateTime.TryParse(TBXDataNascimento.Text, out dateBirth))
            {
                return dateBirth = Convert.ToDateTime(TBXDataNascimento.Text, CultureInfo.InvariantCulture);
            }


            return new DateTime();

        }

        private void GetCustomerForm()
        {

            Customer.CustomerCode = string.IsNullOrEmpty(TBXCodigo.Text) ? 0 : Convert.ToInt32(TBXCodigo.Text);
            Customer.Name = TBXNome.Text;
            Customer.DocumentRg = TBXRg.Text;
            Customer.DocumentCpf = TBXCpf.Text;
            Customer.Phone = TBXTelefone.Text;
            Customer.Address = TBXEndereco.Text;
            Customer.Number = TBXNumero.Text;
            Customer.Neighborhood = TBXBairro.Text;
            Customer.DateBirth = GetDateBirth();

        }
    }
}
