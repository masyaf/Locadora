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
        private IMovieService MovieService;
        private Loan Loan;
        private Movie MovieToAdd;
        private Customer CustomerSelect;
        private Employee EmployeeSelected;
        private int LoanCode;

        public static List<Movie> Movies = new List<Movie>();

        public FRMAluguel()
        {
            InitializeComponent();
            NewLoan();

        }

        private void NewLoan()
        {
            Loan = new Loan() { Completed = false, DateLoan = DateTime.Now };
            CustomerSelect = new Customer();
            EmployeeSelected = new Employee();
        }

        #region Load

        private void FRMAluguel_Load(object sender, EventArgs e)
        {

            TBXDataAluguel.Text = Loan.DateLoan.ToString();

        }


        #endregion


        #region Botão


        private void BTNGravar_Click(object sender, EventArgs e)
        {

            LoanService = new LoanService();
            if (ValidatedForm())
            {
                if (Loan.LoanCode > 0)
                {

                    AddMovieToStock();
                    GetLoanFromDataGrid();
                    LoanService.Update(Loan);
                    MessageBox.Show("Devolução realizada com sucesso");


                }
                else
                {
                    ReduceMovieStock();
                    foreach (var loanMovie in Loan.LoanMovies)
                    {
                        loanMovie.Movie = null;
                    }
                    LoanService.Save(Loan);
                    MessageBox.Show("Locação realizada com sucesso");
                }

                ClearDataGridViewMovie();
                ClearDataLoan();
                NewLoan();

            }

 

          

        }

        private bool ValidatedForm()
        {
            if (Loan.LoanMovies.Count() == 0)
            {
                MessageBox.Show("Informar pelo menos um filme para locação");
                return false;
            }
            if(Loan.CustomerCode  <= 0) {
                MessageBox.Show("Necessário informar um cliente ");
                return false;
            }
            if (Loan.EmployeeCode <= 0)
            {
                MessageBox.Show("Necessário informar um Funcionário ");
                return false;
            }
            return true;
        }
        private void AddMovieToStock()
        {
           MovieService = new MovieService();
            foreach (var loanMovie in Loan.LoanMovies)
            {
                if(loanMovie.Returned == true)
                {
                    loanMovie.Movie.Stock += 1;
                }
               
              MovieService.Update(loanMovie.Movie);
            }
        }
        private void ReduceMovieStock()
        {
            MovieService = new MovieService();
            foreach (var loanMovie in Loan.LoanMovies)
            {
                loanMovie.Movie.Stock--;
                MovieService.Update(loanMovie.Movie);
            }
           
        }
        private void ClearDataLoan()
        {
            TBXDataAluguel.Text = string.Empty;
            TBXCliente.Text = string.Empty;
            TBXFuncionario.Text = string.Empty;
            LBMulta.Text = "0,00";
            LBTotal.Text = "0,00";
            LBValor.Text = "0,00";
            TBXCodigo.Text = string.Empty;

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

            LoanCode = frmPesquisaAluguel.LoanCode;
            if (LoanCode > 0)
            {
                LoadOneLoanOnDataGridView();
                BTNDevolucao.Enabled = true;

                GBStatus.Enabled = true;
                LoanStatusLabel(Loan.Completed);
            }

       



        }
        private double totalDays(DateTime dateDelivery, DateTime dateReturned)
        {
            return (dateDelivery - dateReturned).TotalDays;
        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TBXCodigo.Text))
            {
                MessageBox.Show("Selecione uma locação para remover");
            }
            else
            {
                try
                {
                    LoanService = new LoanService();
                    var loanCode = Convert.ToInt32(TBXCodigo.Text);
                    LoanService.Delete(loanCode);
                }catch(Exception ex){
                    MessageBox.Show("Não pode ser excluída esta locação, pois ela está relacionado com outros dados");
                    Console.WriteLine(ex.Message);
                }

            }

            
        }

        private void BTNImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOneLoanOnDataGridView()
        {
            Loan = new Loan();
            ClearDataGridViewMovie();
            LoanService = new LoanService();
            Loan = LoanService.GetLoanWithMoviesByCode(LoanCode);
            for (int i = 0; i < Loan.LoanMovies.Count(); i++)
            {
                DGVFilme.Rows.Add(Loan.Completed,
                                 Loan.LoanMovies[i].LoanMovieCode.ToString(),
                                 Loan.LoanMovies[i].LoanCode.ToString(),
                                 Loan.LoanMovies[i].Movie.MovieCode.ToString(),
                                 Loan.LoanMovies[i].Movie.Title,
                                 Loan.LoanMovies[i].Movie.TypeMovie.Name,
                                 Loan.LoanMovies[i].DateReturn,
                                 Loan.LoanMovies[i].DeliveryDate,
                                 Loan.LoanMovies[i].FineValue,
                                 Loan.LoanMovies[i].Movie.TypeMovie.Value.ToString(),
                                 Loan.LoanMovies[i].Movie.TypeMovie.ToString());




            }
            DGVFilme.Refresh();
            showInfoLoan();



        }

        private void showInfoLoan()
        {
           

            TBXCodigo.Text = Loan.LoanCode.ToString();
            if (Loan.Customer != null)
            {
                TBXCliente.Text = Loan.Customer.Name;
                TBXFuncionario.Text = Loan.Employee.Name;
            }

            TBXDataAluguel.Text = Convert.ToString(Loan.DateLoan);
            TotalValue();
            EnablePanelInfoLoan(false);
            EnablePanelInfoMovie(true);


        }

        private void GetLoanFromDataGrid()
        {
            for (int i = 0; i < DGVFilme.Rows.Count; i++)
            {
                Loan.Completed = Convert.ToBoolean(DGVFilme.Rows[i].Cells["Completed"].Value);
                Loan.LoanMovies[i].DeliveryDate = Convert.ToDateTime(DGVFilme.Rows[i].Cells["DateDelivery"].Value);
                Loan.LoanMovies[i].FineValue = Convert.ToDecimal(DGVFilme.Rows[i].Cells["AmountMuclt"].Value);
                Loan.LoanMovies[i].Value = Convert.ToDecimal(DGVFilme.Rows[i].Cells["Value"].Value);
            }
        }
        private void BTNAdicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBXFilme.Text))
            {
                MessageBox.Show("Selecione um filme para adicionar!");
                
            }


            else if(MovieToAdd.Stock  <= 0){
                MessageBox.Show("Filme Indisponível para locação, estoque insuficiente!");
                ResetInfoMovieSelected();
            }
            else
            {
                Loan.LoanMovies.Add(new LoanMovie{ Movie = MovieToAdd, MovieCode = MovieToAdd.MovieCode, Value = MovieToAdd.TypeMovie.Value,  Returned = false});

                ClearDataGridViewMovie(); //limpa o datagridview atual
                LoadMovieInDataGridView(); //monta um novo
                ResetInfoMovieSelected();
                TotalValue();
                DGVFilme.Refresh();

            }





        }
        private void ResetInfoMovieSelected()
        {
            TBXFilme.Text = string.Empty;
            MovieToAdd = new Movie();
            new FRMPesquisa_Filme().MovieSelect = new Movie();
        }
        private void LoadMovieInDataGridView()
        {
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
        }

        public void TotalValue()
        {
            decimal totalValue = 0;
            decimal totalValueMuclt = 0;
            decimal totalValueResume = 0;
            for (int i = 0; i < DGVFilme.Rows.Count; i++)
            {
                totalValue += Convert.ToDecimal(DGVFilme.Rows[i].Cells[9].Value.ToString());
                Loan.LoanMovies[i].Value = totalValue;
                LBValor.Text = string.Format("{0:N}", totalValue);
                totalValueMuclt += Convert.ToDecimal(DGVFilme.Rows[i].Cells[8].Value.ToString());
                Loan.LoanMovies[i].FineValue = totalValueMuclt;
                LBMulta.Text = string.Format("{0:N}", totalValueMuclt);



            }
            totalValueResume = totalValue + totalValueMuclt;
            LBTotal.Text = string.Format("{0:N}", totalValueResume);
            Loan.Amount = totalValueResume;
            Loan.AmountMuclt = totalValueMuclt;


        }



        private void BTNDeletar_Click(object sender, EventArgs e)
        {
            var movieCodeToDelete = Convert.ToInt32(DGVFilme.CurrentRow.Cells[3].Value);
        
           var count = 0;
           var isRemoved = false;
            while(!isRemoved){
                LoanMovie loanMovie = Loan.LoanMovies[count];
                if(loanMovie.MovieCode == movieCodeToDelete){
                    Loan.LoanMovies.Remove(loanMovie);
                    isRemoved = true;
                }
                count++;
            }

            if (DGVFilme.Rows != null)
            {
                DGVFilme.Rows.RemoveAt(DGVFilme.CurrentRow.Index);

            }
            TotalValue();
            DGVFilme.Refresh();
            
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearDataGridViewMovie();
            ClearDataLoan();
            NewLoan();
            LoanStatusLabel(Loan.Completed);
            
        }
  
        private void GetStatusLoanReturned()
        {
            for (int i = 0; i < DGVFilme.Rows.Count; i++)
            {
                Loan.LoanMovies[i].Returned = Convert.ToBoolean(DGVFilme.Rows[i].Cells[0].Value);
            }
        }
        private void BTNDevolucao_Click(object sender, EventArgs e)
        {
            GetStatusLoanReturned();
            foreach (DataGridViewRow rows in DGVFilme.Rows)
            {
                if (Convert.ToBoolean(rows.Cells[0].Value) == true)
                {
                    rows.Cells[7].Value = DateTime.Now;

                    DateTime dateDeliverry = Convert.ToDateTime(rows.Cells[7].Value);



                    DateTime dateReturn = Convert.ToDateTime(rows.Cells[6].Value);

                    decimal totalMuclt = Convert.ToDecimal(rows.Cells[8].Value);

                    int codeMovie = Convert.ToInt32(rows.Cells[3].Value);

                    //Verifica se é necesário cobrar multa
                    if (!LargestDeliveryDate(dateDeliverry, dateReturn))
                    {
                        decimal totalDays = Convert.ToDecimal((dateDeliverry - dateReturn).TotalDays);
                        if (totalDays > 0)
                        {
                            totalMuclt = totalDays * MovieValueMucltPerDay(codeMovie);

                        }
                       
                    }
                    


                    rows.Cells[8].Value = totalMuclt;


                }
            }
            TotalValue();
            DGVFilme.Refresh();

        }

        private bool LargestDeliveryDate(DateTime dateDelivery, DateTime dateReturn)
        {
            if (dateDelivery.CompareTo(dateReturn) == 0)
            {
                return true;
            }
            return false;

        }

        private decimal MovieValueMucltPerDay(int codeMovie)
        {
            decimal mucltByTypeMovie = 0;

            foreach (var loanMovies in Loan.LoanMovies)
            {
                if (loanMovies.MovieCode == codeMovie)
                {
                    mucltByTypeMovie = Convert.ToDecimal(loanMovies.Movie.TypeMovie.Fine);
                }

            }
            return mucltByTypeMovie;
        }
        #endregion



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



        private void BTNConcluir_Click(object sender, EventArgs e)
        {

        }
        private void EnablePanelInfoLoan(bool state)
        {
            GBDados.Enabled = state;
            GBStatus.Enabled = state;

        }
        private void EnablePanelInfoMovie(bool state)
        {
            GBFilme.Enabled = state;

        }



        private void BTNNovo_Click(object sender, EventArgs e)
        {
            NewLoan();
            LoanStatusLabel(Loan.Completed);
            EnablePanelInfoLoan(true);
            EnablePanelInfoMovie(true);
            ClearDataGridViewMovie();
            ClearDataLoan();

            TBXDataAluguel.Text = Convert.ToString(Loan.DateLoan);
        }

        private void TBXCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FRMPesquisa_Cliente frmPesquisaCliente = new FRMPesquisa_Cliente();
            frmPesquisaCliente.ShowDialog();

            CustomerSelect = frmPesquisaCliente.CustomerSelect;
            TBXCliente.Text = CustomerSelect.Name;
            Loan.CustomerCode = CustomerSelect.CustomerCode;


        }
        private void LoanStatusLabel(bool status)
        {
            if (status)
            {
                LBStatus.Text = "FINALIZADO";
            }
            else
            {
                LBStatus.Text = "EM ABERTO";
            }
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
