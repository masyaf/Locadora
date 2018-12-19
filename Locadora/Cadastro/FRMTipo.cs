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
using System.Globalization;

namespace Locadora.Cadastro
{
    public partial class FRMTipo : Form
    {
        private TypeMovieService service;
        public FRMTipo()
        {
            InitializeComponent();
            service = new TypeMovieService();
            LoadDataGridViewTypeMovie();
            
        }

        #region Botão

        private void BTNGravar_Click(object sender, EventArgs e)
        {

        
            if (ValidatedFormTypeMovie())
            {
                var typeMovie = new TypeMovie()
                {
                    Name = TBXTipo.Text,
                    Value = Convert.ToDecimal(TBXValor.Text),
                    Fine = Convert.ToDecimal(TBXMulta.Text),
                    Day = Convert.ToInt32(TBXDias.Text)
                };
                if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
                {

                    service.Save(typeMovie);
                }
                else
                {
                    var typeMovieCode = Convert.ToInt32(TBXCodigo.Text);
                    var typeMovieToUpdate = service.GetByCode(typeMovieCode);
                    typeMovieToUpdate.Name = TBXTipo.Text;
                    typeMovieToUpdate.Value = Convert.ToDecimal(TBXValor.Text);
                    typeMovieToUpdate.Fine = Convert.ToDecimal(TBXMulta.Text);
                    typeMovieToUpdate.Day = Convert.ToInt32(TBXDias.Text);
                    service.Update(typeMovieToUpdate);

                }
                ClearFormTypeMovie();
                LoadDataGridViewTypeMovie();

            }
          
         
         

        }
        private bool ValidatedFormTypeMovie()
        {
            if (string.IsNullOrWhiteSpace(TBXTipo.Text))
            {
                MessageBox.Show("Campo Tipo deve ser preenchido!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXValor.Text) || Convert.ToDecimal(TBXValor.Text) <= 0 )
            {
                MessageBox.Show("Campo Valor deve ser preenchido e maior que 0");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TBXDias.Text) || Convert.ToInt32(TBXDias.Text) <= 0)
            {
                MessageBox.Show("Campo dia deve ser preenchido e maior que 0");
                return false;
            }
            return true;
                
        }
        private void LoadDataGridViewTypeMovie()
        {
            DGVTipo.DataSource = service.All();
            DisableColumns();
           

        }
        private void DisableColumns()
        {
            DGVTipo.Columns["Movie"].Visible = false;
         
        }

        private void ClearFormTypeMovie()
        {
            TBXCodigo.Text = string.Empty;
            TBXTipo.Text = string.Empty;
            TBXDias.Text = string.Empty;
            TBXMulta.Text = "0,00";
            TBXValor.Text = "0,00";
        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
            {
                MessageBox.Show("Selecione uma linha");
            }
            else
            {

                var typeMovieCode = Convert.ToInt32(TBXCodigo.Text);
                try
                {
                    service.Delete(typeMovieCode);
                }catch(Exception ex){
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Não é possivel excluir esta informação, pois a mesma está relacionada com outros dados");
                }
              
            }
            LoadDataGridViewTypeMovie();
            ClearFormTypeMovie();
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormTypeMovie();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            var typeMovieName = TBXPesquisa.Text;
            DGVTipo.DataSource = service.findByName(typeMovieName);
        }

        #endregion

        #region Load

        private void FRMTipo_Load(object sender, EventArgs e)
        {

        }

        #endregion


        #region DGV

        private void DGVTipo_DoubleClick(object sender, EventArgs e)
        {

        }

        #endregion

        private void DGVTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TBXCodigo.Text = DGVTipo.CurrentRow.Cells[0].Value.ToString();
            this.TBXTipo.Text = DGVTipo.CurrentRow.Cells[1].Value.ToString();
            this.TBXValor.Text = string.Format(DGVTipo.CurrentRow.Cells[2].Value.ToString(), CultureInfo.InvariantCulture);
            this.TBXDias.Text = DGVTipo.CurrentRow.Cells[3].Value.ToString();
            this.TBXMulta.Text = string.Format(DGVTipo.CurrentRow.Cells[4].Value.ToString(), CultureInfo.InvariantCulture);
        }

    }
}
