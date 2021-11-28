using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2Dominio
{
   public class CitaMedica
    {
        private int id;
        private DateTime fecha;
        private string cedula;
        private string lugar;
        private static decimal precioBase = 100;
        private bool urgente;

        public string Urgente
        {
            get
            {
                string esUrgente = "No";
                if (urgente)
                {
                    esUrgente = "Si";
                }
                return esUrgente;
            }
        }
        public CitaMedica(int id, DateTime fecha, string cedula, string lugar,bool urgente) { 
            this.fecha = fecha;
            this.cedula = cedula;
            this.lugar = lugar;
            this.urgente = urgente;
            this.id = id;
        }
        public decimal CalcularCosto()
        {
            //Devuelve el valor del costo de la cita medica.
            decimal costo = CitaMedica.precioBase;
            if (urgente)
            {
                costo = CitaMedica.precioBase * 2;
            }
            return costo;
        }
        public override string ToString()
        {
            //Sobreescribe el método ToString de object y devuelve un string con el valor de los atributos
            //El \n representa un salto de linea 
            return " \n" + "Id: " + this.id + "\n" +
                "Fecha: " + this.fecha.ToShortDateString() + "\n" +
                "Cedula:" + this.cedula + "\n" +
                 "Lugar:" + this.lugar + "\n" +
                 "Urgente: " +Urgente;
        }
    }
}
