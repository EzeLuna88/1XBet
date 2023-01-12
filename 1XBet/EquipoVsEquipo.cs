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
            BEEquipo equipo = (BEEquipo)comboBoxEquipoLocal.SelectedItem;
            int local = bllPartido.Local(beLiga);
            int empate = bllPartido.Empate(beLiga);
            int visitante = bllPartido.Visitante(beLiga);
            int aASi = bllPartido.AmbosAnotanSi(beLiga);
            int aANo = bllPartido.AmbosAnotanNo(beLiga);
            int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
            int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);
            int localVictorias = bllEquipo.EquipoLocalVictorias(equipo);
            int localDerrotas = bllEquipo.EquipoLocalDerrotas(equipo);
            int localUltimasVictorias= bllEquipo.EquipoLocalUltimasVictorias(equipo);
            int localUltimasDerrotas = bllEquipo.EquipoLocalUltimasDerrotas(equipo);
            int localEmpates = bllEquipo.EquipoLocalEmpates(equipo);
            int localUltimosEmpates = bllEquipo.EquipoLocalUltimosEmpates(equipo);
            int localAASi = bllEquipo.AmbosAnotanSi(equipo);
            int localUltimosAASi = bllEquipo.AmbosAnotanSiUltimos(equipo);
            int localAANo = bllEquipo.AmbosAnotanNo(equipo);
            int localUltimosAANo = bllEquipo.AmbosAnotanNoUltimos(equipo);
            int local25GolesSi = bllEquipo.MasDeDosPuntoCincoGolesSi(equipo);
            int localUltimos25GolesSi = bllEquipo.MasDeDosPuntoCincoGolesSiUltimos(equipo);
            int local25GolesNo = bllEquipo.MasDeDosPuntoCincoGolesNo(equipo);
            int localUltimos25GolesNo = bllEquipo.MasDeDosPuntoCincoGolesNoUltimos(equipo);


            switch (indicadorLEV)
            {
                case 1:
                    textBoxLocalLEV.Text = (localVictorias + localDerrotas).ToString();
                    textBoxLocalLEVUltimos.Text = (localUltimasVictorias + localUltimasDerrotas).ToString();
                    break;
                case 2:
                    textBoxLocalLEV.Text = (localVictorias + localEmpates).ToString();
                    textBoxLocalLEVUltimos.Text = (localUltimasVictorias + localUltimosEmpates).ToString();
                    break;
                case 3:
                    textBoxLocalLEV.Text = (localEmpates + localDerrotas).ToString();
                    textBoxLocalLEVUltimos.Text = (localUltimosEmpates + localUltimasDerrotas).ToString();
                    break;
                default:
                    // Código para ejecutar en caso de que no se cumpla ninguno de los casos anteriores
                    break;
            }

            if (aASi > aANo)
            {
                textBoxLocalAA.Text = localAASi.ToString();
                textBoxLocalAAUltimos.Text = localUltimosAASi.ToString();
            }
            else 
            {
                textBoxLocalAA.Text = localAANo.ToString();
                textBoxLocalAAUltimos.Text = localUltimosAANo.ToString();
            }
            
            if(dosPuntoCingoGolesSi > dosPuntoCingoGolesNo)
            { 
                textBoxLocal25Goles.Text = local25GolesSi.ToString(); 
                textBoxLocal25GolesUltimos.Text = localUltimos25GolesSi.ToString();
            }
            else 
            { 
                textBoxLocal25Goles.Text = local25GolesNo.ToString();
                textBoxLocal25GolesUltimos.Text = localUltimos25GolesNo.ToString();

            }

        }

        private void comboBoxEquipoVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BEEquipo equipo = (BEEquipo)comboBoxEquipoVisitante.SelectedItem;
            int local = bllPartido.Local(beLiga);
            int empate = bllPartido.Empate(beLiga);
            int visitante = bllPartido.Visitante(beLiga);
            int aASi = bllPartido.AmbosAnotanSi(beLiga);
            int aANo = bllPartido.AmbosAnotanNo(beLiga);
            int dosPuntoCingoGolesSi = bllPartido.MasDeDosPuntoCincoGolesSi(beLiga);
            int dosPuntoCingoGolesNo = bllPartido.MasDeDosPuntoCincoGolesNo(beLiga);

            int victorias = bllEquipo.EquipoVisitanteVictorias(equipo);
            int derrotas = bllEquipo.EquipoVisitanteDerrotas(equipo);
            int ultimasVictorias = bllEquipo.EquipoVisitanteUltimasVictorias(equipo);
            int ultimasDerrotas = bllEquipo.EquipoVisitanteUltimasDerrotas(equipo);
            int empates = bllEquipo.EquipoVisitanteEmpates(equipo);
            int ultimosEmpates = bllEquipo.EquipoVisitanteUltimosEmpates(equipo);
            int visitanteAASi = bllEquipo.AmbosAnotanSi(equipo);
            int ultimosAASi = bllEquipo.AmbosAnotanSiUltimos(equipo);
            int visitanteAANo = bllEquipo.AmbosAnotanNo(equipo);
            int ultimosAANo = bllEquipo.AmbosAnotanNoUltimos(equipo);
            int v25GolesSi = bllEquipo.MasDeDosPuntoCincoGolesSi(equipo);
            int ultimos25GolesSi = bllEquipo.MasDeDosPuntoCincoGolesSiUltimos(equipo);
            int v25GolesNo = bllEquipo.MasDeDosPuntoCincoGolesNo(equipo);
            int ultimos25GolesNo = bllEquipo.MasDeDosPuntoCincoGolesNoUltimos(equipo);

            
            switch (indicadorLEV)
            {
                case 1:
                    textBoxVisitanteLEV.Text = (victorias + derrotas).ToString();
                    textBoxVisitanteLEVUltimos.Text = (ultimasVictorias + ultimasDerrotas).ToString();

                    break;
                case 2:
                    textBoxVisitanteLEV.Text = (victorias + empates).ToString();
                    textBoxVisitanteLEVUltimos.Text = (ultimasVictorias + ultimosEmpates).ToString();

                    break;
                case 3:
                    textBoxVisitanteLEV.Text = (empates + derrotas).ToString();
                    textBoxVisitanteLEVUltimos.Text = (ultimosEmpates + ultimasDerrotas).ToString();

                    break;
                default:
                    // Código para ejecutar en caso de que no se cumpla ninguno de los casos anteriores
                    break;
            }

            if (aASi > aANo)
            {
                textBoxVisitanteAA.Text = visitanteAASi.ToString();
                textBoxVisitanteAAUltimos.Text = ultimosAASi.ToString();
            }
            else
            {
                textBoxVisitanteAA.Text = visitanteAANo.ToString();
                textBoxVisitanteAAUltimos.Text = ultimosAANo.ToString();
            }

            if (dosPuntoCingoGolesSi > dosPuntoCingoGolesNo)
            {
                textBoxVisitante25Goles.Text = v25GolesSi.ToString();
                textBoxVisitante25GolesUltimos.Text = ultimos25GolesSi.ToString();
            }
            else
            {
                textBoxVisitante25Goles.Text = v25GolesNo.ToString();
                textBoxVisitante25GolesUltimos.Text = ultimos25GolesNo.ToString();

            }
        }

       
    }
}
