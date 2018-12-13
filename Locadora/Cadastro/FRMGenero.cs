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

namespace Locadora.Cadastro
{
    public partial class FRMGenero : Form
    {
        private IBaseService<Gender> service;
        public FRMGenero()
        {
            InitializeComponent();
            service = new GenderService();
            LoadDataGridViewGender();
        }

        #region Botão

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormGender();
        }

        private void BTNGravar_Click(object sender, EventArgs e)
        {
            var newGender = new Gender() {
                Name = TBXGenero.Text
            };
            bool isNewGender = string.IsNullOrWhiteSpace(TBXCodigo.Text) ? true : false;
            if (isNewGender)
            {
                service.Save(newGender);
            }
            else
            {
                var genderCode = Convert.ToInt32(TBXCodigo.Text);
                var genderToUpdate = service.GetByCode(genderCode);
                genderToUpdate.Name = TBXGenero.Text;
                service.Update(genderToUpdate);
            }
            LoadDataGridViewGender();
            ClearFormGender();
        }

        private void ClearFormGender()
        {
            TBXCodigo.Text = string.Empty;
            TBXGenero.Text = string.Empty;
        }

        private void LoadDataGridViewGender()
        {
            DGVGenero.DataSource = service.All();
            DisableColumn();

        }
        private void DisableColumn()
        {
            DGVGenero.Columns["Movies"].Visible = false;
        }

        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBXCodigo.Text))
            {
                MessageBox.Show("Selecione uma linha para exlusão!");
            }
            else
            {
                var genderCode = Convert.ToInt32(TBXCodigo.Text);
                service.Delete(genderCode);
            }
            LoadDataGridViewGender();
            ClearFormGender();
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            var genderName = TBXPesquisa.Text;
            DGVGenero.DataSource = service.findByName(genderName);
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Load

        private void FRMGenero_Load(object sender, EventArgs e)
        {
         
        }

        #endregion
             
        #region DGV

        private void DGVGenero_DoubleClick(object sender, EventArgs e)
        {
            this.TBXCodigo.Text = DGVGenero.CurrentRow.Cells[0].Value.ToString();
            this.TBXGenero.Text = DGVGenero.CurrentRow.Cells[1].Value.ToString();
        }

        #endregion
    }
}
