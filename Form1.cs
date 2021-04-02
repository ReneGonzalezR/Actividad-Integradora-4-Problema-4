using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_4_Problema_4
{
    public partial class Form1 : Form
    {
        Trabajador trabajador = new Trabajador();
        DateTime now = DateTime.Today;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            double porcentaje = 0;
            trabajador.SetNombre(txtNombre.Text);
            trabajador.SetFechaNacimiento(dtFecha.Text);
            trabajador.SetSalario(Convert.ToDouble(txtSalario.Text));
            trabajador.SetArea(txtArea.Text);
            trabajador.SetDias(Convert.ToDouble(txtDias.Text));

            porcentaje = trabajador.GetDias() / 15;
            double Salario = trabajador.GetSalario() * porcentaje;
            lblSalario.Text = "$ " + Salario.ToString();

            if (porcentaje > 0.87)
            {
                lblVanguardia.Text = "Si";
            }
            else
            {
                lblVanguardia.Text = "No";
            }

            DateTime fechaNacimiento = new DateTime(dtFecha.Value.Year, dtFecha.Value.Month, dtFecha.Value.Day);
            int edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;

            if (edad > 60)
            {
                lblJubilacion.Text = "Si, edad: " + edad.ToString();
            }
            else
            {
                lblJubilacion.Text = "No, edad: " + edad.ToString();
            }
        }
    }
}
