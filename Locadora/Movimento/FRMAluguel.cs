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
using Locadora.Pesquisa;
using BLL.Service;
using BLL.Service.Interfaces;
using Models.Entities;
using Locadora.ModelView;
using System.Globalization;

namespace Locadora.Movimento
{
    public partial class FRMAluguel : Form
    {
        private ILoanService LoanService;
        private Loan Loan;
        private Movie MovieToAdd;
        private Customer CustomerSelect;
        private Employee EmployeeSelected;
        
        public static List<Movie> Movies = new List<Movie>();

        public FRMAluguel()
        {
            InitializeComponent();
            Loan = new Loan()
            {
                Completed = false,
                DateLoan = DateTime.Now

            };
            CustomerSelect = new Customer();
            EmployeeSelected = new Employee();

        }


        #region Load

        private void FRMAluguel_Load(object sender, EventArgs e)
        {

            TBXDataAluguel.Text = Loan.DateLoan.ToString();

        }

        public static void LoadDataGridViewDGVMove()
        {


        }
        private void DataGridView()
        {
        }

        #endregion


        #region Botão


        private void BTNGravar_Click(object sender, EventArgs e)
        {

            LoanService = new LoanService();
            Loan.Amount = Convert.ToDecimal(LBTotal.Text, CultureInfo.InvariantCulture);

            foreach (var loanMovie in Loan.LoanMovies)
            {
                loanMovie.Movie = null;
            }
            LoanService.Save(Loan);
            MessageBox.Show("Locação realizada com sucesso");
            ClearDataGridViewMovie();
            ClearDataLoan();

        }
        private void ClearDataLoan()
        {
            TBXDataAluguel.Text = string.Empty;
            TBXCliente.Text = string.Empty;
            TBXFuncionario.Text = string.Empty;
            LBMulta.Text = "0,00";
            LBTotal.Text = "0,00";
            LBValor.Text = "0,00";
        }
        private void ClearDataGridViewMovie()
        {
            DGVFilme.Rows.Clear();
            DGVFilme.Refresh();
        }
        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            FRMPesquisa_Aluguel frmPesquisaAluguel = new FRMPesquisa_Aluguel();
            frmPesquisaAluguel.ShowDialog();

        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BTNImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBXFilme.Text))
            {
                MessageBox.Show("Selecione um filme para adicionar!");
            }
            else
            {
                Loan.LoanMovies.Add(new LoanMovie
                {
                    Movie = MovieToAdd,
                    MovieCode = MovieToAdd.MovieCode,
                    Value  = MovieToAdd.TypeMovie.Value,
                    Returned = false
                    


                });



                DGVFilme.Rows.Clear();
                DGVFilme.Refresh();
                for (int i = 0; i < Loan.LoanMovies.Count(); i++)
                {
                    DGVFilme.Rows.Add(Loan.Completed,
                                     Loan.LoanMovies[i].LoanMovieCode.ToString(),
                                     Loan.LoanMovies[i].LoanCode.ToString(),
                                     Loan.LoanMovies[i].Movie.MovieCode.ToString(),
                                     Loan.LoanMovies[i].Movie.Title,
                                     Loan.LoanMovies[i].Movie.TypeMovie.Name,
                                     Loan.LoanMovies[i].DateReturn = DateTime.Now.AddDays(Loan.LoanMovies[i].Movie.TypeMovie.Day),   //data do dia + quantidade de dias do tipo de filme
                                     null,
                                     "0,00",    //Multa
                                     Loan.LoanMovies[i].Movie.TypeMovie.Value.ToString(),
                                     Loan.LoanMovies[i].Movie.TypeMovie.ToString());




                }
                TBXFilme.Text = "";
                MovieToAdd = new Movie();
                new FRMPesquisa_Filme().MovieSelect = new Movie();
                DGVFilme.Refresh();
                TotalValue();

            }


    
                      
        }

        public void TotalValue()
        {
           decimal  totalValue = 0;
           decimal totalValueMuclt = 0;
           decimal totalValueResume = 0;
            for (int i = 0; i < DGVFilme.Rows.Count; i++)
            {
                totalValue +=  Convert.ToDecimal(DGVFilme.Rows[i].Cells[9].Value.ToString());
                LBValor.Text = totalValue.ToString(CultureInfo.InvariantCulture);

                totalValueMuclt += Convert.ToDecimal(DGVFilme.Rows[i].Cells[8].Value.ToString());
                LBMulta.Text = totalValueMuclt.ToString(CultureInfo.InvariantCulture);
            }
            totalValueResume = totalValue + totalValueMuclt;
            LBTotal.Text = totalValueResume.ToString(CultureInfo.InvariantCulture);


        }



        private void BTNDeletar_Click(object sender, EventArgs e)
        {

        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {

        }

        private void BTNDevolucao_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region KeyDown


        private void TBXCliente_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TBXFuncionario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TBXFilme_KeyDown(object sender, KeyEventArgs e)
        {
            FRMPesquisa_Filme frmPesquisaFilme = new FRMPesquisa_Filme();
            frmPesquisaFilme.ShowDialog();

            MovieToAdd = frmPesquisaFilme.MovieSelect;
            if (MovieToAdd.MovieCode > 0)
            {
                TBXFilme.Text = MovieToAdd.Title;
            }

        }


        #endregion

        private void BTNConcluir_Click(object sender, EventArgs e)
        {

        }
        private void EnableButtons()
        {
            GBDados.Enabled = true;
            GBFilme.Enabled = true;

        }

        private void BTNNovo_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void TBXCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRMPesquisa_Cliente frmPesquisaCliente = new FRMPesquisa_Cliente();
            frmPesquisaCliente.ShowDialog();
        
            CustomerSelect = frmPesquisaCliente.CustomerSelect;
            TBXCliente.Text = CustomerSelect.Name;
            Loan.CustomerCode = CustomerSelect.CustomerCode;
         

        }

        private void TBXFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRMPesquisa_Funcionario frmPesquisaFuncionario = new FRMPesquisa_Funcionario();
            frmPesquisaFuncionario.ShowDialog();

            EmployeeSelected = frmPesquisaFuncionario.EmployeeSelected;
            TBXFuncionario.Text = EmployeeSelected.Name;
            Loan.EmployeeCode = EmployeeSelected.EmployeeCode;
        }

    }
}
