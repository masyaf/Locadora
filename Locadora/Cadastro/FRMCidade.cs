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
using Locadora.Pesquisa;

namespace Locadora.Cadastro
{
    public partial class FRMCidade : Form
    {
        private CityService service;
        private City City;
  
        public FRMCidade()
        {
            
            InitializeComponent();
            service = new CityService();
        }

        public FRMCidade(City city)
        {

            this.City = city;
            InitializeComponent();
            service = new CityService();
            LoadDataFormCity();
        }

            #region Botão

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormCity();
        }


        private void LoadDataFormCity()
        {
            if (City != null)
            {
                TBXCidade.Text = City.Name;
                TBXCodigo.Text = City.CityCode.ToString();
                TBXUf.Text = City.State;
            }
        }
        private void ClearFormCity()
        {
            this.TBXCodigo.Text = string.Empty;
            this.TBXCidade.Text = string.Empty;
            this.TBXUf.Text = string.Empty;
        }

        private void BTNGravar_Click(object sender, EventArgs e)
        {

           var city = new City() {
               CityCode = (string.IsNullOrEmpty(TBXCodigo.Text)) ? new int() : int.Parse(TBXCodigo.Text),
                Name = TBXCidade.Text.ToString(),
                State = TBXUf.Text.ToString()
            };

            

                if (string.IsNullOrEmpty(TBXCodigo.Text))
                {

                    service.Save(city);
                    MessageBox.Show("Cidade adicioanda com Sucesso!");
                }
                else
                {
                    service.Update(city);
                    MessageBox.Show("Cidade Atualizada com Sucesso!");
                }
                ClearFormCity();
            
        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBXCodigo.Text))
            {
                MessageBox.Show("Selecione uma cidade para excluir!");
            }
            else
            {
                var cityCode = Convert.ToInt32(TBXCodigo.Text);
                service.Delete(cityCode);
                MessageBox.Show("Excluido com sucesso!");
                ClearFormCity();
            }

           
        }

   

        public bool ValidatedForm()
        {
            if (string.IsNullOrEmpty(TBXCidade.Text) || string.IsNullOrEmpty(TBXUf.Text))
                {
                  MessageBox.Show("Preencha todos os campos!");
                  return false;
                }
            return true;
               
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            FRMPesquisa_Cidade frm = new FRMPesquisa_Cidade();
            this.Close();
            frm.ShowDialog();
           
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        #endregion

        private void FRMCidade_Load(object sender, EventArgs e)
        {
   
        }

        private void FRMCidade_Load_1(object sender, EventArgs e)
        {

        }
        
      

    }
}
