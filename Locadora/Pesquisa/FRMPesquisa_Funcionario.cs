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
using Locadora.Cadastro;
using BLL.Service.Interfaces;

namespace Locadora.Pesquisa
{
    public partial class FRMPesquisa_Funcionario : Form
    {
        private IEmployeeService EmployeeService;
        public Employee EmployeeSelected;
        private List<Employee> AllEmployees = new List<Employee>();
        public FRMPesquisa_Funcionario()
        {
            InitializeComponent();
           
        }

   

        #region Load

        private void FRMPesquisa_Funcionario_Load(object sender, EventArgs e)
        {
            LoadDataGridViewEmployee();
        }

        private void LoadDataGridViewEmployee()
        {
            EmployeeService = new EmployeeService();
            AllEmployees = EmployeeService.AllEmployeesWithCity().ToList();
            for (int i = 0; i < AllEmployees.Count(); i++)
            {
                DGVFuncionario.Rows.Add(AllEmployees[i].EmployeeCode.ToString(), AllEmployees[i].Name);
            }
        }
        #endregion

        #region Botão

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DGVFuncionario.CurrentRow.ToString())) // TO DO MUDAR ISSO AQUI
            {
                MessageBox.Show("Selecione uma linha");
            }

            var employeeCodeSelect = Convert.ToInt32(DGVFuncionario.CurrentRow.Cells[0].Value);
            bool isEmployeeSelected = false;
            var count = 0;
            while (!isEmployeeSelected)
            {
                if (AllEmployees[count].EmployeeCode == employeeCodeSelect)
                {
                    EmployeeSelected = AllEmployees[count];
                    isEmployeeSelected = true;
                }
                count++;
            }

            this.Close();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            EmployeeService = new EmployeeService();
            AllEmployees = EmployeeService.findByName(TBXPesquisa.Text);
            DGVFuncionario.Rows.Clear();
            DGVFuncionario.Refresh();

            for (int i = 0; i < AllEmployees.Count(); i++)
            {
                DGVFuncionario.Rows.Add(AllEmployees[i].EmployeeCode.ToString(), AllEmployees[i].Name);
            }
        }

        private void LoadDataGridView()
        {

            AllEmployees = EmployeeService.All().ToList();
            for (int i = 0; i < AllEmployees.Count(); i++)
            {
                DGVFuncionario.Rows.Add(AllEmployees[i].EmployeeCode.ToString(), AllEmployees[i].Name);
            }
        }
        #endregion

        #region DGV

        private void DGVFuncionario_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void DGVFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        #endregion


       
    }
}
