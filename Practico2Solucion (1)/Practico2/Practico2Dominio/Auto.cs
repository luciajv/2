using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2Dominio
{
    public class Auto
    {
        #region Atributos
        private string marca;
        private string modelo;
        private bool exoneraImpuestos;
        private int anio;
        private string matricula;

        #endregion
        public string Marca
        {
            get { return this.marca; }
        }
        public string Modelo
        {
            get { return this.modelo; }
        }
        public string ExoneraImpuestos
        {
           
            get
            {
                string exoneraImp = "No";
                if (exoneraImpuestos)
                {
                    exoneraImp = "SI";
                }
                return exoneraImp; 
            }
        }
        public int Anio
        {
            get { return this.anio; }
        }
        public string Matricula
        {
            get { return this.matricula; }
        }

        #region Metodos
        public Auto(string marca, string modelo, bool exoneraImpuestos,int anio, string matricula)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.exoneraImpuestos = exoneraImpuestos;
            this.anio = anio;
            this.matricula = matricula;
        }
        public static bool ValidarMatricula(string matricula)
        {
            return matricula.Length == 7;
           
        }
        public decimal CalcularPatente()
        {
            decimal patente = 17000;
            /*Los autos anteriores a 2015 si exoneran impuestos pagan $10.000, 
             * sino pagan $12.000.Y los posteriores a 2015 pagan $17.000*/
            if(anio<2015 && exoneraImpuestos)
            {
                patente = 10000;
            }
            else if (anio <2015 && !exoneraImpuestos)
            {
                patente = 12000;
            }

            return patente;
        }
       
       
        #endregion 
    }
}
