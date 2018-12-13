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

namespace Locadora.Cadastro
{
    public partial class FRMGravadora : Form
    {
        private RecorderService service;
        public FRMGravadora()
        {
            InitializeComponent();
            
            service = new RecorderService();
        }

        #region Load

        private void FRMGravadora_Load(object sender, EventArgs e)
        {
            LoadDataGridViewRecorder(); 
        }

        #endregion

        #region Botão

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {
            var recorderName = TBXPesquisa.Text;
            DGVGravadora.DataSource = service.findByName(recorderName);
        }

        private void BTNGravar_Click(object sender, EventArgs e)
        {
            var recorder = new Recorder {
                RecorderCode = string.IsNullOrWhiteSpace(TBXCodigo.Text) ? new int() : Convert.ToInt32(TBXCodigo.Text),
                Name = TBXGravadora.Text    
            };
        
            if(string.IsNullOrWhiteSpace(TBXCodigo.Text)){
                service.Save(recorder);
            }else{
                var recorderToUpdate = service.GetByCode(Convert.ToInt32(TBXCodigo.Text));
                recorderToUpdate.Name = TBXGravadora.Text;
                service.Update(recorderToUpdate);
                
            }
            LoadDataGridViewRecorder();
            ClearFormRecorder();
        }
        private void ClearFormRecorder()
        {
            TBXCodigo.Text = string.Empty;
            TBXGravadora.Text = string.Empty;
        }
        private void LoadDataGridViewRecorder()
        {
            DGVGravadora.DataSource = service.All();
            DisableColumn();

        }
        private void DisableColumn()
        {
            DGVGravadora.Columns["Movies"].Visible = false;
        }
        private void BTNExcluir_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(TBXCodigo.Text)) {
                MessageBox.Show("Selecione uma linha!");
            }
            else
            {
                var recorderCode = Convert.ToInt32(TBXCodigo.Text);
                service.Delete(recorderCode);
                LoadDataGridViewRecorder();
                ClearFormRecorder();
            }
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            ClearFormRecorder();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

             
        #region DGV

        private void DGVGravadora_DoubleClick(object sender, EventArgs e)
        {
            this.TBXCodigo.Text = DGVGravadora.CurrentRow.Cells[0].Value.ToString();
            this.TBXGravadora.Text = DGVGravadora.CurrentRow.Cells[1].Value.ToString();
        }

        #endregion

        private void BTNImprimir_Click(object sender, EventArgs e)
        {
            
        }

    }
}
