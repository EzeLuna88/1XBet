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
    public partial class Partido : Form
    {
        BLLLiga bllLiga;
        BLLEquipo bllEquipo;
        BELiga beLiga;
        BEPartido bePartido;
        BLLPartido bllPartido;
        public Partido()
        {
            bePartido= new BEPartido();
            beLiga = new BELiga();
            bllLiga = new BLLLiga();
            bllEquipo = new BLLEquipo();
            bllPartido = new BLLPartido();
            InitializeComponent();
            CargarComboBox();
        }

        public void CargarComboBox()
        {
            try
            {

                comboBoxLiga.DataSource = null;
                comboBoxLiga.DataSource = bllLiga.ListarLigas();
                comboBoxLiga.ValueMember = "Codigo";
                comboBoxLiga.DisplayMember = "Nombre";
                comboBoxLiga.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxLiga.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SeleccionarLiga()
        {
            beLiga = (BELiga)comboBoxLiga.SelectedItem;
        }

        private void comboBoxLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarLiga();
            comboBoxEquipoLocal.DataSource = null;
            comboBoxEquipoLocal.DataSource = bllEquipo.ListarEquipos(beLiga);
            comboBoxEquipoLocal.ValueMember = "Codigo";
            comboBoxEquipoLocal.DisplayMember = "Nombre";
            comboBoxEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipoLocal.Refresh();
            comboBoxEquipoVisitante.DataSource = null;
            comboBoxEquipoVisitante.DataSource = bllEquipo.ListarEquipos((BELiga)comboBoxLiga.SelectedItem);
            comboBoxEquipoVisitante.ValueMember = "Codigo";
            comboBoxEquipoVisitante.DisplayMember = "Nombre";
            comboBoxEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipoVisitante.Refresh();
        }

        public void GuardarPartido()
        {

            BEEquipo local = (BEEquipo)comboBoxEquipoLocal.SelectedItem;
            BEEquipo visitante = (BEEquipo)comboBoxEquipoVisitante.SelectedItem;
            if (local.Codigo != visitante.Codigo)
            {
                bePartido.EquipoLocal = local.Codigo;
                bePartido.EquipoVisitante = visitante.Codigo;
                bePartido.Fecha = Convert.ToDateTime(dateTimePickerFecha.Text);
                bePartido.GolesLocal = Convert.ToInt32(textBoxGolesLocal.Text);
                bePartido.GolesVisitante = Convert.ToInt32(textBoxGolesVisitante.Text);
                bePartido.TarjetaAmarillaLocal = Convert.ToInt32(textBoxAmarillaLocal.Text);
                bePartido.TarjetaAmarillaVisitante = Convert.ToInt32(textBoxAmarillaVisitante.Text);
                bePartido.TarjetaRojaLocal = Convert.ToInt32(textBoxRojaLocal.Text);
                bePartido.TarjetaRojaVisitante = Convert.ToInt32(textBoxRojaVisitante.Text);
                bePartido.SaquesEsquinaLocal = Convert.ToInt32(textBoxEsquinaLocal.Text);
                bePartido.SaquesEsquinaVisitante = Convert.ToInt32(textBoxEsquinaVisitante.Text);
                bePartido.CodigoLiga = beLiga.Codigo;
                bePartido.Jornada = Convert.ToInt32(textBoxJornada.Text);
                bool EquipoRepetidoEnJornada = bllPartido.EquiposEnJornada(bePartido.Jornada, local, visitante);
                if(EquipoRepetidoEnJornada == true)
                { MessageBox.Show("Uno de los equipos ya fue cargado en la misma jornada"); }
                else
                { 
                if (bllPartido.GuardarPartido(bePartido) == true)
                {
                    textBoxGolesLocal.Clear();
                    textBoxGolesVisitante.Clear();
                    textBoxAmarillaLocal.Clear();
                    textBoxAmarillaVisitante.Clear();
                    textBoxRojaLocal.Clear();
                    textBoxRojaVisitante.Clear();
                    textBoxEsquinaLocal.Clear();
                    textBoxEsquinaVisitante.Clear();

                }
                }
            }
            else
            { MessageBox.Show("debe elegir dos equipos distintos"); }




        }
        
        private void textBoxGolesLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private static void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxJornada_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxGolesVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxAmarillaLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxAmarillaVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxRojaLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxRojaVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxEsquinaLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void textBoxEsquinaVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarPartido();

        }


    }
}
