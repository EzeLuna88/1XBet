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
    public partial class EquipoVsEquipo : Form
    {
        BELiga beLiga;
        BLLEquipo bllEquipo;
        BLLLiga bllLiga;
        BLLPartido bllPartido;
        private int local;
        private int empate;
        private int visitante;
        private int indicadorLEV;
        public EquipoVsEquipo()
        {
            
            beLiga= new BELiga();
            bllEquipo= new BLLEquipo();
            bllLiga= new BLLLiga();
            bllPartido = new BLLPartido();
            InitializeComponent();
            CargarComboBox();
            LocalEmpateVisitante();
        }

        private void comboBoxLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarLiga();
            local = bllPartido.Local(beLiga);
            empate = bllPartido.Empate(beLiga);
            visitante = bllPartido.Visitante(beLiga);
            LocalEmpateVisitante();
            AmbosAnotan();
            DosPuntoCingoGoles();
            comboBoxEquipoLocal.DataSource = bllEquipo.ListarEquipos(beLiga);
            comboBoxEquipoLocal.ValueMember = "Codigo";
            comboBoxEquipoLocal.DisplayMember = "Nombre";
            comboBoxEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipoLocal.Refresh();
            
            comboBoxEquipoVisitante.DataSource = bllEquipo.ListarEquipos((BELiga)comboBoxLiga.SelectedItem);
            comboBoxEquipoVisitante.ValueMember = "Codigo";
            comboBoxEquipoVisitante.DisplayMember = "Nombre";
            comboBoxEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEquipoVisitante.Refresh();
        }

        public void SeleccionarLiga()
        {
            beLiga = (BELiga)comboBoxLiga.SelectedItem;
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

        public void AmbosAnotan()
        {
            try
            {
                BEEquipo equipo = (BEEquipo)comboBoxEquipoLocal.SelectedItem;
                int aASi = bllPartido.AmbosAnotanSi(beLiga);
                int aANo = bllPartido.AmbosAnotanNo(beLiga);
                if (aASi > aANo)
                {
                    labelAmbosAnotan.Text = "Ambos anotan Si";
                    labelLocalAA.Text = "AA Si";
                    labelVisitanteAA.Text = "AA Si";
                    
                }
                else
                {
                    labelAmbosAnotan.Text = "Ambos anotan No";
                    labelLocalAA.Text = "AA No";
                    labelVisitanteAA.Text = "AA No";
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void DosPuntoCingoGoles()
        {
            try
            {
                int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
                int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);
                if (dosPuntoCingoGolesSi > dosPuntoCingoGolesNo)
                {
                    label25Goles.Text = "2.5 Goles Si";
                    labelLocal25Goles.Text = "2.5 G Si";
                    labelVisitante25Goles.Text = "2.5 G Si";
                }
                else { label25Goles.Text = "2.5 Goles No";
                    labelLocal25Goles.Text = "2.5 G No";
                    labelVisitante25Goles.Text = "2.5 G No";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LocalEmpateVisitante()
        {
            try
            {
                int max1, max2;
                if (local > empate)
                {
                    max1 = local;
                    max2 = empate;
                    if (visitante > max2)
                    {
                        labelLev.Text = "Local/Visitante";
                        labelLocalLEP.Text = "L / V: ";
                        labelVisitanteLEP.Text = "L / V: ";
                        indicadorLEV = 1;
                    }
                    else
                    {
                        labelLev.Text = "Local/Empate";
                        labelLocalLEP.Text = "L / E: ";
                        labelVisitanteLEP.Text = "L / E: ";
                        indicadorLEV = 2;
                    }
                }
                else
                {
                    max1 = empate;
                    max2 = local;
                    if (visitante > max2)
                    {
                        labelLev.Text = "Empate/Visitante";
                        labelLocalLEP.Text = "E / V: ";
                        labelVisitanteLEP.Text = "E / V: ";
                        indicadorLEV = 3;
                    }
                    else
                    {
                        labelLev.Text = "Local/Empate";
                        labelLocalLEP.Text = "L / E: ";
                        labelVisitanteLEP.Text = "L / E: ";
                        indicadorLEV = 2;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            
            
        }

        private void comboBoxEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int local = bllPartido.Local(beLiga);
            int empate = bllPartido.Empate(beLiga);
            int visitante = bllPartido.Visitante(beLiga);
            int aASi = bllPartido.AmbosAnotanSi(beLiga);
            int aANo = bllPartido.AmbosAnotanNo(beLiga);

            

            int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
            int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);

            BEEquipo equipo = (BEEquipo)comboBoxEquipoLocal.SelectedItem;
            
            switch (indicadorLEV)
            {
                case 1:
                    textBoxLocalLEV.Text = (bllEquipo.EquipoLocalVictorias(equipo) + bllEquipo.EquipoLocalDerrotas(equipo)).ToString();
                    textBoxLocalLEVUltimos.Text = (bllEquipo.EquipoLocalUltimasVictorias(equipo) + bllEquipo.EquipoLocalUltimasDerrotas(equipo)).ToString();

                    break;
                case 2:
                    textBoxLocalLEV.Text = (bllEquipo.EquipoLocalVictorias(equipo) + bllEquipo.EquipoLocalEmpates(equipo)).ToString();
                    break;
                case 3:
                    textBoxLocalLEV.Text = (bllEquipo.EquipoLocalEmpates(equipo) + bllEquipo.EquipoLocalDerrotas(equipo)).ToString();
                    break;
                default:
                    // Código para ejecutar en caso de que no se cumpla ninguno de los casos anteriores
                    break;
            }

            if (aASi > aANo)
            {
                textBoxLocalAA.Text = bllEquipo.AmbosAnotanSi(equipo).ToString();
                textBoxLocal25Goles.Text = bllEquipo.MasDeDosPuntoCincoGolesSi(equipo).ToString();
            }
            else 
            {
                textBoxLocalAA.Text = bllEquipo.AmbosAnotanNo(equipo).ToString();
                    textBoxLocal25Goles.Text = bllEquipo.MasDeDosPuntoCincoGolesNo(equipo).ToString();
            }

        }

        private void comboBoxEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int local = bllPartido.Local(beLiga);
            int empate = bllPartido.Empate(beLiga);
            int visitante = bllPartido.Visitante(beLiga);
            int aASi = bllPartido.AmbosAnotanSi(beLiga);
            int aANo = bllPartido.AmbosAnotanNo(beLiga);
            int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
            int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);

            BEEquipo equipo = (BEEquipo)comboBoxEquipoVisitante.SelectedItem;
            switch (indicadorLEV)
            {
                case 1:
                    textBoxVisitanteLEV.Text = (bllEquipo.EquipoVisitanteVictorias(equipo) + bllEquipo.EquipoVisitanteDerrotas(equipo)).ToString();
                    break;
                case 2:
                    textBoxVisitanteLEV.Text = (bllEquipo.EquipoVisitanteVictorias(equipo) + bllEquipo.EquipoVisitanteEmpates(equipo)).ToString();
                    break;
                case 3:
                    textBoxVisitanteLEV.Text = (bllEquipo.EquipoVisitanteEmpates(equipo) + bllEquipo.EquipoVisitanteDerrotas(equipo)).ToString();
                    break;
                default:
                    // Código para ejecutar en caso de que no se cumpla ninguno de los casos anteriores
                    break;
            }

            if (aASi > aANo)
            {
                textBoxVisitanteAA.Text = bllEquipo.AmbosAnotanSi(equipo).ToString();
                textBoxVisitante25Goles.Text = bllEquipo.MasDeDosPuntoCincoGolesSi(equipo).ToString();
            }
            else
            {
                textBoxVisitanteAA.Text = bllEquipo.AmbosAnotanNo(equipo).ToString();
                textBoxVisitante25Goles.Text = bllEquipo.MasDeDosPuntoCincoGolesNo(equipo).ToString();
            }
        }

       
    }
}
