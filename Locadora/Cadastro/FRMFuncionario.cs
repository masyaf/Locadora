using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BLL.Service;
using Models.Entities;
using Locadora.Pesquisa;
using System.Globalization;
using BLL.Service.Interfaces;

namespace Locadora.Cadastro
{
    public partial class FRMFuncionario : Form
    {
        private IEmployeeService EmployeeService;
        private IBaseService<City> cityService;
        public static Employee Employee;
        private City CitySelected;
        public FRMFuncionario()
        {
            InitializeComponent();
            Employee = new Employee();
            CitySelected = new City();


        }




        #region Load

        private void FRMCliente_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botão

        private void BTNGravar_Click(object sender, EventArgs e)
        {

            if (ValidatedFormEmployee())
            {
                EmployeeService = new EmployeeService();
                if (string.IsNullOrWhiteSpace(TBXCodigo.Text) || Convert.ToInt32(TBXCodigo.Text) == 0)
                {

                    EmployeeService.Save(Employee);

                }
                else
                {
                    EmployeeService.Update(Employee);
                }
                ClearFormEmployee();
            }


        }


        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
            {
                MessageBox.Show("Selecione um funcionário para excluir!");
            }
            else
            {
                var employeeCode = Convert.ToInt32(TBXCodigo.Text);
                EmployeeService.Delete(employeeCode);
                ClearFormEmployee();

            }

        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormEmployee();
        }
        private void ClearFormEmployee()
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
            TBXUf.Text = string.Empty;
        }
        private void BTNPesquisar_Click(object sender, EventArgs e)
        {


            FRMPesquisa_Funcionario frmPesquisa = new FRMPesquisa_Funcionario();
            frmPesquisa.ShowDialog();
            try
            {
                Employee = frmPesquisa.EmployeeSelected;
            }
            catch (NullReferenceException ex)
            {
                Employee = new Employee();
                Console.WriteLine(ex.StackTrace);
            }

            EmployeeToForm();


        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region KeyDown



        #endregion


        private void EmployeeToForm()
        {
            try
            {
                TBXCodigo.Text = Employee.EmployeeCode.ToString(); ;
                TBXNome.Text = Employee.Name;
                TBXCpf.Text = Employee.DocumentCpf;
                TBXRg.Text = Employee.DocumentRg;
                TBXTelefone.Text = Employee.Phone;
                TBXDataNascimento.Text = Employee.DateBirth.ToString();
                TBXEndereco.Text = Employee.Address;
                TBXNumero.Text = Employee.Number;
                TBXBairro.Text = Employee.Neighborhood;
                TBXDataNascimento.Text = Convert.ToString(Employee.DateBirth, CultureInfo.InvariantCulture);
                TBXCidade.Text = Employee.City.Name;
                TBXUf.Text = Employee.City.State;
                Employee.CityCode = Employee.City.CityCode;
            }catch(NullReferenceException ex)
            {
                TBXCodigo.Text = string.Empty;
                Console.WriteLine(ex.StackTrace);
            }



        }

        private bool ValidatedFormEmployee()
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

        private void GetEmployeeForm()
        {
            Employee.Name = TBXNome.Text;
            Employee.DocumentRg = TBXRg.Text;
            Employee.DocumentCpf = TBXCpf.Text;
            Employee.Phone = TBXTelefone.Text;
            Employee.Address = TBXEndereco.Text;
            Employee.Number = TBXNumero.Text;
            Employee.Neighborhood = TBXBairro.Text;
            Employee.DateBirth = GetDateBirth();

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

        private void TBXCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRMPesquisa_Cidade frmPesquisaCidade = new FRMPesquisa_Cidade();
            frmPesquisaCidade.ShowDialog();

            CitySelected = frmPesquisaCidade.CitySelected;
            TBXUf.Text = CitySelected.State;
            TBXCidade.Text = CitySelected.Name;
            Employee.CityCode = CitySelected.CityCode;
            

        }
    }
}
