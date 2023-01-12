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
    public partial class Informes : Form
    {
        BLLLiga bllLiga;
        BLLPartido bllPartido;
        BELiga beLiga;
        public Informes()
        {
            this.WindowState = FormWindowState.Maximized;
            bllPartido = new BLLPartido();
            bllLiga = new BLLLiga();
            beLiga = new BELiga();
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

        public void CargarDatos()
        {
            int local = bllPartido.Local(beLiga);
            int empate = bllPartido.Empate(beLiga);
            int visitante = bllPartido.Visitante(beLiga);
            int aASi = bllPartido.AmbosAnotanSi(beLiga);
            int aANo = bllPartido.AmbosAnotanNo(beLiga);
            int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
            int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);

            textBoxLocal.Text = local.ToString();
            textBoxEmpate.Text = empate.ToString();
            textBoxVisitante.Text = visitante.ToString();
            textBoxAASi.Text = aASi.ToString();
            textBoxAANo.Text = aANo.ToString();
            textBox25GolesSi.Text = dosPuntoCingoGolesSi.ToString();
            textBox25GolesNo.Text = dosPuntoCingoGolesNo.ToString();

            int PartidosTotales = local + empate + visitante;

            double PorcentajeLocal = CalcularPorcentaje(local, PartidosTotales);
            AsignarPorcentajeATextBox(textBoxLocalPorcentaje, PorcentajeLocal);
            double PorcentajeEmpate = CalcularPorcentaje(empate, PartidosTotales);
            AsignarPorcentajeATextBox(textBoxEmpatePorcentaje, PorcentajeEmpate);
            double PorcentajeVisitante = CalcularPorcentaje(visitante, PartidosTotales);
            AsignarPorcentajeATextBox(textBoxVisitantePorcentaje, PorcentajeVisitante);
            double PorcentajeAASi = CalcularPorcentaje(aASi, PartidosTotales);
            AsignarPorcentajeATextBox(textBoxAASiPorcentaje, PorcentajeAASi);
            double PorcentajeAANo = CalcularPorcentaje(aANo, PartidosTotales);
            AsignarPorcentajeATextBox(textBoxAANoPorcentaje, PorcentajeAANo);
            double PorcentajeDosPuntoCincoGolesSi = CalcularPorcentaje(dosPuntoCingoGolesSi, PartidosTotales);
            AsignarPorcentajeATextBox(textBox25GolesSiPorcentaje, PorcentajeDosPuntoCincoGolesSi);
            double PorcentajeDosPuntoCincoGolesNo = CalcularPorcentaje(dosPuntoCingoGolesNo, PartidosTotales);
            AsignarPorcentajeATextBox(textBox25GolesNoPorcentaje, PorcentajeDosPuntoCincoGolesNo);

            


        }

        public void AsignarLiga()
        {
            beLiga = (BELiga)comboBoxLiga.SelectedItem;
        }

        private void comboBoxLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignarLiga();
            CargarDatos();
            CargarDatagridView();
            
        }

        public void CargarDatagridView()
        {
            dataGridViewPartidos.DataSource = null;
            dataGridViewPartidos.DataSource = bllPartido.ListarPartidos(beLiga).Tables[0];
            dataGridViewPartidos.Columns[0].HeaderText = "JOR";
            dataGridViewPartidos.Columns[1].HeaderText = "LOCAL";
            dataGridViewPartidos.Columns[2].HeaderText = "VISITANTE";
            dataGridViewPartidos.Columns[3].HeaderText = "FECHA";
            dataGridViewPartidos.Columns[4].HeaderText = "G L";
            dataGridViewPartidos.Columns[5].HeaderText = "G V";
            dataGridViewPartidos.Columns[6].HeaderText = "TA L";
            dataGridViewPartidos.Columns[7].HeaderText = "TA V";
            dataGridViewPartidos.Columns[8].HeaderText = "TR L";
            dataGridViewPartidos.Columns[9].HeaderText = "TR V";
            dataGridViewPartidos.Columns[10].HeaderText = "ESQ L";
            dataGridViewPartidos.Columns[11].HeaderText = "ESQ V";
            dataGridViewPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPartidos.RowTemplate.Height= 20;



        }

        string Porcentaje(double porcentaje)
        {
            return porcentaje.ToString("0.00");
        }

        double CalcularPorcentaje(int numero, int numero2)
        {
            return ((double)numero / numero2) * 100;
        }

        void AsignarPorcentajeATextBox(TextBox textBox, double porcentaje)
        {
            textBox.Text = Porcentaje(porcentaje) + "%";
        }
    }
}
