using BenchmarkDotNet.Reports;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2Dominio
{
   public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private decimal valorHora;
        private int antiguedad;
        private int horasTrabajadas;

        public Empleado(string nombre, string apellido,
            DateTime fechaNacimiento, decimal valorHora,
            int antiguedad, int horasTrabajadas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.valorHora = valorHora;
            this.antiguedad = antiguedad;
            this.horasTrabajadas = horasTrabajadas;
        }

        public decimal CalcularSalario()
        {
            return horasTrabajadas * valorHora;
        }
        

        public int CalcularLicencia()
        {
            int cantDiasLicencia = 20; //define un valor por defecto
            if (antiguedad > 5 && antiguedad<=9)
            {// si se cumple la condición, cambia el valor de la variable cantDiasLicencia
                cantDiasLicencia = 21;
            }
            else if (antiguedad > 10)
            {// si se cumple esta condición, cambia el valor de la variable cantDiasLicencia
                cantDiasLicencia = 25;
            }
            return cantDiasLicencia;
        }

        public override string ToString()
        {//Sobreescribe el método ToString que existe en object, por eso se usa la palabra override, y retorna un string con los valores
            //de los atributos 
            //En el caso de la fecha aplique el método ToShortDateString para que devuelva solo dia, mes y año
            return this.nombre + " " + this.apellido + " - " + this.fechaNacimiento.ToShortDateString() + "-" + this.valorHora + " -" + this.antiguedad + " - " + this.horasTrabajadas; 
        }
    }
}
