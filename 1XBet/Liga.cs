using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace _1XBet
{
    public partial class Liga : Form
    {
        BELiga beLiga;
        BLLLiga bllLiga;
        

        public Liga()
        {
            InitializeComponent();
            beLiga = new BELiga();
            bllLiga = new BLLLiga();
            CargarDataGridView();
        }

        

        void CargarDataGridView()
        {
            try
            {
                dataGridViewLigas.DataSource = null;
                dataGridViewLigas.DataSource = bllLiga.ListarLigas();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                LigaAlta ligaAlta = new LigaAlta();
                ligaAlta.ShowDialog();
                CargarDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Confirmar baja", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes) 
                {
                    bllLiga.BajaLiga(beLiga);
                    CargarDataGridView();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void dataGridViewLigas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            beLiga = (BELiga)dataGridViewLigas.CurrentRow.DataBoundItem;
        }
    }
}
