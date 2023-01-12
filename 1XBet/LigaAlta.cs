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
    public partial class LigaAlta : Form
    {
        BELiga beLiga;
        BLLLiga bllLiga;
        public LigaAlta()
        {
            beLiga = new BELiga();
            bllLiga = new BLLLiga();
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            beLiga.Nombre = textBoxNombreLiga.Text;
            if (textBoxNombreLiga.Text.Length != 0)
            {

                if (bllLiga.BuscarLiga(beLiga) == false)
                {
                    bllLiga.GuardarLiga(beLiga);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La liga ya se encuentra cargada");
                }
            }
            else
            {
                MessageBox.Show("debe ingresar un nombre");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
