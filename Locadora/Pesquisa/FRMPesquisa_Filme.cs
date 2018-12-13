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
using Locadora.Movimento;
using Models.Entities;

namespace Locadora.Pesquisa
{
    public partial class FRMPesquisa_Filme : Form
    {
        private MovieService MovieService;
        private FRMAluguel _frmAluguel;
        private List<Movie> AllMovies = new List<Movie>();
        public Movie MovieSelect = new Movie();
        public FRMPesquisa_Filme()
        {
            InitializeComponent();
        }

        public FRMPesquisa_Filme(FRMAluguel frmAluguel)
        {
            InitializeComponent();
            _frmAluguel = frmAluguel;
        }


        #region Load

        private void FRMPesquisa_Filme_Load(object sender, EventArgs e)
        {
            MovieService = new MovieService();
            AllMovies = MovieService.GetAllMoviesWithTypeMovies();
            for (int i = 0; i < AllMovies.Count(); i++)
            {
                DGVFilme.Rows.Add(AllMovies[i].MovieCode.ToString(), AllMovies[i].Title, AllMovies[i].Stock, AllMovies[i].TypeMovie.Name);
            }
        }

        #endregion

        #region Botão

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
         
        }


        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            MovieSelect.MovieCode = Convert.ToInt32(DGVFilme.CurrentRow.Cells[0].Value);


            foreach (var movieSelected in AllMovies)
            {

                if (MovieSelect.MovieCode == movieSelected.MovieCode)
                {
                    MovieSelect = movieSelected;
                }
            }
            
            Close();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

           
        #region DGV

        private void DGVFilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                 
        }

       #endregion

              
    }
}
