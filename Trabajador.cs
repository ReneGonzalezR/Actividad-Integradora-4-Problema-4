using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_4_Problema_4
{
    class Trabajador
    {
        private string Nombre;
        private string FechaNacimiento;
        private double Salario;
        private string Area;
        private double Dias;

        public Trabajador() { }

        public void SetNombre(string valor) { Nombre = valor; }
        public void SetFechaNacimiento(string valor) {  FechaNacimiento = valor; }
        public void SetSalario(double valor) { Salario = valor; }
        public void SetArea(string valor) { Area = valor; }
        public void SetDias(double valor) { Dias = valor; }

        public string GetNombre() {  return Nombre; }
        public string GetFechaNacimiento() { return FechaNacimiento; }
        public double GetSalario() { return Salario; }
        public string GetArea() { return Area; }
        public double GetDias() { return Dias; }

    }
}
