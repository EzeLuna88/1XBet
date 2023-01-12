using BE;
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


namespace _1XBet
{
    public partial class EquipoAlta : Form
    {
        BEEquipo beEquipo;
        BELiga beLiga;
        BLLEquipo bllEquipo;
        BLLLiga bllLiga;
        public EquipoAlta()
        {
            beEquipo = new BEEquipo();
            beLiga = new BELiga();
            bllEquipo = new BLLEquipo();
            bllLiga = new BLLLiga();
            
            InitializeComponent();
            CargarComboBox();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            beLiga = (BELiga)comboBoxLigas.SelectedItem;
            beEquipo.CodigoLiga = beLiga.Codigo;
            beEquipo.Nombre = textBoxNombreEquipo.Text;
            if (textBoxNombreEquipo.Text.Length != 0)
            {
                
                if (bllEquipo.BuscarEquipo(beEquipo) == false)
                {
                    bllEquipo.GuardarEquipo(beEquipo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Equipo ya se encuentra cargada");
                }
            }
            else
            {
                MessageBox.Show("debe ingresar un nombre");
            }
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

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
