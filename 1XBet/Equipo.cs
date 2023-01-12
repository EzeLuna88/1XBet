using BLL;
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


namespace _1XBet
{
    public partial class Equipo : Form
    {

        BLLLiga bllLiga;
        BLLEquipo bllEquipo;
        BELiga beLiga;
        BEEquipo beEquipo;
        public Equipo()
        {
            bllLiga= new BLLLiga();
            bllEquipo = new BLLEquipo();
            beLiga = new BELiga();
            beEquipo = new BEEquipo();
            InitializeComponent();
            CargarComboBox();
            
        }

        public void CargarComboBox()
        {
            try
            {

                comboBoxLigas.DataSource = null;
                comboBoxLigas.DataSource = bllLiga.ListarLigas();
                comboBoxLigas.ValueMember = "Codigo";
                comboBoxLigas.DisplayMember = "Nombre";
                comboBoxLigas.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxLigas.Refresh();
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
                EquipoAlta equipoAlta = new EquipoAlta();
                equipoAlta.ShowDialog();
                CargarDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CargarDataGridView()
        {
            try
            {

                dataGridViewEquipos.DataSource = null;
                dataGridViewEquipos.DataSource = bllEquipo.ListarEquipos(beLiga);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void comboBoxLigas_SelectedIndexChanged(object sender, EventArgs e)
        {
            beLiga = (BELiga)comboBoxLigas.SelectedItem;
            CargarDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Confirmar baja", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    bllEquipo.BajaEquipo(beEquipo);
                    CargarDataGridView();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridViewEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            beEquipo = (BEEquipo)dataGridViewEquipos.CurrentRow.DataBoundItem;
        }
    }

    
}
