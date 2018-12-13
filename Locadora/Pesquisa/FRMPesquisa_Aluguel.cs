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
using BLL.Service.Interfaces;
using Models.Entities;
using BLL.Service;

namespace Locadora.Pesquisa
{
    public partial class FRMPesquisa_Aluguel : Form
    {

        private  ILoanService _loanService;
        private List<Loan> AllLoans = new List<Loan>();
        public FRMPesquisa_Aluguel()
        {
            InitializeComponent();
        }

        #region Load

        private void FRMPesquisa_Aluguel_Load(object sender, EventArgs e)
        {
            _loanService = new LoanService();
            AllLoans = _loanService.GetAllLoanWithCustomer().ToList();

            foreach (var loan in AllLoans)
            {
                DGVAluguel.Rows.Add(loan.LoanCode, loan.DateLoan, loan.Customer.Name);
            }
        }

        #endregion
        
        #region Botão

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
           

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

               
        #region DGV

        private void DGVAluguel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion
    }
}
