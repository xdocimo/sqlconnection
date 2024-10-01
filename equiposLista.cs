using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public class Equipo
        {
            public string nombreA { get; set; }
            public string nombreB { get; set; }
            public int PtsA { get; set; }
            public int PtsB { get; set; }
        }

        private List<Equipo> equipos = new List<Equipo>();

        public Form1()
        {
            InitializeComponent();
        }


        private String metodoWin()
        {
            if (radioButton1.Checked) {
                    return "mas";
                }
            if (radioButton2.Checked)
            {
                return "menos";
            }
            else
            {
                return "nada";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            equipos.Clear();
            string ganador;
            string nombreA = textBox1.Text;
            string nombreB = textBox2.Text;
            int puntosA = int.Parse(textBox3.Text);
            int puntosB = int.Parse(textBox4.Text);
            equipos.Add(new Equipo { nombreA = nombreA, PtsA = puntosA, nombreB = nombreB, PtsB = puntosB });
          
            if (metodoWin() == "mas")
            {
                if (puntosA > puntosB)
                {
                    label8.Text = $"{nombreA} tiene más puntos con {puntosA} puntos.";
                    ganador = nombreA;
                }
                else if (puntosB > puntosA)
                {
                    label8.Text = $"{nombreB} tiene más puntos con {puntosB} puntos.";
                    ganador = nombreB;
                }
                else
                {
                    label8.Text = "Ambos equipos tienen la misma cantidad de puntos.";
                    ganador = "Empate";
                }

                listBox1.Items.Add($"Nombre equipos: {nombreA} {nombreB} - Puntaje equipos: {puntosA} {puntosB} - Ganador: {ganador}");


            }
            if (metodoWin() == "menos")
            {
                if (puntosA < puntosB)
                {
                    label8.Text = $"{nombreA} tiene menos puntos con {puntosA} puntos.";
                    ganador = nombreA;
                }
                else if (puntosB < puntosA)
                {
                    label8.Text = $"{nombreB} tiene menos puntos con {puntosB} puntos.";
                    ganador = nombreB;
                }
                else
                {
                    label8.Text = "Ambos equipos tienen la misma cantidad de puntos.";
                    ganador = "Empate";
                }

                listBox1.Items.Add($"Nombre equipos: {nombreA} {nombreB} - Puntaje equipos: {puntosA} {puntosB} - Ganador: {ganador}");


                if (metodoWin() == "nada")
                {
                    label8.Text = "Seleccione criterio de aceptacion";
                }
            }

        }

    }
}
