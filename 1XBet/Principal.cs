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
    public partial class Principal : Form
    {
        public Principal()
        {
            this.WindowState= FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ligasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liga liga = new Liga();
            liga.MdiParent= this;
            liga.Show();
            
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.MdiParent = this;
            equipo.Show();  
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partido partido = new Partido();
            partido.MdiParent = this;
            partido.Show();
        }

        private void totalPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes informes = new Informes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void vSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipoVsEquipo equipoVsEquipo = new EquipoVsEquipo();
            equipoVsEquipo.MdiParent = this;
            equipoVsEquipo.Show();
        }
    }
}
