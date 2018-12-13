﻿using System;
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
using BLL.Service.Interfaces;
using Locadora.Pesquisa;

namespace Locadora.Cadastro
{
    public partial class FRMFilme : Form
    {
        private MovieService MovieService;
        private RankingService RankingService;
        private GenderService GenderService;
        private TypeMovieService TypeMovieService;
        private RecorderService RecorderService;
        public FRMFilme()
        {
            InitializeComponent();
        }

        #region Botão

        private void BTNGravar_Click(object sender, EventArgs e)
        {


            if (ValidatedFormMovie())
            {
                var moveToSaveOrUpdate = MovieFromForm();
                MovieService = new MovieService();
                if (string.IsNullOrEmpty(TBXCodigo.Text) || moveToSaveOrUpdate.MovieCode == 0)
                {
                    MovieService.Save(moveToSaveOrUpdate);
                }
                else
                {

                    MovieService.Update(moveToSaveOrUpdate);
                }
            }

            ClearFormMovie();

        }
        public Movie MovieFromForm()
        {
            var Movie = new Movie()
            {
                Title = TBXTitulo.Text,
                Stock = Convert.ToInt32(TBXEstoque.Text),
                YearProduction = Convert.ToInt32(TBXAnoLancamento.Text),
                Duration = Convert.ToInt32(TBXDuracao.Text)

            };
            var RankingSelect = GetRankingSelectByName();
            Movie.RankingCode = RankingSelect.RankingCode;

            var GenderSelect = GetGenderSelectByName();
            Movie.GenderCode = GenderSelect.GenderCode;

            var TypeMovieSelect = GetTypeMovieSelectByName();
            Movie.TypeMovieCode = TypeMovieSelect.TypeMovieCode;

            var RecorderSelect = GetRecorderSelectByName();
            Movie.RecorderCode = RecorderSelect.RecorderCode;
            return Movie;


        }
        public TypeMovie GetTypeMovieSelectByName()
        {
            TypeMovieService = new TypeMovieService();
            return TypeMovieService.GetSingleByName(CBTipo.SelectedItem.ToString());
        }
        public Gender GetGenderSelectByName()
        {
            GenderService = new GenderService();
            return GenderService.GetSingleByName(CBGenero.SelectedItem.ToString());
        }

        public Recorder GetRecorderSelectByName()
        {
            RecorderService = new RecorderService();
            return RecorderService.GetSingleByName(CBGravadora.SelectedItem.ToString());
        }

        private Ranking GetRankingSelectByName()
        {
            RankingService = new RankingService();
            return RankingService.GetSingleByName(CBClassificacao.SelectedItem.ToString());

        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
            {
                MessageBox.Show("Deve escolher um filme para excluir");
            }
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormMovie();
        }

        private void ClearFormMovie()
        {
            TBXCodigo.Text = string.Empty;
            TBXTitulo.Text = string.Empty;
            TBXEstoque.Text = string.Empty;
            TBXDuracao.Text = string.Empty;
            TBXAnoLancamento.Text = string.Empty;
            CBClassificacao.SelectedIndex = -1;
            CBGenero.SelectedIndex = -1;
            CBGravadora.SelectedIndex = -1;
            CBTipo.SelectedIndex = -1; 

        }
        private bool ValidatedFormMovie()
        {
            if (string.IsNullOrWhiteSpace(TBXTitulo.Text))
            {
                MessageBox.Show("Título deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(CBGenero.SelectedItem)))
            {
                MessageBox.Show("Genero deve ser selecionado!");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(CBClassificacao.SelectedItem)))
            {
                MessageBox.Show("Classificação deve ser selecionado!");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(CBGravadora.SelectedItem)))
            {
                MessageBox.Show("Gravadora deve ser selecionado!");
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(CBTipo.SelectedItem)))
            {
                MessageBox.Show("Tipo deve Ser Selecionado deve ser selecionado!");
                return false;
            }
            if (string.IsNullOrEmpty(TBXAnoLancamento.Text))
            {
                MessageBox.Show("Ano lançamento deve ser preenchido");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXDuracao.Text))
            {
                MessageBox.Show("Duração deve ser informado");
            }
            if (string.IsNullOrWhiteSpace(TBXEstoque.Text))
            {
                MessageBox.Show("Estoque deve ser informado");
                return false;
            }
            return true;
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            FRMPesquisa_Filme frm = new FRMPesquisa_Filme();
            Hide();
            frm.ShowDialog();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Load

        private void FRMFilme_Load(object sender, EventArgs e)
        {
            LoadComboBoxGender();
            LoadComboBoxRanking();
            LoadComboBoxMovieType();
            LoadComboBoxRecorder();

        }
        private void LoadComboBoxRecorder()
        {
            RecorderService = new RecorderService();
            var recorders = RecorderService.All();
            foreach (var Recorder in recorders)
            {
                CBGravadora.Items.Add(Recorder.Name);
            }
        }
        private void LoadComboBoxRanking()
        {
            RankingService = new RankingService();
            var rankings = RankingService.All();
            foreach (var Ranking in rankings)
            {
                CBClassificacao.Items.Add(Ranking.Name);
            }
        }
        private void LoadComboBoxMovieType()
        {
            TypeMovieService = new TypeMovieService();
            var typeMovies = TypeMovieService.All();
            foreach (var TypeMovie in typeMovies)
            {
                CBTipo.Items.Add(TypeMovie.Name);
            }
        }

        private void LoadComboBoxGender()
        {
            GenderService = new GenderService();
            var genders = GenderService.All();
            foreach (var Gender in genders)
            {
                CBGenero.Items.Add(Gender.Name);
            }
        }
        #endregion

        private void BTNImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
